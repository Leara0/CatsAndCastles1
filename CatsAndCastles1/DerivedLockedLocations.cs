namespace CatsAndCastles1;

public class DerivedLockedLocations(string description, List<string> itemsThatHelp, List<string> itemsThatWontHelp) :
    DerivedItemsLocation
{
    //what is my goal here:
    /*Create a tree for what items you have vs need
     *
     *
     */
    private List<string> AllPossibleUsefulItems { get; set; } = itemsThatHelp;
    public List<string> ItemsThatWontHelp { get; set; } = itemsThatWontHelp;
    private readonly UserInput _userInput = new UserInput();


    public string GetObjectChoice(Inventory inventory)
    {
        List<string> listForIMenu = MakeListForInteractiveMenu(inventory);
        UserInteractionLockedRooms userInteractionLockedRoom = new UserInteractionLockedRooms();

        int choiceNumber = userInteractionLockedRoom.GetChoiceForLockedRoom(listForIMenu);
        if (choiceNumber == listForIMenu.Count)
            return ""; //if they choose to do nothing return ""

        string itemChoice = listForIMenu[choiceNumber];
        return itemChoice;
    }


    public List<string> MakeListForInteractiveMenu(Inventory inventory)
    {
        List<string> optionsForIMenu = new List<string>();

        foreach (string item in inventory.Pack)
        {
            foreach (string usefulItems in AllPossibleUsefulItems)
                if (item == usefulItems)
                    optionsForIMenu.Add(usefulItems);
        }

        return optionsForIMenu;
    }

    public void ApproachLockedDoor()
    {
        Console.WriteLine(TextLocation.ExploreDoor);
        _userInput.DramaticPauseClrScreen();
    }
    public string InteractWithLockedDoor(Inventory inventory)
    {
        Console.WriteLine(TextLocation.AtDoorCheckInventory);
        if (MakeListForInteractiveMenu(inventory).Count == 0)
        {
            Console.WriteLine(TextLocation.AtDoorCheckInventoryFindNothing);
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
            if (item == TextItemDescription.RingOfKeys)
                Console.WriteLine(TextLocation.KeysWontWork);
            if (item == TextItemDescription.LockPickSet)
                Console.WriteLine(TextLocation.LockPickWontWork);
            _userInput.DramaticPauseClrScreen();
            return ""; // if you tried a tool that doesn't work you need to loop again
        }

        return item;
    }

    public void ApproachOpenDoor()
    {
        Console.WriteLine(TextLocation.OpenDoor); //approach door
        _userInput.DramaticPauseClrScreen();
        
    }
}