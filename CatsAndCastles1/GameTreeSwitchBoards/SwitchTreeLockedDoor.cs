using CatsAndCastles1.Characters;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.Inventory;
using CatsAndCastles1.Text.Locations;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;
public static class SwitchTreeLockedDoor
{
    public static void DoorsSwitchboard(Inventory inventory, Hero cat, LocationsLocked place)
        {
            if (!place.DoorIsOpen())
            {
                place.ApproachLockedDoor();
                bool catEscaped = false;//this is here to track if the cat got the door open
                do
                {
                    string item = place.InteractWithLockedDoor(inventory);
    
                    Console.Clear();
                    if (item == "leave")
                        return;
                    switch (item)
                    {
                        case "": //this case is if you pick a tool that doesn't work in this location
                            break;
                        case TextInventoryItems.LockPickSet:
                            Screen.Print(TextDoorAndWindow.UsePickOnDoor);
                            catEscaped = true;
                            break;
                        case TextInventoryItems.RingOfKeys:
                            Screen.Print(TextDoorAndWindow.UseKeysOnDoor);
                            catEscaped = true;
                            break;
                        case TextInventoryItems.LargeStone:
                            if (place.AttemptStoneOnDoor(cat))
                                catEscaped = true;
                            break;
                        case TextInventoryItems.BatteredShield:
                        case TextInventoryItems.Shield:
                        case TextInventoryItems.CrudeShield:
                            if (place.AttemptShieldOnDoor(cat, item, inventory))
                                catEscaped = true;
                            break;
                    }
    
                    UserInput.DramaticPauseClrScreen();
                } while (!catEscaped);
    
                place.ChangeDoorLockStatus(true);
            }
            else
            {
                place.ApproachOpenDoor();
            }
        }
}