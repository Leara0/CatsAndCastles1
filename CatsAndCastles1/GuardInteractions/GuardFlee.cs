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
            badGuy.Flee = BadGuy.Outcome.Failure;
            UserInput.DramaticPauseClrScreen();
            return;
        }

        Screen.Print(badGuy.SpecificWording[3]);
        badGuy.Flee = BadGuy.Outcome.Success;
        UserInput.DramaticPauseClrScreen();
    }

    static int GuardSpecificRollForBribable(BadGuy badGuy)
    {
        Screen.Print(badGuy.Type == BadGuy.GuardType.Warden? TextFlee.NecessaryRollToSneakAwayFromWarden :
            TextFlee.NecessaryRollToSneakAwayFromGuard);
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