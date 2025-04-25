using CatsAndCastles1.Characters;
using CatsAndCastles1.ClassInstantiation;
using CatsAndCastles1.Text;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;

public static class SwitchTreeThirdFloor
{
    public static void ThirdFloorSwitchboard(Inventory inventory, Hero cat, BadGuy guard1, InstancesThirdFloor instancesTF)
    {
        Console.Clear();
        cat.Location = Hero.Place.ThirdFloor;
        cat.EndGame = false;
        guard1.SuccessfullyBribed = false;
        cat.SuccessfulFlee = false;
        UIInventory uiInventory = new UIInventory();
        
        instancesTF.ThirdFloor.PrintIntro();
        SwitchTreeLockedDoor switchTreeLockedDoor = new SwitchTreeLockedDoor();
        //GuardEncounterTree.GuardEncounterSwitchboard(cat, guard1, inventory);
        //@TODO not sure if this is the right spot for the guard
        //@TODO add an option to loot the guard's body if the guard is dead
        //maybe a method that creates the list to switch on and if guard is dead then it adds the guard's body
        do
        {
            int whereToExplore = instancesTF.ThirdFloor.RoomMethod();
            Console.Clear();
            switch (whereToExplore) //this is a call on the BaseLocation class
            {
                // this was stolen from the main room, change it all!!!
                case 0: // return to main room
                    cat.Location = Hero.Place.MainRoom;
                    return; //check that this works. It should fall out of this class completely back to the previous tree
                case 1: //study
                    if (!instancesTF.StudyF3D2.DoorIsOpen())
                        switchTreeLockedDoor.DoorsSwitchboard(inventory, cat, instancesTF.StudyF3D2);
                    if (instancesTF.StudyF3D2.DoorIsOpen())
                        instancesTF.StudyF3D2.LocationMethod(inventory);
                    break;
                case 2: //bedroom
                    instancesTF.BedroomF3D3.LocationMethod(inventory);
                    break;
                case 3: //closet
                    if (!instancesTF.ClosetF3D4.DoorIsOpen())
                        switchTreeLockedDoor.DoorsSwitchboard(inventory, cat, instancesTF.ClosetF3D4);
                    if (instancesTF.ClosetF3D4.DoorIsOpen())
                        instancesTF.ClosetF3D4.LocationMethod(inventory);
                    break;
                case 4: //go downstairs
                    Screen.Print(TextGeneral.HeadDownStairs);
                    cat.Location = Hero.Place.SecondFloor;
                    break;
                case 5: //inventory
                    uiInventory.RemoveItemFromInventory(cat, inventory);
                    break;
            }
        } while (cat.Location == Hero.Place.ThirdFloor);
    }
}