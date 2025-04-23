namespace CatsAndCastles1.Lists;

public static class GuardSpecificWording
{
    public static readonly List<string> Guard1Wording =
    [
        "\nA guard stands watch, its back turned, ears twitching slightly but otherwise oblivious " +
        "to your presence. Its armor is slightly dented, its stance relaxed — this guard isn’t " +
        "expecting trouble.\n\nYou realize that investigating the other doors would be risky with the " +
        "guard dog so close. You’ll likely need to deal with it before you can safely explore the hallway. " +
        "The doors might hold supplies or riches — things that could help in your escape, " +
        "but first, you’ll have to decide how to handle the immediate threat." + //@fix clean up this wording
        "\n\nYou have only moments to decide:",


        "With careful steps, you back toward the stairway.",


        "Your paws barely make a sound as you bound down the steps, spiraling deeper " +
        "into the castle. No bark, no pounding footsteps behind you. You weren't seen." +
        "\n\nAs you near the bottom of the steps, the silence is reassuring. " +
        "The guard remains upstairs, unaware of your escape."
    ];

    public static readonly List<string> Guard2Wording =
    [
        "You make your way to door 2 — this one barely ajar. You pause, ears twitching, and " +
        "peer inside. \n\nA guard stands within, unaware of your presence. His posture is relaxed, " +
        "his focus elsewhere. He hasn't noticed you... yet. Beyond him you notice items that might be" +
        "useful in your escape",


        "With careful steps, you back away from the door. ",


        "You place each paw with practiced silence. " +
        "The door remains as you found it — barely open, the guard none the wiser." +
        "\n\nBack in the hall, you take a steadying breath. You’ve avoided a fight, " +
        "but where will you go next? "
    ];

    public static readonly List<string> WardenWording =
    [
        "\nAhead stands a massive dog, larger than any you’ve seen, clad in dark, battered armor . Its fur " +
        "is matted and its ears are torn from past battles." +
        "\n\nThis isn’t some simple guard. This is the Warden. His hulking form blocks your only obvious " +
        "route out. The Warden's eyes don't move as you approach. You know you only have seconds, " +
        "before he’ll notice you.",


        "With careful steps, you back toward the stairway.",


        "You are careful to keep to the shadows. " +
        "The warden remains fixated on the open door, oblivious to your retreat. You begin your ascent back " +
        "up the stairs, each step measured and silent beneath your paws." +
        "\n\nAs you near the landing, you pause and listen. There's no sign that the warden has " +
        "noticed your departure. The silence around you confirms that, for now, you're safe."
    ];
}