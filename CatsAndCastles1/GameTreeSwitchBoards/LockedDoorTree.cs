using CatsAndCastles1.Characters;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;
public class LockedDoorTree
{
    private readonly UserInput _userInput = new UserInput();
    public void DoorsSwitchboard(Inventory inventory, Hero cat, LockedLocations place)
        {
            if (!place.DoorIsOpen())
            {
                place.ApproachLockedDoor();
                bool catEscaped = false;
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
                        case Text.LockPickSet:
                            Screen.Print(Text.UsePickOnDoor);
                            catEscaped = true;
                            break;
                        case Text.RingOfKeys:
                            Screen.Print(Text.UseKeysOnDoor);
                            catEscaped = true;
                            break;
                        case Text.LargeStone:
                            if (place.AttemptStoneOnDoor(cat))
                                catEscaped = true;
                            break;
                        case Text.BatteredShield:
                        case Text.Shield:
                        case Text.CrudeShield:
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