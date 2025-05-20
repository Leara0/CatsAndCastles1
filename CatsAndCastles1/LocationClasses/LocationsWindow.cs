using CatsAndCastles1.DisplayingText;
using CatsAndCastles1.Text.Inventory;
using CatsAndCastles1.Text.Locations;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.LocationClasses;

public class LocationsWindow(string description, List<string> itemsThatWontHelp, List<string> needRope) :
    LocationsLocked(description, itemsThatWontHelp)
{
    private readonly List<string> _allPossibleUsefulItems = needRope;
    readonly UILockedRooms _uiLockedRoom = new UILockedRooms();
    
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

    public string InteractWithLockedWindow(Inventory inventory)
    {
        Screen.Print(TextDoorAndWindow.AtWindowCheckInventory);
        if (!MakeListForInteractiveMenu(inventory).Contains(TextInventoryItems.Rope)) //you don't have the rope
        {
            Screen.Print(TextDoorAndWindow.AtWindowCheckInventoryFindNothing);
        }
        else
        {
            Screen.Print(TextDoorAndWindow.WindowOptions);
        }

        string item = GetObjectChoice(inventory);
        if (item == "")
        {
            UserInput.DramaticPauseClrScreen();
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
        Screen.Print(TextDoorAndWindow.ClimbDownRope);
    }

    public void JumpDown()
    {
        Screen.Print(TextDoorAndWindow.LeapDown);
    }
}

//create a list that contains maybe rope and jump down
//say find nothing in inventory can still do jump down or leave