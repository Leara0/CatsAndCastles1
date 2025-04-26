using CatsAndCastles1.Characters;
using CatsAndCastles1.ClassInstantiation;
using CatsAndCastles1.Lists;
using CatsAndCastles1.OldPartsOfTheGame;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.Text.Inventory;
using CatsAndCastles1.Text.Locations;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;

public static class SwitchTreeThirdFloor
{
    public static void ThirdFloorSwitchboard(Inventory inventory, Hero cat, BadGuy guard1, InstancesThirdFloor instancesTF)
    {
        Console.Clear();
        cat.EndGame = false;//@TODO why do I need this??
        
        UIInventory uiInventory = new UIInventory();
        
        instancesTF.ThirdFloor.PrintIntro();

        if (guard1.Health != 0)
        {
            SwitchTreeGuardEncounter.GuardEncounterSwitchboard(cat, guard1, inventory);
            if(guard1.Health ==0) instancesTF.ThirdFloor.OptionsAtLocation.Insert(4, TextGuard.GuardsDeadBody);
            if (cat.Location == Hero.Place.SecondFloor) return;
        }
        
        do
        {
            int choice = instancesTF.ThirdFloor.RoomMethod();
            var whereToExplore = ListOptionsAtLocations.ThirdFloorChoices[choice];
            Console.Clear();
            switch (whereToExplore) //this is a call on the BaseLocation class
            {
                case TextThirdFloor.ReturnToMainRoomOption:
                    cat.Location = Hero.Place.MainRoom;
                    return; 
                case TextThirdFloor.ThirdFloorDoor2Option: //study
                    if (!instancesTF.StudyF3D2.DoorIsOpen())
                        SwitchTreeLockedDoor.DoorsSwitchboard(inventory, cat, instancesTF.StudyF3D2);
                    if (instancesTF.StudyF3D2.DoorIsOpen())
                        instancesTF.StudyF3D2.LocationMethod(inventory);
                    break;
                case TextThirdFloor.ThirdFloorDoor3Option: //bedroom
                    instancesTF.BedroomF3D3.LocationMethod(inventory);
                    break;
                case  TextThirdFloor.ThirdFloorDoor4Option: //closet
                    if (!instancesTF.ClosetF3D4.DoorIsOpen())
                        SwitchTreeLockedDoor.DoorsSwitchboard(inventory, cat, instancesTF.ClosetF3D4);
                    if (instancesTF.ClosetF3D4.DoorIsOpen())
                        instancesTF.ClosetF3D4.LocationMethod(inventory);
                    break;
                case TextThirdFloor.HeadDownStairsOption: //go downstairs
                    Screen.Print(TextGeneral.HeadDownStairs);
                    cat.Location = Hero.Place.SecondFloor;
                    break;
                case TextWorkInventory.PackOption: //inventory
                    uiInventory.RemoveItemFromInventory(cat, inventory);
                    break;
            }
        } while (cat.Location == Hero.Place.ThirdFloor);
        
        guard1.Flee = BadGuy.Outcome.Default;
        guard1.Bribe = BadGuy.Outcome.Default;
    }
}