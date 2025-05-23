using CatsAndCastles1.Characters;
using CatsAndCastles1.DisplayingText;
using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GuardInteractions;

public static class GuardBribe
{
    public static void AttemptBribe(Hero cat, BadGuy badGuy, Inventory inventory)
    {
        Console.Clear();
        var rnd = new Random();
        Screen.Print(TextBribe.BribeIntro);

        if (ZeroCoinsInPurse(inventory))
        {
            Screen.Print(TextBribe.NoCoins);
            HandleBribeFailure(badGuy);
            return;
        }

        Screen.Print(TextBribe.SuggestBribe);
        int roll = GuardSpecificRollForBribable(badGuy);

        if (!BribeIsAccepted(badGuy, roll))
        {
            Screen.Print(TextBribe.GuardInsultedByBribeAttempt);
            HandleBribeFailure(badGuy);
            return;
        }

        var bribeAmount = BribeAmount(rnd, badGuy);
        var playerGoldCoins = inventory.CheckPurseInventory();

        if (playerGoldCoins < bribeAmount)
        {
            Screen.Print(string.Format(TextBribe.NotEnoughGoldToPayBribe, inventory.CheckPurseInventory()));
            HandleBribeFailure(badGuy);
            return;
        }


        Screen.Print(string.Format(TextBribe.CheckCoinPurse, inventory.CheckPurseInventory()));
        int choice = UserInteractiveMenu.GiveChoices(new List<string> { "yes"}, "no");
        Console.Clear();

        if (choice == 0) //if you choose to pay the bribe
        {
            Screen.Print(TextBribe.PayTheGuardBribe);
            badGuy.Bribe = BadGuy.Outcome.Success;
            inventory.SpendGold(bribeAmount);
            UserInput.DramaticPauseClrScreen();
        }
        else // if you choose not to pay the bribe
        {
            Screen.Print(TextBribe.RefuseToPayBribe);
            HandleBribeFailure(badGuy);
        }
    }

    static bool ZeroCoinsInPurse(Inventory inventory)
    {
        if (inventory.CheckPurseInventory() == 0)
            return true;
        return false;
    }

    static bool BribeIsAccepted(BadGuy badGuy, int roll)
    {
        return ((badGuy.Type == BadGuy.GuardType.Warden && roll > 17) || //if the guard is open to being bribed:
                (badGuy.Type != BadGuy.GuardType.Warden && roll > 5));
    }

    static void HandleBribeFailure(BadGuy badGuy)
    {
        badGuy.Bribe = BadGuy.Outcome.Failure;
        UserInput.DramaticPauseClrScreen();
    }

    static int GuardSpecificRollForBribable(BadGuy badGuy)
    {
        if (badGuy.Type == BadGuy.GuardType.Warden) Screen.Print(TextBribe.WardenRollsForBribable);
        else Screen.Print(TextBribe.GuardRollsForBribable);
        UserInput.DramaticPause();
        int roll = Screen.DiceRoller(20);
        Screen.Print(TextBribe.GuardRoll + roll.ToString());
        return roll;
    }

    static int BribeAmount(Random rnd, BadGuy badGuy)
    {
        var bribe = badGuy.Type == BadGuy.GuardType.Warden ? rnd.Next(50, 60) : rnd.Next(20, 35);
        Screen.Print(string.Format(TextBribe.GuardSuggestsBribeAmount, bribe.ToString()));
        return bribe;
    }
}