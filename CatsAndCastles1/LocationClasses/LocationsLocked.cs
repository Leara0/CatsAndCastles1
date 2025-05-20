using CatsAndCastles1.Characters;
using CatsAndCastles1.DisplayingText;
using CatsAndCastles1.Lists;
using CatsAndCastles1.Text.Inventory;
using CatsAndCastles1.Text.Locations;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.LocationClasses;

public class LocationsLocked : LocationsItems
{
    readonly UILockedRooms _uiLockedRoom = new UILockedRooms();
    
    private readonly List<string> _allPossibleUsefulItems = ListLockPickingTools.AllPossibleOptions;
    private List<string> ItemsThatWontHelp { get; set; }
    
    private readonly string _doorDescription;

    #region Constructors

    public LocationsLocked(string description, List<string> itemsThatWontHelp)
    {
        _doorDescription = description;
        ItemsThatWontHelp = itemsThatWontHelp;
    }//use this one for the door in the main room

    public LocationsLocked(string doorDescription, string descriptionInsideRoom, List<string> itemsThatWontHelp, List<string> itemsAtLocation,
        List<string> longDescOfItemsAtLocation)
    {
        _doorDescription = doorDescription;
        Description = descriptionInsideRoom;
        ItemsThatWontHelp = itemsThatWontHelp;
        LongDescriptionOfItemsAtLocation = longDescOfItemsAtLocation;
        InventoryItemsAtLocation = itemsAtLocation;
    }//use this constructor to create a room you want to enter with a locked door

    #endregion


    #region Methods

    public virtual List<string> MakeListForInteractiveMenu(Inventory inventory)
    {
        List<string> optionsForIMenu = new List<string>();

        foreach (string item in inventory.Pack)
        {
            foreach (string usefulItems in _allPossibleUsefulItems)
                if (item == usefulItems)
                    optionsForIMenu.Add(usefulItems);
        }

        return optionsForIMenu;
    }

    public virtual string GetObjectChoice(Inventory inventory)
    {
        List<string> listForIMenu = MakeListForInteractiveMenu(inventory);


        int choiceNumber = _uiLockedRoom.GetChoiceForLockedRoom(listForIMenu);
        if (choiceNumber == listForIMenu.Count)
            return ""; //if they choose to do nothing return ""

        string itemChoice = listForIMenu[choiceNumber];
        return itemChoice;
    }


    public void ApproachLockedDoor()
    {
        Console.Clear();
        Screen.Print(_doorDescription); //@TODO change this to the description in the parameters
        UserInput.DramaticPauseClrScreen();
    }

    public virtual string InteractWithLockedDoor(Inventory inventory)
    {
        Screen.Print(TextDoorAndWindow.AtDoorCheckInventory);
        if (MakeListForInteractiveMenu(inventory).Count == 0)
        {
            Screen.Print(TextDoorAndWindow.AtDoorCheckInventoryFindNothing);
            UserInput.DramaticPauseClrScreen();
            return "leave"; //explain you found nothing and return empty string to indicate leave this location
        }

        string item = GetObjectChoice(inventory);
        if (item == "")
        {
            UserInput.DramaticPauseClrScreen();
            return "leave"; //leave this area if they choose to
        }

        if (ItemsThatWontHelp.Contains(item))
        {
            if (item == TextInventoryItems.RingOfKeys)
                Screen.Print(TextDoorAndWindow.KeysWontWork);
            if (item == TextInventoryItems.LockPickSet)
                Screen.Print(TextDoorAndWindow.LockPickWontWork);
            UserInput.DramaticPauseClrScreen();
            return ""; // if you tried a tool that doesn't work you need to loop again
        }

        return item;
    }

    public void ApproachOpenDoor()
    {
        Screen.Print(TextDoorAndWindow.OpenDoor); //approach door
        UserInput.DramaticPauseClrScreen();
    }

    public bool AttemptStoneOnDoor(Character cat)
    {
        return _uiLockedRoom.UseStoneOnDoor(cat);
    }

    public bool AttemptShieldOnDoor(Character cat, string item, Inventory inventory)
    {
        return _uiLockedRoom.UseShieldOnDoor(cat, item, inventory);
    }

    #endregion
}