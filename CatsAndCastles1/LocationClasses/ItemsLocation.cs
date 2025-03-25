using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.LocationClasses;

public class ItemsLocation : Location
{
    private readonly UserInput _userInput = new UserInput();
    private readonly UIInventory _uiInventory = new UIInventory();
    public string description;

    public List<string> LongDescriptionOfItemsAtLocation { get; set; }
    public List<string> InventoryItemsAtLocation { get; set; }

    #region Constructors
    public ItemsLocation()
    {
    }

    public ItemsLocation(string description, List<string> itemsAtLocation, List<string> locationsDescription)
    {
        LongDescriptionOfItemsAtLocation = locationsDescription;
        InventoryItemsAtLocation = itemsAtLocation;
        description = description;
    }

    #endregion

    public void LocationMethod(Inventory inventory) // this is the method to call all the stuff for one location!!
    {
        DisplayLocationInfo();
        if (InventoryItemsAtLocation.Count > 0)
            AddItemsToInventory(inventory);
    }

    private void DisplayLocationInfo()
    {
        Console.WriteLine(description);
        if (LongDescriptionOfItemsAtLocation.Count == 0)
            Console.WriteLine("\n" + Text.NothingLeft);
        else
        {
            Console.WriteLine(Text.PrepToListItems);
            foreach (string item in LongDescriptionOfItemsAtLocation)
                Console.WriteLine(item);
        }

        _userInput.DramaticPauseClrScreen();
    } //List items with no call to take items then clear screen and ask 'which to take' then have interactive menu with choice to leave location

    private void AddItemsToInventory(Inventory inventory)
    {
        _uiInventory.AddItemToInventoryFromLocation(this, inventory);
    }

    public void ItemHasBeenPickedUp(int itemNumber)
    {
        InventoryItemsAtLocation.RemoveAt(itemNumber);
        LongDescriptionOfItemsAtLocation.RemoveAt(itemNumber);
    }
}