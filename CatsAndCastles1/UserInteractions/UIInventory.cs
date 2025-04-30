using CatsAndCastles1.Characters;
using CatsAndCastles1.Lists;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.Inventory;

namespace CatsAndCastles1.UserInteractions;

public class UIInventory
{
    private int _selectionNumber;
    
    #region Public Methods

    private bool SpaceInPack(string item, Inventory inventory) //this method will deal with a full pack
    {
        if (inventory.Pack.Count > 4)
        {
            Console.Clear();
            Screen.Print("Your pack is too burdened to add any more items. You must remove" +
                              $" something to make space for {item}.");
            _selectionNumber = UserInteractiveMenu.GiveChoices(inventory.Pack, TextWorkInventory.RemoveNothing);
            if (_selectionNumber < inventory.Pack.Count)
            {   
                inventory.DiscardedItems.Add(inventory.Pack[_selectionNumber]);
                Screen.Print($"You have removed {inventory.Pack[_selectionNumber]} from your pack");
                inventory.Pack.RemoveAt(_selectionNumber);
                
                UserInput.DramaticPauseClrScreen();
                return true;
            }
            else
            {
                Screen.Print("You've chosen not to remove any items. Nothing has been added to your pack");
                UserInput.DramaticPauseClrScreen();
                return false;
            }
        }

        return true; //if there are fewer than 5 items then there is space
    }

    public void AddItemToInventoryFromLocation(LocationsItems specific, Inventory inventory)
    {
        do
        {
            int itemNumber = GetItemSelection(specific);
            if (itemNumber == -1 || itemNumber == specific.InventoryItemsAtLocation.Count)
                return; //return if all the items are gone, or they chose to leave this area

            string item = specific.InventoryItemsAtLocation[itemNumber];

            if (item.Contains("gold"))
            {
                AddGold(item, inventory);
                specific.ItemHasBeenPickedUp(itemNumber);
                UserInput.DramaticPauseClrScreen();
            }
            else if (SpaceInPack(item, inventory))
            {
                inventory.Pack.Add(item);
               Screen.Print($"\nYour pack now contains {item}");
                specific.ItemHasBeenPickedUp(itemNumber);
                UserInput.DramaticPauseClrScreen();
            }
            
        } while (true); // this ends if they choose to leave this area
    }

    private void AddGold(string item, Inventory inventory)
    {
        Screen.Print($"Your coin purse now contains {inventory.AddGoldToPurse(item)} gold coins");
    }

    public void AddItemToInventoryFromDiscard(Inventory inventory)
    {
        do
        {
            int itemNumber = PickFromDiscard(inventory);
            if (itemNumber == -1 || itemNumber == inventory.DiscardedItems.Count)
                return; //return if all the items are gone, or they chose to leave the stash alone

            string item = inventory.DiscardedItems[itemNumber];

            if (SpaceInPack(item, inventory))
            {
                inventory.Pack.Add(item);
                Screen.Print($"You pack now contains {item}");
                inventory.DiscardedItems.RemoveAt(itemNumber);
                UserInput.DramaticPauseClrScreen();
            }
        } while (true); // this ends if they choose to leave this area
    }

    #endregion


    private int GetItemSelection(LocationsItems specific)
    {
        if (specific.InventoryItemsAtLocation.Count == 0)
        {
            // if all the items have been taken display that info and pause
            Screen.Print(TextWorkInventory.NothingLeft);
            UserInput.DramaticPauseClrScreen();
            return -1;
        }

        Screen.Print(TextWorkInventory.ChoiceToTakeItems + "\n");
        _selectionNumber =
            UserInteractiveMenu.GiveChoices(specific.InventoryItemsAtLocation, TextGeneral.LeaveLocation);

        return _selectionNumber;
    }

    private int PickFromDiscard(Inventory inventory)
    {
        Console.Clear();
        if (inventory.DiscardedItems.Count == 0)
        {
            Screen.Print(TextWorkInventory.EmptyStash);
            UserInput.DramaticPauseClrScreen();
            return -1;
        }

        Screen.Print(TextWorkInventory.PickUpFromStash + "\n");
        _selectionNumber =
            UserInteractiveMenu.GiveChoices(inventory.DiscardedItems, TextWorkInventory.PickUpNothing);

        return _selectionNumber;
    }
    private int PickFromInventory(Inventory inventory)
    {
        Screen.Print(TextWorkInventory.AmountInCoinPurse + inventory.CheckPurseInventory() + TextWorkInventory.GoldCoins);
        
        if (inventory.Pack.Count == 0)
        {
            Screen.Print(TextWorkInventory.EmptyInventory);
            UserInput.DramaticPauseClrScreen();
            return -1;
        }

        Screen.Print(TextWorkInventory.ThinkAboutInventory + "\n");
        _selectionNumber =
            UserInteractiveMenu.GiveChoices(inventory.Pack, TextWorkInventory.PickUpNothing);

        return _selectionNumber;
    }

    public void RemoveItemFromInventory(Hero cat, Inventory inventory)
    {
        Console.Clear();
        do
        {
            int itemNumber = PickFromInventory(inventory);
            if (itemNumber == -1 || itemNumber == inventory.Pack.Count)
                return; //return if all the items are gone, or they chose to quit removing from inventory

            string item = inventory.Pack[itemNumber];
            if (item.Contains("vial"))
            {
                Screen.Print(TextWorkInventory.DrinkElixir);
                cat.Health += 10;
                inventory.Pack.Remove(item);
                UserInput.DramaticPauseClrScreen();
                return;
            }

            inventory.DiscardedItems.Add(item);
            Screen.Print($"You have removed {item} from your pack");
            if (ListWeaponsInfo.ShieldOptions.Contains(item))
                cat.HasShield = false;
            inventory.Pack.Remove(item);
            UserInput.DramaticPauseClrScreen();
        } while (true); // this ends if they choose to leave this area
    }

    
}