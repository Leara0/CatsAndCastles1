using CatsAndCastles1.Characters;
using CatsAndCastles1.GuardInteractions;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;

public static class SwitchTreeGuardEncounter
{
    public static void  GuardEncounterSwitchboard(Hero cat, BadGuy badGuy, Inventory inventory)
    {
        if (badGuy.Health == 0 || badGuy.SuccessfullyBribed)
            return;
        Console.Clear();
        cat.LostToGuard = false; //TODO do I still need this?
       
        Screen.Print(badGuy.SpecificWording[0]);
        UserInput.DramaticPauseClrScreen();
        do
        {
            Screen.Print(badGuy.SpecificWording[1]);
            int choice = UIGuard.GetActionChoice(inventory);
            switch (choice)
            {
                case 0: //fight choice
                    GuardCombat.EngageInCombat(cat, badGuy, inventory);
                    break;
                case 1: //bribe
                    GuardBribe.AttemptBribe(cat, badGuy, inventory);
                    if (badGuy.AttemptedBribeFailed) GuardCombat.EngageInCombat(cat, badGuy, inventory);
                    break;
                case 2: // flee
                    GuardFlee.AttemptFlee(cat, badGuy);
                    if (badGuy.CaughtCat) GuardCombat.EngageInCombat(cat, badGuy, inventory);
                    else cat.Location = Hero.Place.SecondFloor; //if the cat successfully escapes from guard 1 or warden
                    //it will be running to the second floor and the second floor guard is in a room so in all cases
                    //the guard will end up on the second floor
                    return;
            }
        } while (badGuy.Health >0 && !badGuy.SuccessfullyBribed);
    }
}