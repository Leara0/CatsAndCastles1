using CatsAndCastles1.Characters;
using CatsAndCastles1.ClassInstantiation;
using CatsAndCastles1.DisplayingText;
using CatsAndCastles1.Lists;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.Text.Inventory;
using CatsAndCastles1.Text.Locations;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;

public static class SwitchTree2F
{
    public static void SecondFloorSwitchboard(Inventory inventory, Hero cat, BadGuy guard2,
        Instances2F instances2F)
    {
        Console.Clear();
        UIInventory uiInventory = new UIInventory();
        instances2F.SecondFloor.PrintIntro();
        
        do
        {
            int choice = instances2F.SecondFloor.DecideWhereToExplore();
            var whereToExplore = ListOptionsAtLocations.SecondFloorChoices[choice];
            Console.Clear();
            switch (whereToExplore) //this is a call on the Base Location class
            {
                case Text2F.MeetingRoomF2D1Option:
                    SwitchHelper.TryToUnlockDoorAndVisitRoom(inventory, cat, instances2F.MeetingRoomF2D1);
                    break;
                case Text2F.GuardQuartersF2D2Option: //door is not locked
                    SwitchTreeGuard.GuardEncounterSwitchboard(cat, guard2, inventory);
                    if (cat.Health == 0) return;
                    ChoicesWithDeadGuard(inventory, guard2, instances2F.Guard2Corpse, instances2F.GuardQuartersF2D2);
                    ExploreRoomIfBribed(inventory, guard2, instances2F.GuardQuartersF2D2);
                    break;
                case Text2F.ClosetF2R3Option:
                    SwitchHelper.TryToUnlockDoorAndVisitRoom(inventory, cat, instances2F.ClosetF2R3);
                    break;
                case Text2F.LibraryF2R4Option:
                    SwitchHelper.TryToUnlockDoorAndVisitRoom(inventory, cat, instances2F.LibraryF2R4);
                    break;
                case Text2F.HeadUpStairsOption:
                    SwitchHelper.DoStairs(cat, Hero.Place.ThirdFloor, TextGeneral.HeadUpStairs);
                    break;
                case Text3F.HeadDownStairsOption:
                    SwitchHelper.DoStairs(cat, Hero.Place.FirstFloor, TextGeneral.HeadDownStairs);
                    break;
                case TextWorkInventory.PackOption:
                    uiInventory.RemoveItemFromInventory(cat, inventory);
                    break;
            }
        } while (cat.Location == Hero.Place.SecondFloor);

        guard2.Flee = BadGuy.Outcome.Default;
        guard2.Bribe = BadGuy.Outcome.Default;
    }

    static void ChoicesWithDeadGuard(Inventory inventory, BadGuy badGuy, LocationsItems guardCorpse,
        LocationsItems guardQuarter)
    {
        if (badGuy.Health == 0)
        {
            int bodyChoice;
            do
            {
                Screen.Print(Text2F.EnterRoomAfterKillingGuard);
                bodyChoice = UserInteractiveMenu.GiveChoices(new List<string>
                    { TextGuard.GuardsDeadBody, TextGuard.OrExploreTheRoom }, TextGeneral.LeaveLocation);
                Console.Clear();
                switch (bodyChoice)
                {
                    case 0: //explore corpse
                        guardCorpse.VisitLocation(inventory);
                        break;
                    case 1: // explore room
                        guardQuarter.VisitLocation(inventory);
                        break;
                    case 2: //leave
                        break;
                }

                Console.Clear();
            } while (bodyChoice != 2);
        }
    }

    static void ExploreRoomIfBribed(Inventory inventory, BadGuy badGuy, LocationsLocked location)
    {
        if (badGuy.Bribe == BadGuy.Outcome.Success) //if you fled from the guard you can't explore this room
            location.VisitLocation(inventory);
    }
}