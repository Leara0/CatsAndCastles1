using CatsAndCastles1.Characters;
using CatsAndCastles1.ClassInstantiation;
using CatsAndCastles1.Lists;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.Text.Inventory;
using CatsAndCastles1.Text.Locations;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;

public static class SwitchTree3F
{
    public static void ThirdFloorSwitchboard(Inventory inventory, Hero cat, BadGuy guard1, Instances3F instances3F)
    {
        Console.Clear();
        UIInventory uiInventory = new UIInventory();
        instances3F.ThirdFloor.PrintIntro();

        if (guard1.Health != 0)
        {
            SwitchTreeGuard.GuardEncounterSwitchboard(cat, guard1, inventory);
            if (guard1.Health == 0)
            {
                instances3F.ThirdFloor.OptionsAtLocation.Insert(4, TextGuard.GuardsDeadBody);
                instances3F.Guard1Corpse.VisitLocation(inventory);
            }
            if (cat.Location == Hero.Place.SecondFloor || cat.Health == 0) return;
        }
        
        do
        {
            int choice = instances3F.ThirdFloor.DecideWhereToExplore();
            // My interactive menu functions with a list and an extra item added on (it helps in some situations)
            // thus the pack option is not in the list so it needs to be addressed separately
            var whereToExplore = "";
            if (choice == ListOptionsAtLocations.ThirdFloorChoices.Count)
                whereToExplore = TextWorkInventory.PackOption;
            else
                whereToExplore = ListOptionsAtLocations.ThirdFloorChoices[choice];
            Console.Clear();
            switch (whereToExplore) //this is a call on the Base Location class
            {
                case Text3F.ReturnToMainRoomOption:
                    cat.Location = Hero.Place.MainRoom;
                    return; 
                case Text3F.StudyF3D2Option: 
                    SwitchHelper.TryToUnlockDoorAndVisitRoom(inventory, cat, instances3F.StudyF3D2);
                    break;
                case Text3F.BedroomF3D3Option: 
                    instances3F.BedroomF3D3.VisitLocation(inventory);
                    break;
                case  Text3F.ClosetF3D4Option: 
                    SwitchHelper.TryToUnlockDoorAndVisitRoom(inventory, cat, instances3F.ClosetF3D4);
                    break;
                case Text3F.HeadDownStairsOption: 
                    SwitchHelper.DoStairs(cat, Hero.Place.SecondFloor, TextGeneral.HeadDownStairs);
                    break;
                case TextWorkInventory.PackOption:
                    uiInventory.RemoveItemFromInventory(cat, inventory);
                    break;
                case TextGuard.GuardsDeadBody:
                    instances3F.Guard1Corpse.VisitLocation(inventory);
                    break;
            }
        } while (cat.Location == Hero.Place.ThirdFloor);
        
        guard1.Flee = BadGuy.Outcome.Default;
        guard1.Bribe = BadGuy.Outcome.Default;
    }
}