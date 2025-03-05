namespace CatsAndCastles1;

public class InteractWithLocation(string[] locations)
{
    private readonly UserInput _userInput = new UserInput();

    public bool DoorUnlocked { get; set; }


    public string[] _locationAndItemsDescriptions;
    public string[] _inventoryItemsAtLocation;

    public void LocationDescription(string[] locationText) => _locationAndItemsDescriptions = locationText;

    public void LocationInventory(string[] locationText) => _inventoryItemsAtLocation = locationText;

    public void DisplayLocationInfo()
    {
        //This is what happens when you first enter a room
        Console.WriteLine(_locationAndItemsDescriptions[0]);
        Console.WriteLine(_locationAndItemsDescriptions[1]);
        Console.WriteLine(_locationAndItemsDescriptions[2]);
        Console.WriteLine(_locationAndItemsDescriptions[3]);
        Console.WriteLine(LocationText.ChoiceToTakeItems);
        _userInput.DramaticPauseClrScreen();
    }
    

    public void ItemHasBeenPickedUp(int itemNumber)
    {
        _inventoryItemsAtLocation[itemNumber] = LocationText.EmptySpot;
        _locationAndItemsDescriptions[itemNumber + 1] = LocationText.EmptySpot;
    }

    public void DoorLocked()
    {
        //I'm not sure what this will look like
    }
}