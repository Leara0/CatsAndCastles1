using CatsAndCastles1.Characters;
using CatsAndCastles1.GuardInteractions;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;

public class GuardEncounterTree
{
    public static void  GuardEncounterSwitchboard(Hero cat, BadGuy guard, Inventory inventory)
    {
        Console.Clear();
        var rnd = new Random();
        cat.LostToGuard = false; //do I still need this?
        var combat = new Combat();


        Screen.Print(guard.SpecificWording[0]);
        UserInput.DramaticPauseClrScreen();
        do
        {
            Screen.Print(guard.SpecificWording[1]);
            int choice = UIGuard.GetActionChoice(inventory);
            switch (choice)
            {
                case 0: //fight choice
                    combat.EngageInCombat(cat, guard, inventory);
                    break;
                case 1: //bribe
                    break;
                case 2: // flee
                    break;
            }
        } while (guard.Health != 0 && !cat.SuccessfulBribed);
    }

    /*notice guard wording
     do{
    switch(actionChoice)
    fight:
    go to fight generator
    bribe
    go to bribe generator
    run away
    go to run away generator
    }while (guard not dead and not bribed and not successful runaway



    */
}