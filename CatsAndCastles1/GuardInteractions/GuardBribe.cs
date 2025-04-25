using CatsAndCastles1.Characters;
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
            HandleBribeFailure(inventory, cat, badGuy);
            return;
        }

        Screen.Print(TextBribe.SuggestBribe);
        int roll = GuardSpecificRollForBribable(badGuy);

        if (!BribeIsAccepted(badGuy, roll))
        {
            Screen.Print(TextBribe.GuardInsultedByBribeAttempt);
            HandleBribeFailure(inventory, cat, badGuy);
            return;
        }

        var bribeAmount = BribeAmount(rnd, badGuy);
        var playerGoldCoins = inventory.CheckPurseInventory();

        if (playerGoldCoins < bribeAmount)
        {
            Screen.Print(TextBribe.NotEnoughGoldToPayBribe);
            HandleBribeFailure(inventory, cat, badGuy);
            return;
        }


        Screen.Print(TextBribe.CheckCoinPurse1 + inventory.CheckPurseInventory() + TextBribe.CheckCoinPurse2);
        int choice = UserInteractiveMenu.GiveChoices(new List<string> { "yes", "no" });
        Console.Clear();

        if (choice == 0) //if you choose to pay the bribe
        {
            Screen.Print(TextBribe.PayTheGuardBribe);
            badGuy.AttemptedBribeFailed = false;
            badGuy.SuccessfullyBribed = true;
            inventory.SpendGold(bribeAmount);
            UserInput.DramaticPauseClrScreen();
        }
        else // if you choose not to pay the bribe
        {
            Screen.Print(TextBribe.RefuseToPayBribe);
            HandleBribeFailure(inventory, cat, badGuy);
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
                (badGuy.Type == BadGuy.GuardType.Guard && roll > 5));
    }

    static void HandleBribeFailure(Inventory inventory, Hero cat, BadGuy badGuy)
    {
        badGuy.AttemptedBribeFailed = true;
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
        Screen.Print(TextBribe.GuardSuggestsBribeAmount1 + bribe.ToString() + TextBribe.GuardSuggestsBribeAmount2);
        return bribe;
    }
}