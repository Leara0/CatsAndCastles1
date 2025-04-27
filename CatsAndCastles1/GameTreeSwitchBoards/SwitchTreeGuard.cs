using CatsAndCastles1.Characters;
using CatsAndCastles1.GuardInteractions;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;

public static class SwitchTreeGuard
{
    public static void GuardEncounterSwitchboard(Hero cat, BadGuy badGuy, Inventory inventory)
    {
        if (badGuy.Health == 0 || badGuy.Bribe == BadGuy.Outcome.Success)
            return;
        Console.Clear();
        cat.LostToGuard = false; //TODO do I still need this?

        Screen.Print(badGuy.SpecificWording[0]);
        UserInput.DramaticPauseClrScreen();

        Screen.Print(badGuy.SpecificWording[1]);
        int choice = UIGuard.GetActionChoice(inventory);

        switch (choice)
        {
            case 0: //fight choice
                GuardCombat.EngageInCombat(cat, badGuy, inventory);
                break;
            case 1: //bribe
                GuardBribe.AttemptBribe(cat, badGuy, inventory);
                if (badGuy.Bribe == BadGuy.Outcome.Failure) GuardCombat.EngageInCombat(cat, badGuy, inventory);
                break;
            case 2: // flee
                GuardFlee.AttemptFlee(cat, badGuy);
                if (badGuy.Flee == BadGuy.Outcome.Failure) GuardCombat.EngageInCombat(cat, badGuy, inventory);
                if (badGuy.Flee == BadGuy.Outcome.Success)
                {
                    cat.Location = Hero.Place.SecondFloor; 
                }

                break;
        }
    }
}