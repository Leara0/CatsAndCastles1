namespace CatsAndCastles1;

public class TextGuard
{
    public const string NoticeGuard1 =
        "\nA guard stands watch, its back turned, ears twitching slightly but otherwise oblivious " +
        "to your presence. Its armor is slightly dented, its stance relaxed — this guard isn’t " +
        "expecting trouble.\n\nYou realize that investigating the other doors would be risky with the " +
        "guard dog so close. You’ll likely need to deal with it before you can safely explore the hallway. " +
        "The doors might hold supplies or riches — things that could help in your escape, " +
        "but first, you’ll have to decide how to handle the immediate threat.";

    public const string NoticeGuard2 =
        "You make your way to door 2 — this one barely ajar. You pause, ears twitching, and " +
        "peer inside. \n\nA guard stands within, unaware of your presence. His posture is relaxed, " +
        "his focus elsewhere. He hasn't noticed you... yet. Beyond him you notice items that might be" +
        "useful in your escape";

    public const string NoticeWarden =
        "\nAhead stands a massive dog, larger than any you’ve seen, clad in dark, battered armor . Its fur " +
        "is matted and its ears are torn from past battles." +
        "\n\nThis isn’t some simple guard. This is the Warden. His hulking form blocks your only obvious " +
        "route out. The Warden's eyes don't move as you approach. You know you only have seconds, " +
        "before he’ll notice you.";


    public const string BeginRunAwayGuard1AndWarden = "With careful steps, you back toward the stairway.";

    public const string BeginRunAwayGuard2 = "With careful steps, you back away from the door. ";

    public const string RunAwayGuard1 = "Your paws barely make a sound as you bound down the steps, spiraling deeper " +
                                        "into the castle. No bark, no pounding footsteps behind you. You weren't seen." +
                                        "\n\nAs you near the bottom of the steps, the silence is reassuring. " +
                                        "The guard remains upstairs, unaware of your escape.";

    public const string RunAwayGuard2 = "You place each paw with practiced silence. " +
                                        "The door remains as you found it — barely open, the guard none the wiser." +
                                        "\n\nBack in the hall, you take a steadying breath. You’ve avoided a fight, " +
                                        "but where will you go next? ";


    public const string RunAwayWarden = "You are careful to keep to the shadows. " +
                                        "The warden remains fixated on the open door, oblivious to your retreat. You begin your ascent back " +
                                        "up the stairs, each step measured and silent beneath your paws." +
                                        "\n\nAs you near the landing, you pause and listen. There's no sign that the warden has " +
                                        "noticed your departure. The silence around you confirms that, for now, you're safe.";

    public const string CombatOption = "attack the guard";
    public const string RunawayOption = "attempt to runaway from the guard";
    public const string BribeOption = "attempt to bribe from the guard - your coin purse contains: ";
    public const string GoldCoins = " gold coins";

    public const string SetUpOptionsWarden =
        "You have a choice: - Engage the massive warden in combat, risking it all to fight (or bribe) your " +
        "way through to the exit. Or sneak back up the stairs to continue exploring the castle " +
        "for another way to escape. ";

    public const string SetUpOptionsGuards =
        "\nYou must decide: will you confront the guard or make a run for it? If you manage to bribe or defeat " +
        "the guard, you’ll be free to explore this area undisturbed—though beware, if you leave the floor, the " +
        "bribe will be forgotten. If you choose to flee, you’ll keep your health and your gold intact.";

    public const string CombatIntro = "All your choices and luck have lead to this moment - there is no turning back." +
                                      "\n\nThe guard dog snarls, its stance low and ready to strike. It's just you " +
                                      "and the beast, locked in a battle for survival." +
                                      "\n\nThe air is thick with tension. The dog's muscles bunch, its eyes locked onto you. " +
                                      "The fight is about to begin.\n\n";

    public const string GuardsHealthCheck = "Your opponent's health is ";
    public const string HeroHealthCheck = "Your health is ";
    public const string OutOf = " out of ";
    public const string HeroWeaponReminder = "You will be fighting with ";
    public const string GuardWeaponReminder = "Your opponent will be fighting with ";
    public const string WithAShield = " and will be using a shield.";

    public const string GuardAttacksFirst =
        "The guard attacks first, having caught on to your attempt to avoid confrontation.";

    public const string YouAttack = "You attack. You roll a D";
    public const string OpponentAttack = "Your opponent attacks. They roll a D";
    public const string ShieldDeflects = "The shield deflects 1 damage.";
    public const string YouKilledGuard = "\nYou are victorious in the fight against the guard";
    public const string GuardWins = "\nThe guard has been victorious in this fight\n";
}