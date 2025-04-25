using CatsAndCastles1.Characters;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.Inventory;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;

public class SwitchTreeWindow
{
    private readonly UserInput UserInput = new UserInput();
    public void WindowSwitchboard(Inventory inventory, Hero cat, LocationsWindow place)
    {
        place.ApproachLockedDoor();
        string item = place.InteractWithlockedWindow(inventory);

        Console.Clear();
        if (item == "leave")
            return;
        switch (item)
        {
            case TextInventoryItems.Rope:
                place.ClimbDownWithRope();
                cat.Location = Hero.Place.OutsideCastle;
                break;
            case "jump down":
                place.JumpDown();
                cat.Location = Hero.Place.Dead;
                break;
        }

        UserInput.DramaticPauseClrScreen();
    }
}