namespace CatsAndCastles1;

public class DerivedWindowLocation(string description, List<string> itemsThatWontHelp, List<string> needRope) :
    DerivedLockedLocations(description, itemsThatWontHelp)
{
    private List<string> _allPossibleUsefulItems = needRope;
    UserInteractionLockedRooms userInteractionLockedRoom = new UserInteractionLockedRooms();
    private readonly UserInput _userInput = new UserInput();


    public override string GetObjectChoice(Inventory inventory)
    {
        List<string> listForIMenu = MakeListForInteractiveMenu(inventory);
        listForIMenu.Add("jump down");


        int choiceNumber = userInteractionLockedRoom.GetChoiceForLockedRoom(listForIMenu);
        if (choiceNumber == listForIMenu.Count)
            return ""; //if they choose to do nothing return ""

        string itemChoice = listForIMenu[choiceNumber];
        return itemChoice;
    }

    public override string InteractWithLockedDoor(Inventory inventory)
    {
        Console.WriteLine(TextLocation.AtWindowCheckInventory);
        if (!MakeListForInteractiveMenu(inventory).Contains(TextItemDescription.Rope)) //you don't have the rope
        {
            Console.WriteLine(TextLocation.AtWindowCheckInventoryFindNothing);
        }
        else
        {
            Console.WriteLine(TextLocation.WindowOptions);
        }

        string item = GetObjectChoice(inventory);
        if (item == "")
        {
            _userInput.DramaticPauseClrScreen();
            return "leave"; //leave this area if they choose to
        }

        return item;
    }

    public void ClimbDownWithRope()
    {
        Console.WriteLine(TextLocation.ClimbDownRope);
    }

    public void JumpDown()
    {
        Console.WriteLine(TextLocation.LeapDown);
    }
}

//create a list that contains maybe rope and jumpdown
//say find nothing in inventory can still do jumpdown or leave