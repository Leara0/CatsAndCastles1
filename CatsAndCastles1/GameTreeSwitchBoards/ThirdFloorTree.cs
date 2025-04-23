using CatsAndCastles1.Characters;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;

public class ThirdFloorTree
{
    private readonly UserInput _userInput = new UserInput();

    public void ThirdFloorSwitchboard(Inventory inventory, Hero cat, Location thirdFloor,
        LockedLocations studyF3D2, LockedLocations bedroomF3D3, LockedLocations closetF3D4)
    {
        Console.Clear();
        cat.Location = Hero.Place.ThirdFloor;
        cat.EndGame = false;
        UIInventory uiInventory = new UIInventory();

        thirdFloor.PrintIntro();
        LockedDoorTree lockedDoorTree = new LockedDoorTree();

        do
        {
            int whereToExplore = thirdFloor.RoomMethod();
            Console.Clear();
            switch (whereToExplore) //this is a call on the BaseLocation class
            {
                // this was stolen from the main room, change it all!!!
                case 0: // return to main room
                    cat.Location = Hero.Place.MainRoom;
                    return; //check that this works. It should fall out of this class completely back to the previous tree
                    break;
                case 1: //study
                    if (!studyF3D2.DoorIsOpen())
                        lockedDoorTree.DoorsSwitchboard(inventory, cat, studyF3D2);
                    if (studyF3D2.DoorIsOpen())
                        studyF3D2.LocationMethod(inventory);
                    break;
                case 2: //bedroom
                    bedroomF3D3.LocationMethod(inventory);
                    break;
                case 3: //closet
                    if (!closetF3D4.DoorIsOpen())
                        lockedDoorTree.DoorsSwitchboard(inventory, cat, closetF3D4);
                    if (closetF3D4.DoorIsOpen())
                        closetF3D4.LocationMethod(inventory);
                    break;
                case 4: //go downstairs
                    Screen.Print(Text.HeadDownStairs);
                    cat.Location = Hero.Place.SecondFloor;
                    break;
                case 5: //inventory
                    uiInventory.RemoveItemFromInventory(cat, inventory);
                    break;
            }
        } while (cat.Location == Hero.Place.ThirdFloor);
    }
}

