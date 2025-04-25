using CatsAndCastles1.Characters;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GuardInteractions;

public static class GuardFlee
{
    public static void AttemptFlee(Hero cat, BadGuy badGuy)
    {
        Console.Clear();
        Screen.Print(badGuy.SpecificWording[2]); //turn to run away
        int roll = GuardSpecificRollForBribable(badGuy);
        if (!RollSuccessfulForFlee(roll, badGuy))
        {
            Screen.Print(TextFlee.GuardNoticesFleeAttempt);
            badGuy.CaughtCat = true;
            UserInput.DramaticPauseClrScreen();
            return;
        }

        Screen.Print(badGuy.SpecificWording[3]);
        UserInput.DramaticPauseClrScreen();
        cat.SuccessfulFlee = true;
        
    }

    static int GuardSpecificRollForBribable(BadGuy badGuy)
    {
        if (badGuy.Type == BadGuy.GuardType.Warden) Screen.Print(TextFlee.NecessaryRollToSneakAwayFromWarden);
        else Screen.Print(TextFlee.NecessaryRollToSneakAwayFromGuard);
        UserInput.DramaticPause();
        int roll = Screen.DiceRoller(20);
        Screen.Print(TextBribe.GuardRoll + roll.ToString());
        return roll;
    }

    static bool RollSuccessfulForFlee(int roll, BadGuy badGuy)
    {
        return (badGuy.Type == BadGuy.GuardType.Warden && roll > 10) ||
               (badGuy.Type == BadGuy.GuardType.Guard && roll > 5);
    }
}