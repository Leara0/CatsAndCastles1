using CatsAndCastles1.Lists;
using CatsAndCastles1.LocationClasses;

namespace CatsAndCastles1.UserInteractions;

public class UIInventory
{
    #region Fields and Class Instances

    UserInteractiveMenu _userInteractiveMenu = new UserInteractiveMenu();
    private int _selectionNumber;
    private readonly UserInput _userInput = new UserInput();

    #endregion

    #region Constructor

    public UIInventory()
    {
    }

    public UIInventory(LocationsLists location, Inventory inventory)
    {
    }

    #endregion

    #region Public Methods

    public bool SpaceInPack(string item, Inventory inventory) //this method will deal with a full pack
    {
        if (inventory.Pack.Count > 4)
        {
            Console.Clear();
            Screen.Print("Your pack is too burdened to add any more items. You must remove" +
                              $" something to make space for {item}.");
            _selectionNumber = _userInteractiveMenu.GiveChoices(inventory.Pack, Text.RemoveNothing);
            if (_selectionNumber < inventory.Pack.Count)
            {   
                inventory.DiscardedItems.Add(inventory.Pack[_selectionNumber]);
                Screen.Print($"You have removed {inventory.Pack[_selectionNumber]} from your pack");
                inventory.Pack.RemoveAt(_selectionNumber);
                
                _userInput.DramaticPauseClrScreen();
                return true;
            }
            else
            {
                Screen.Print("You've chosen not to remove any items. Nothing has been added to your pack");
                _userInput.DramaticPauseClrScreen();
                return false;
            }
        }

        return true; //if there are fewer than 5 items then there is space
    }

    public void AddItemToInventoryFromLocation(ItemsLocation specificLocation, Inventory inventory)
    {
        do
        {
            int itemNumber = GetItemSelection(specificLocation);
            if (itemNumber == -1 || itemNumber == specificLocation.InventoryItemsAtLocation.Count)
                return; //return if all the items are gone or they chose to leave this area

            string item = specificLocation.InventoryItemsAtLocation[itemNumber];

            if (item.Contains("gold"))
            {
                AddGold(item, inventory);
                specificLocation.ItemHasBeenPickedUp(itemNumber);
                _userInput.DramaticPauseClrScreen();
            }
            else if (SpaceInPack(item, inventory))
            {
                inventory.Pack.Add(item);
                Screen.Print($"You pack now contains {item}");
                specificLocation.ItemHasBeenPickedUp(itemNumber);
                _userInput.DramaticPauseClrScreen();
            }
            
        } while (true); // this ends if they choose to leave this area
    }

    public void AddGold(string item, Inventory inventory)
    {
        Screen.Print($"Your coin purse now contains {inventory.AddGoldToPurse(item)} gold coins");
    }

    public void AddItemToInventoryFromDiscard(Inventory inventory)
    {
        do
        {
            int itemNumber = PickFromDiscard(inventory);
            if (itemNumber == -1 || itemNumber == inventory.DiscardedItems.Count)
                return; //return if all the items are gone or they chose to leave the stash alone

            string item = inventory.DiscardedItems[itemNumber];

            if (SpaceInPack(item, inventory))
            {
                inventory.Pack.Add(item);
                Screen.Print($"You pack now contains {item}");
                inventory.DiscardedItems.RemoveAt(itemNumber);
                _userInput.DramaticPauseClrScreen();
            }
        } while (true); // this ends if they choose to leave this area
    }

    #endregion


    private int GetItemSelection(ItemsLocation specificLocation)
    {
        if (specificLocation.InventoryItemsAtLocation.Count == 0)
        {
            // if all the items have been taken display that info and pause
            Screen.Print(Text.NothingLeft);
            _userInput.DramaticPauseClrScreen();
            return -1;
        }

        Screen.Print(Text.ChoiceToTakeItems + "\n");
        _selectionNumber =
            _userInteractiveMenu.GiveChoices(specificLocation.InventoryItemsAtLocation, Text.LeaveLocation);

        return _selectionNumber;
    }

    private int PickFromDiscard(Inventory inventory)
    {
        Console.Clear();
        if (inventory.DiscardedItems.Count == 0)
        {
            Screen.Print(Text.EmptyStash);
            _userInput.DramaticPauseClrScreen();
            return -1;
        }

        Screen.Print(Text.PickUpFromStash + "\n");
        _selectionNumber =
            _userInteractiveMenu.GiveChoices(inventory.DiscardedItems, Text.PickUpNothing);

        return _selectionNumber;
    }
    private int PickFromInventory(Inventory inventory)
    {
        if (inventory.Pack.Count == 0)
        {
            Screen.Print(Text.EmptyInventory);
            _userInput.DramaticPauseClrScreen();
            return -1;
        }

        Screen.Print(Text.ThinkAboutInventory + "\n");
        _selectionNumber =
            _userInteractiveMenu.GiveChoices(inventory.Pack, Text.PickUpNothing);

        return _selectionNumber;
    }

    public void RemoveItemFromInventory(Inventory inventory)
    {
        Console.Clear();
        do
        {
            int itemNumber = PickFromInventory(inventory);
            if (itemNumber == -1 || itemNumber == inventory.Pack.Count)
                return; //return if all the items are gone or they chose to quit removing from inventory

            string item = inventory.Pack[itemNumber];

            inventory.DiscardedItems.Add(item);
            Screen.Print($"You have removed {item} from your pack");
            inventory.Pack.RemoveAt(itemNumber);
            _userInput.DramaticPauseClrScreen();
        } while (true); // this ends if they choose to leave this area
    }

    


    public void SpendGold(int amount, Inventory inventory)
    {
        int total = inventory.SpendGold(amount);
        if (total == -1)
        {
            Screen.Print(Text.InsufficientFunds);
        }
        else
        {
            Screen.Print($"Your purse now contains {total} gold coins");
        }
    }
}