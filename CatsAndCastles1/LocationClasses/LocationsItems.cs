using CatsAndCastles1.DisplayingText;
using CatsAndCastles1.Text.Inventory;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.LocationClasses;

public class LocationsItems : Location
{
    private readonly UIInventory _uiInventory = new UIInventory();
    protected string Description = "";

    protected List<string> LongDescriptionOfItemsAtLocation { get; init; } = new List<string>();
    public List<string> InventoryItemsAtLocation { get; init; }= new List<string>();

    #region Constructors
    protected LocationsItems()
    {
    }

    public LocationsItems(string description, List<string> itemsAtLocation, List<string> locationsDescription)
    {
        LongDescriptionOfItemsAtLocation = locationsDescription;
        InventoryItemsAtLocation = itemsAtLocation;
        Description = description;
    }

    #endregion

    public void VisitLocation(Inventory inventory) // this is the method to call all the stuff for one location!!
    {
        DisplayLocationInfo();
        if (InventoryItemsAtLocation.Count > 0)
            AddItemsToInventory(inventory);
    }

    private void DisplayLocationInfo()
    {
        Screen.Print(Description); 
        if (LongDescriptionOfItemsAtLocation.Count == 0)
            Screen.Print("\n" + TextWorkInventory.NothingLeft);
        else
        {
            Screen.Print(TextWorkInventory.PrepToListItems);
            foreach (string item in LongDescriptionOfItemsAtLocation)
                Screen.Print(item);
        }

        UserInput.DramaticPauseClrScreen();
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