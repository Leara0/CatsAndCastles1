namespace CatsAndCastles1;

public class WindowLocation(string description, List<string> itemsThatWontHelp, List<string> needRope) :
    LockedLocations(description, itemsThatWontHelp)
{
    private List<string> _allPossibleUsefulItems = needRope;
    UILockedRooms _uiLockedRoom = new UILockedRooms();
    private readonly UserInput _userInput = new UserInput();


    public override string GetObjectChoice(Inventory inventory)
    {
        List<string> listForIMenu = MakeListForInteractiveMenu(inventory);
        listForIMenu.Add("jump down");


        int choiceNumber = _uiLockedRoom.GetChoiceForLockedRoom(listForIMenu);
        if (choiceNumber == listForIMenu.Count)
            return ""; //if they choose to do nothing return ""

        string itemChoice = listForIMenu[choiceNumber];
        return itemChoice;
    }

    public string InteractWithlockedWindow(Inventory inventory)
    {
        Console.WriteLine(Text.AtWindowCheckInventory);
        if (!MakeListForInteractiveMenu(inventory).Contains(Text.Rope)) //you don't have the rope
        {
            Console.WriteLine(Text.AtWindowCheckInventoryFindNothing);
        }
        else
        {
            Console.WriteLine(Text.WindowOptions);
        }

        string item = GetObjectChoice(inventory);
        if (item == "")
        {
            _userInput.DramaticPauseClrScreen();
            return "leave"; //leave this area if they choose to
        }

        return item;
    }
    public override List<string> MakeListForInteractiveMenu(Inventory inventory)
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

    public void ClimbDownWithRope()
    {
        Console.WriteLine(Text.ClimbDownRope);
    }

    public void JumpDown()
    {
        Console.WriteLine(Text.LeapDown);
    }
}

//create a list that contains maybe rope and jumpdown
//say find nothing in inventory can still do jumpdown or leave