namespace CatsAndCastles1.Text.EndOfGameText;

public static class TextPassOutOrDie
{
    public const string PassingOut =
        "\nThe pain is immediate and blinding. The world tilts, and darkness swallows you whole. " +
        "For a moment, there is nothing—no pain, no sound, no time. " +
        "Then, a cold awareness stirs within you. " +
        "\n\nYou were warned: nine lives... and now, another has slipped away.";


    public const string AllLivesAreLost =
        "Nine lives, and you’ve spent them all. Shadows close in once more — but this time, " +
        "there is no return.";

    public const string LivesLeft = "You’ve already lost {0}. That leaves only {1} more live/s to escape this cursed " +
                                    "castle before the darkness takes you for good.";

    public const string RevealNineLives =
        "\nAs you brace for battle, a forgotten memory stirs — you were gifted nine lives, but most are already gone. " +
        "Only three remain. Lose them all, and your journey ends.";

    public const string OptionsIntro =
        "\nA choice lies before you.\n\nYou could struggle back to consciousness in the room where your journey " +
        "began, battered but alive, " +
        "and try once more to escape this place.\n\n" +
        "Or you could accept defeat, letting the darkness close over you forever.\n\n" +
        "What will you choose?...\n";

    public const string ReviveOption = "revive in the room you first awoke";
    public const string Quit = "accept defeat (end game)";

    public const string Death = "\nAs the darkness takes hold, a strange sense of peace washes over you. " +
                                "The struggle, the fear, the desperate clawing for survival — it all fades into " +
                                "nothingness.\n\nThe castle will remain, its cold stone walls holding secrets " +
                                "you will never uncover. The paths you might have taken, the dangers you might " +
                                "have bested, all slip away like mist in the morning sun." +
                                "\n\nPerhaps you were never meant to escape." +
                                "\n\nAnd so, the little explorer’s journey comes to an end." +
                                "\n\n";
    
    public const string GameOver1 = @"  ____                         ___                 ";
    public const string GameOver2 = @" / ___| __ _ _ __ ___   ___   / _ \__   _____ _ __ ";
    public const string GameOver3 = @"| |  _ / _` | '_ ` _ \ / _ \ | | | \ \ / / _ \ '__|";
    public const string GameOver4 = @"| |_| | (_| | | | | | |  __/ | |_| |\ V /  __/ |   ";
    public const string GameOver5 = @" \____|\__,_|_| |_| |_|\___|  \___/  \_/ \___|_|   ";
}