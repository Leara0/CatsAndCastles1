using CatsAndCastles1.Characters;
using CatsAndCastles1.ClassInstantiation;
using CatsAndCastles1.Lists;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.Text.Locations;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;


public class SwitchTree1F
{
    
    public static void FirstFloorSwitchBoard(Inventory inventory, Hero cat, BadGuy warden, Instances1F instances1F)
    {
        cat.EndGame = false; 

        if (cat.ReturningTo1F) Screen.Print(Text1F.ReturnTo1F);
        else if (warden.Health != 0) Screen.Print(Text1F.Reach1FWardenIsAlive);
        cat.ReturningTo1F = true; //set this after you test for it for future visits
        UserInput.DramaticPauseClrScreen();

        if (warden.Health != 0) 
        {
            SwitchTreeGuard.GuardEncounterSwitchboard(cat, warden, inventory);
            if (warden.Health == 0)
            {
                instances1F.FirstFloor.OptionsAtLocation.Insert(2, TextGuard.GuardsDeadBody);
                instances1F.WardenCorpse.VisitLocation(inventory);
            }
            if (cat.Location == Hero.Place.SecondFloor) return;
        }

        instances1F.FirstFloor.PrintIntro();

        do
        {
            int choice = instances1F.FirstFloor.DecideWhereToExplore();
            var whereToExplore = ListOptionsAtLocations.FirstFloorChoices[choice];
            Console.Clear();
            switch (whereToExplore)
            {
                case Text1F.HeadTowardsOutsideDoorOption:
                    Screen.Print(Text1F.HeadTowardOutsideDoor);
                    cat.Location = Hero.Place.OutsideCastle;
                    break;
                case Text1F.ExploreTheRoomOption:
                    instances1F.Room1F.VisitLocation(inventory);
                    break;
                case TextGuard.GuardsDeadBody:
                    instances1F.WardenCorpse.VisitLocation(inventory);
                    break;
                case Text2F.HeadUpStairsOption://@TODO fix this!!
                    SwitchHelpMethod.DoStairs(cat, Hero.Place.SecondFloor, TextGeneral.HeadUpStairs);
                    break;
            }
        } while (cat.Location == Hero.Place.FirstFloor);


        warden.Flee = BadGuy.Outcome.Default;
        warden.Bribe = BadGuy.Outcome.Default;
    }
}