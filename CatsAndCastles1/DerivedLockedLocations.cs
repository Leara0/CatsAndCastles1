namespace CatsAndCastles1;

public class DerivedLockedLocations : DerivedItemsLocation
{
    private List<string> _allPossibleUsefulItems = ListsForLockedPlaces.AllPossibleOptions;
    public List<string> ItemsThatWontHelp { get; set; }
    private readonly UserInput _userInput = new UserInput();
    UserInteractionLockedRooms userInteractionLockedRoom = new UserInteractionLockedRooms();
    public string Description = "";

    #region Constructors

    public DerivedLockedLocations(string description, List<string> itemsThatWontHelp)
    {
        Description = description;
        ItemsThatWontHelp = itemsThatWontHelp;
    }//use this one for the door in the main room

    public DerivedLockedLocations(string description, List<string> itemsThatWontHelp, List<string> itemsAtLocation,
        List<string> locationsDescription)
    {
        Description = description;
        ItemsThatWontHelp = itemsThatWontHelp;
        LocationAndItemsDescriptions = locationsDescription;
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


        int choiceNumber = userInteractionLockedRoom.GetChoiceForLockedRoom(listForIMenu);
        if (choiceNumber == listForIMenu.Count)
            return ""; //if they choose to do nothing return ""

        string itemChoice = listForIMenu[choiceNumber];
        return itemChoice;
    }


    public void ApproachLockedDoor()
    {
        Console.Clear();
        Console.WriteLine(Description); //@TODO change this to the description in the parameters
        _userInput.DramaticPauseClrScreen();
    }

    public virtual string InteractWithLockedDoor(Inventory inventory)
    {
        Console.WriteLine(Text.AtDoorCheckInventory);
        if (MakeListForInteractiveMenu(inventory).Count == 0)
        {
            Console.WriteLine(Text.AtDoorCheckInventoryFindNothing);
            _userInput.DramaticPauseClrScreen();
            return "leave"; //explain you found nothing and return empty string to indicate leave this location
        }

        string item = GetObjectChoice(inventory);
        if (item == "")
        {
            _userInput.DramaticPauseClrScreen();
            return "leave"; //leave this area if they choose to
        }

        if (ItemsThatWontHelp.Contains(item))
        {
            if (item == Text.RingOfKeys)
                Console.WriteLine(Text.KeysWontWork);
            if (item == Text.LockPickSet)
                Console.WriteLine(Text.LockPickWontWork);
            _userInput.DramaticPauseClrScreen();
            return ""; // if you tried a tool that doesn't work you need to loop again
        }

        return item;
    }

    public void ApproachOpenDoor()
    {
        Console.WriteLine(Text.OpenDoor); //approach door
        _userInput.DramaticPauseClrScreen();
    }

    public bool AttemptStoneOnDoor(Characters cat)
    {
        return userInteractionLockedRoom.UseStoneOnDoor(cat);
    }

    public bool AttemptShieldOnDoor(Characters cat, string item, Inventory inventory)
    {
        return userInteractionLockedRoom.UseShieldOnDoor(cat, item, inventory);
    }

    #endregion
}