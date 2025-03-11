namespace CatsAndCastles1;

public class DerivedItemsLocation : BaseLocation
{
    private readonly UserInput _userInput = new UserInput();
    private readonly UserInteractionsBackpack _userInteractionsBackpack = new UserInteractionsBackpack();
    private readonly string _description;

    public List<string> LocationAndItemsDescriptions { get; set; }
    public List<string> InventoryItemsAtLocation { get; set; }

    #region Constructors
    public DerivedItemsLocation()
    {
    }

    public DerivedItemsLocation(string description, List<string> itemsAtLocation, List<string> locationsDescription)
    {
        LocationAndItemsDescriptions = locationsDescription;
        InventoryItemsAtLocation = itemsAtLocation;
        _description = description;
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
        Console.WriteLine(_description);
        if (LocationAndItemsDescriptions.Count == 0)
            Console.WriteLine("\n" + TextLocation.NothingLeft);
        else
        {
            Console.WriteLine(TextLocation.PrepToListItems);
            foreach (string item in LocationAndItemsDescriptions)
                Console.WriteLine(item);
        }

        _userInput.DramaticPauseClrScreen();
    } //List items with no call to take items then clear screen and ask 'which to take' then have interactive menu with choice to leave location

    private void AddItemsToInventory(Inventory inventory)
    {
        _userInteractionsBackpack.AddItemToInventoryFromLocation(this, inventory);
    }

    public void ItemHasBeenPickedUp(int itemNumber)
    {
        InventoryItemsAtLocation.RemoveAt(itemNumber);
        LocationAndItemsDescriptions.RemoveAt(itemNumber);
    }
}