namespace CatsAndCastles1;

public class UserInteractionsBackpack
{
    #region Fields and Class Instances

    InteractiveMenu interactiveMenu = new InteractiveMenu();
    public int selectionNumber;
    private readonly UserInput _userInput = new UserInput();

    #endregion

    #region Constructor

    public UserInteractionsBackpack()
    {
    }

    public UserInteractionsBackpack(LocationDescriptions location, BackpackMethods packMethods)
    {
    }

    #endregion

    #region Public Methods

    public bool SpaceInPack(string item, BackpackMethods packMethods) //this method will deal with a full pack
    {
        if (packMethods.Pack.Count > 4)
        {
            Console.WriteLine("Your pack is too burdened to add any more items. You must remove" +
                              $" something to make space for {item}.");
            selectionNumber = interactiveMenu.GiveChoices(packMethods.Pack, LocationText.RemoveNothing);
            if (selectionNumber < packMethods.Pack.Count)
            {
                packMethods.Pack.RemoveAt(selectionNumber);
                Console.WriteLine($"You have removed {item} from your pack");
                _userInput.DramaticPauseClrScreen();
                return true;
            }
            else
            {
                Console.WriteLine("You've chosen not to remove any items. Nothing has been added to your pack");
                _userInput.DramaticPauseClrScreen();
                return false;
            }
        }

        return true; //if there are fewer than 5 items then there is space
    }

    public void AddItemToInventoryFromLocation(InteractWithLocation specificLocation, BackpackMethods packMethods)
    {
        do
        {
            int itemNumber = GetItemSelection(specificLocation);
            if (itemNumber == -1 || itemNumber == specificLocation.InventoryItemsAtLocation.Count)
                return; //return if all the items are gone or they chose to leave this area

            string item = specificLocation.InventoryItemsAtLocation[itemNumber];

            if (item.Contains("gold"))
                AddGold(item, packMethods);

            else if (SpaceInPack(item, packMethods))
            {
                packMethods.Pack.Add(item);
                Console.WriteLine($"You pack now contains {item}");
                specificLocation.ItemHasBeenPickedUp(itemNumber);
                _userInput.DramaticPauseClrScreen();
            }
        } while (true); // this ends if they choose to leave this area
    }

    public void AddGold(string item, BackpackMethods packMethods)
    {
        Console.WriteLine($"Your coin purse now contains {packMethods.AddGoldToPurse(item)} gold coins");
    }

    public void AddItemToInventoryFromDiscard(BackpackMethods packMethods)
    {
        do
        {
            int itemNumber = PickFromDiscard(packMethods);
            if (itemNumber == -1 || itemNumber == packMethods.DiscardedItems.Count)
                return; //return if all the items are gone or they chose to leave the stash alone

            string item = packMethods.DiscardedItems[itemNumber];

            if (SpaceInPack(item, packMethods))
            {
                packMethods.Pack.Add(item);
                Console.WriteLine($"You pack now contains {item}");
                packMethods.DiscardedItems.RemoveAt(itemNumber);
                _userInput.DramaticPauseClrScreen();
            }
        } while (true); // this ends if they choose to leave this area
    }
    public void RemoveItemFromInventory(BackpackMethods packMethods)
    {
        do
        {
            int itemNumber = PickFromInventory(packMethods);
            if (itemNumber == -1 || itemNumber == packMethods.Pack.Count)
                return; //return if all the items are gone or they chose to quit removing from inventory

            string item = packMethods.Pack[itemNumber];

            if (SpaceInPack(item, packMethods))
            {
                packMethods.DiscardedItems.Add(item);
                Console.WriteLine($"You have removed {item} from your pack");
                packMethods.Pack.RemoveAt(itemNumber);
                _userInput.DramaticPauseClrScreen();
            }
        } while (true); // this ends if they choose to leave this area
    }

    public int GetItemSelection(InteractWithLocation specificLocation)
    {
        if (specificLocation.InventoryItemsAtLocation.Count == 0)
        {
            // if all the items have been taken display that info and pause
            Console.WriteLine(LocationText.NothingLeft);
            _userInput.DramaticPauseClrScreen();
            return -1;
        }

        Console.WriteLine(LocationText.ChoiceToTakeItems + "\n");
        Console.WriteLine(LocationText.HowToPickAnItem);
        selectionNumber =
            interactiveMenu.GiveChoices(specificLocation.InventoryItemsAtLocation, LocationText.LeaveLocation);

        return selectionNumber;
    }

    public int PickFromDiscard(BackpackMethods packMethods)
    {
        if (packMethods.DiscardedItems.Count == 0)
        {
            Console.WriteLine(LocationText.EmptyStash);
            _userInput.DramaticPauseClrScreen();
            return -1;
        }

        Console.WriteLine(LocationText.PickUpFromStash + "\n");
        Console.WriteLine(LocationText.HowToPickAnItem);
        selectionNumber =
            interactiveMenu.GiveChoices(packMethods.DiscardedItems, LocationText.PickUpNothing);

        return selectionNumber;
    }

    public int PickFromInventory(BackpackMethods packMethods)
    {
        if (packMethods.Pack.Count == 0)
        {
            Console.WriteLine(LocationText.EmptyInventory);
            _userInput.DramaticPauseClrScreen();
            return -1;
        }

        Console.WriteLine(LocationText.ThinkAboutInventory + "\n");
        Console.WriteLine(LocationText.HowToPickAnItem);
        selectionNumber =
            interactiveMenu.GiveChoices(packMethods.Pack, LocationText.PickUpNothing);

        return selectionNumber;
    }

    

    public void SpendGold(int amount, BackpackMethods backpackMethods)
    {
        int total = backpackMethods.SpendGold(amount);
        if (total == -1)
        {
            Console.WriteLine(LocationText.InsufficientFunds);
        }
        else
        {
            Console.WriteLine($"Your purse now contains {total} gold coins");
        }
    }
   #endregion
}