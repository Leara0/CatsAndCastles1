namespace CatsAndCastles1;

public class DerivedItemsLocation(string description, List<string> itemsAtLocation, List<string> locationsDescription)
    : BaseLocation(description, itemsAtLocation)
{
    private readonly UserInput _userInput = new UserInput();
    UserInteractionsBackpack userInteractionsBackpack = new UserInteractionsBackpack();


    private List<string> LocationAndItemsDescriptions { get; }= locationsDescription; 
    public List<string> InventoryItemsAtLocation { get; }= itemsAtLocation;

    public void LocationMethod(Inventory inventory) // this is the method to call all the stuff for one location!!
    {
        DisplayLocationInfo();
        if (InventoryItemsAtLocation.Count > 0)
            AddItemsToInventory(inventory);
    }

    private void DisplayLocationInfo()
    {
        Console.Clear();
        Console.WriteLine(description);
        if (LocationAndItemsDescriptions.Count == 0)
            Console.WriteLine("\n" + LocationText.NothingLeft);
        else
        {
            Console.WriteLine(LocationText.PrepToListItems);
            foreach (string item in LocationAndItemsDescriptions)
                Console.WriteLine(item);
        }

        _userInput.DramaticPauseClrScreen();
    } //List items with no call to take items then clear screen and ask 'which to take' then have interactive menu with choice to leave location

    private void AddItemsToInventory(Inventory inventory)
    {
        userInteractionsBackpack.AddItemToInventoryFromLocation(this, inventory);
    }

    public void ItemHasBeenPickedUp(int itemNumber)
    {
        InventoryItemsAtLocation.RemoveAt(itemNumber);
        LocationAndItemsDescriptions.RemoveAt(itemNumber);
    }
}