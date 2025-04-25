namespace CatsAndCastles1.Text.GuardEncounter;

public class TextBribe
{
    public const string BribeIntro =
        "The dog's ears flick, and then it turns. Eyes lock onto yours — wide at first, then narrowing. " +
        "For a heartbeat, the two of you simply stare.";

    public const string NoCoins = "You consider attempting to bribe the guard but then remember you have no coins. " +
                                  "You prepare to engage in combat with the guard dog\n";

    public const string SuggestBribe =
        "\nYou clear your throat just enough to get its attention. The dog’s ears perk up, and it " +
        "spins around, baring its teeth in surprise. For a moment, it just stares at you, " +
        "blinking, as if trying to process why you are standing here instead of locked away." +
        "\n\nBefore it can react, you flick your tail and speak. \"Let’s not make this difficult. " +
        "What if we just pretend you never saw me?\"";

    public const string GuardRollsForBribable =
        "The guard will roll a D20 to determine their willingness to accept a bribe. If the result is " +
        "greater than 5, the guard is open to negotiation.";

    public const string WardenRollsForBribable =
        "The guard will roll a D20 to determine their willingness to accept a bribe. If the result is " +
        "greater than 17, the guard is open to negotiation.";

    public const string GuardRoll = "The guard rolls a ";

    public const string GuardSuggestsBribeAmount1 =
        "\n\nThe dog narrows its eyes, sniffing the air as it considers your words. Then, with a " +
        "slow smirk, it tilts its head. \"Hah. That depends. Let's say my memory’s not great... " +
        "for ";

    public const string GuardSuggestsBribeAmount2 = " gold coins I might be able to forget " +
                                                    "you're presence entirely\".";

    public const string CheckCoinPurse1 =
        "\nYou glance down at your pack, pawing through its contents. The familiar weight of " +
        "gold presses against your claws — ";

    public const string CheckCoinPurse2 =
        " coins. You have what the dog is asking for.\n\nDo you want to pay the bribe?.";

    public const string PayTheGuardBribe = "\nWithout hesitation, you drop the gold coins into the waiting paw." +
                                           "\n\nIt eyes the payment, then smirks. \"Pleasure doing business with you.\"" +
                                           "\n\nThe coins vanish into its pouch, and the guard steps aside. \"Go on, then. " +
                                           "You are invisible to me until you leave this floor.\"";

    public const string RefuseToPayBribe =
        "You weigh your options, eyeing the guard warily. Bribery could have worked—if the price wasn’t so outrageous. " +
        "You shake your head and back away, claws flexing. The guard growls, insulted by your refusal.\n\nThere’s no " +
        "more talking. It’s time to fight.";

    public const string NotEnoughGoldToPayBribe =
        "\nYou glance down at your pack, pawing through its contents. Your claws scrape against the coins at the bottom, " +
        "but as you count them, your stomach sinks. You don't have enough. You look up, meeting its gaze. " +
        "It already knows. \n\nThe guard steps forward, teeth bared, hackles raised. \"Guess we’re doing this " +
        "the hard way.\" \n\nYou have no choice now — you must fight.";

    public static string GuardInsultedByBribeAttempt =
        "The dog’s jaw drops. Then, with a sudden growl, it bares its teeth. \n\n\"You think I can be bought?\" it " +
        "snaps, stepping forward, claws scraping against the stone floor. \"That’s insulting! I have a duty, and I " +
        "take it seriously!\" \n\nIt appears this guard cannot be bribed. A fight is coming. ";
}