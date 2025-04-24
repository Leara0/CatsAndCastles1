using CatsAndCastles1.Characters;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.Locations;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;

public class SecondFloorTree
{
    private readonly UserInput _userInput = new UserInput();

    public void SecondFloorSwitchboard(Inventory inventory, Hero cat, BadGuy guard2, Location secondFloor,
        LockedLocations meetingRoomF2D1, LockedLocations guardQuartersF2D2, LockedLocations closetF2R3,
        LockedLocations libraryF2R4)
    {
        Console.Clear();
        cat.EndGame = false;
        cat.SuccessfulBribed = false;
        UIInventory uiInventory = new UIInventory();
        cat.SuccessfulBribed = false;

        secondFloor.PrintIntro();
        LockedDoorTree lockedDoorTree = new LockedDoorTree();
        

        do
        {
            int whereToExplore = secondFloor.RoomMethod();
            Console.Clear();
            switch (whereToExplore) //this is a call on the BaseLocation class
            {
                case 0: // meeting room
                    if (!meetingRoomF2D1.DoorIsOpen())
                        lockedDoorTree.DoorsSwitchboard(inventory, cat, meetingRoomF2D1);
                    if (meetingRoomF2D1.DoorIsOpen())
                        meetingRoomF2D1.LocationMethod(inventory);
                    break;
                case 1: //guard's quarters (//@TODO put guard to fight in here!)
                    GuardEncounterTree.GuardEncounterSwitchboard(cat, guard2, inventory);
                    //door is not locked
                    guardQuartersF2D2.LocationMethod(inventory);
                    break;
                case 2: //closet
                    if (!closetF2R3.DoorIsOpen())
                        lockedDoorTree.DoorsSwitchboard(inventory, cat, closetF2R3);
                    if (closetF2R3.DoorIsOpen())
                        closetF2R3.LocationMethod(inventory);
                    break;
                case 3: //library
                    if (!libraryF2R4.DoorIsOpen())
                        lockedDoorTree.DoorsSwitchboard(inventory, cat, libraryF2R4);
                    if (libraryF2R4.DoorIsOpen())
                        libraryF2R4.LocationMethod(inventory);
                    break;
                case 4: //go upstairs
                    Screen.Print(TextGeneral.HeadUpStairs);
                    cat.Location = Hero.Place.ThirdFloor;
                    break;
                case 5: //go downstairs
                    Screen.Print(TextGeneral.HeadDownStairs);
                    cat.Location = Hero.Place.FirstFloor;
                    break;
                case 6: //inventory
                    uiInventory.RemoveItemFromInventory(cat, inventory);
                    break;
            }
        } while (cat.Location == Hero.Place.SecondFloor);
    }
}