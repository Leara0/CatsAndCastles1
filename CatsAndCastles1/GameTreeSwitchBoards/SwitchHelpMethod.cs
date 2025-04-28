using CatsAndCastles1.Characters;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;

public class SwitchHelpMethod
{
    public static void TryToUnlockDoorAndVisitRoom(Inventory inventory, Hero cat, LocationsLocked location)
    {
        if (!location.DoorIsOpen())
        {
            SwitchTreeLockedDoor.DoorsSwitchboard(inventory, cat, location);
            if (!location.DoorIsOpen()) return;
        }

        location.VisitLocation(inventory);
    }
    public static void DoStairs(Hero cat, Hero.Place place, string text)
    {
        Screen.Print(text);
        UserInput.DramaticPauseClrScreen();
        cat.Location = place;
    }
}