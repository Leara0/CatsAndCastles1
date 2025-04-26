using CatsAndCastles1.Characters;
using CatsAndCastles1.ClassInstantiation;
using CatsAndCastles1.Lists;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.Inventory;
using CatsAndCastles1.Text.Locations;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;

public static class SwitchTreeSecondFloor
{
    public static void SecondFloorSwitchboard(Inventory inventory, Hero cat, BadGuy guard2,
        InstancesSecondFloor instancesSF)
    {
        Console.Clear();
        cat.EndGame = false; //@TODO what is this about?
        UIInventory uiInventory = new UIInventory();
        instancesSF.SecondFloor.PrintIntro();
        
        do
        {
            int choice = instancesSF.SecondFloor.RoomMethod();
            var whereToExplore = ListOptionsAtLocations.SecondFloorChoices[choice];
            Console.Clear();
            switch (whereToExplore) //this is a call on the BaseLocation class
            {
                case TextSecondFloor.SecondFloorDoor1Option: // meeting room
                    if (!instancesSF.MeetingRoomF2D1.DoorIsOpen())
                        SwitchTreeLockedDoor.DoorsSwitchboard(inventory, cat, instancesSF.MeetingRoomF2D1);
                    if (instancesSF.MeetingRoomF2D1.DoorIsOpen())
                        instancesSF.MeetingRoomF2D1.LocationMethod(inventory);
                    break;
                case TextSecondFloor.SecondFloorDoor2Option: //guard's quarters (//@TODO put guard to fight in here!)
                    SwitchTreeGuardEncounter.GuardEncounterSwitchboard(cat, guard2, inventory);
                    //door is not locked
                    if (guard2.Flee != BadGuy.Outcome.Success)//if you fled from the guard you can't explore this room
                        instancesSF.GuardQuartersF2D2.LocationMethod(inventory);
                    break;
                case TextSecondFloor.SecondFloorDoor3Option: //closet
                    if (!instancesSF.ClosetF2R3.DoorIsOpen())
                        SwitchTreeLockedDoor.DoorsSwitchboard(inventory, cat, instancesSF.ClosetF2R3);
                    if (instancesSF.ClosetF2R3.DoorIsOpen())
                        instancesSF.ClosetF2R3.LocationMethod(inventory);
                    break;
                case TextSecondFloor.SecondFloorDoor4Option: //library
                    if (!instancesSF.LibraryF2R4.DoorIsOpen())
                        SwitchTreeLockedDoor.DoorsSwitchboard(inventory, cat, instancesSF.LibraryF2R4);
                    if (instancesSF.LibraryF2R4.DoorIsOpen())
                        instancesSF.LibraryF2R4.LocationMethod(inventory);
                    break;
                case TextSecondFloor.HeadUpStairsOption: 
                    Screen.Print(TextGeneral.HeadUpStairs);
                    cat.Location = Hero.Place.ThirdFloor;
                    break;
                case TextThirdFloor.HeadDownStairsOption: //go downstairs
                    Screen.Print(TextGeneral.HeadDownStairs);
                    cat.Location = Hero.Place.FirstFloor;
                    break;
                case TextWorkInventory.PackOption: 
                    uiInventory.RemoveItemFromInventory(cat, inventory);
                    break;
            }
        } while (cat.Location == Hero.Place.SecondFloor);
        
        guard2.Flee = BadGuy.Outcome.Default;
        guard2.Bribe = BadGuy.Outcome.Default;
    }
}