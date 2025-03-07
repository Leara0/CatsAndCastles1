namespace CatsAndCastles1;

public class InteractWithLocation(string description, List<string> locationsDescription, List<string> ItemsAtLocation)
{
    private readonly UserInput _userInput = new UserInput();
    UserInteractionsBackpack userInteractionsBackpack = new UserInteractionsBackpack();

    public bool DoorUnlocked { get; set; }

    public string LocationDescription = description;
    public List<string> LocationAndItemsDescriptions = locationsDescription;
    public List<string> InventoryItemsAtLocation = ItemsAtLocation;


    public void DisplayLocationInfo()
    {
        Console.Clear();
        Console.WriteLine(LocationDescription);
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

    public void AddItemsToInventory(BackpackMethods backpackMethods)
    {
        userInteractionsBackpack.AddItemToInventoryFromLocation(this, backpackMethods);
    }

    public void ItemHasBeenPickedUp(int itemNumber)
    {
        
        InventoryItemsAtLocation.RemoveAt(itemNumber);
        LocationAndItemsDescriptions.RemoveAt(itemNumber);
    }

    public void isDoorUnlocked(bool isUnlocked)
    {
        DoorUnlocked = isUnlocked;
    }
}