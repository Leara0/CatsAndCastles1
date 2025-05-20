using CatsAndCastles1.Characters;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.Text.Inventory;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;

public static class SwitchTreeWindow
{
    public static void WindowSwitchboard(Inventory inventory, Hero cat, LocationsWindow place)
    {
        place.ApproachLockedDoor();
        string item = place.InteractWithLockedWindow(inventory);

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
                cat.Location = Hero.Place.PassedOut;
                break;
        }

        UserInput.DramaticPauseClrScreen();
    }
}