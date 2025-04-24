namespace CatsAndCastles1.Text;

public class TextGeneral
{
    #region Borders

    public const string CatBorder1 =
        "   -   -   -   -   -   -   -   -   =^.^=   -   -   -   -   -   -   -   -   -   -   \n";

    public const string CatBorder2 =
        "\n\n   <   <   <   <   <   <   <   <   =^.^=   >   >   >   >   >   >   >   >   >   \n";

    public const string CatBorder3 =
        "\n   >   >   >   >   >   >   >   >   =^.^=   <   <   <   <   <   <   <   <   <   \n";

    #endregion

    public const string HowToPickAnItem =
        "Please use the \u001b[35mup\u001b[0m and \u001b[35mdown\u001b[0m arrow key to " +
        "navigate and press 'enter' to select.";


    public const string LeaveLocation = "leave this location";
    public const string LeaveLockedDoor = "leave the door alone and explore other areas instead";

    public const string HeadUpStairs = "You turn and head back toward the stairs, making your way up. You feel there" +
                                       "must be something you missed and are eager to retrace your steps.";
    
    public const string HeadDownStairs =
        "You feel you’ve explored enough for now. The stairway at the end of the hall " +
        "beckons, offering the chance to move closer to freedom. " +
        "\n\nWith a soft sigh, you make your way to the stairs, each step taking you " +
        "closer to your goal. This floor fades into the shadows behind you as you " +
        "descend, the stairwell opens up to new, uncertain territory.";
    
    public const string YourRoll = "You rolled: ";
    public const string Damage = "The total damage is ";

    public const string YourHealth = "Your current health is ";
    public const string OutOfTotalHealth = " out of ";

    public const string FinishExploringInHall = "Feeling finished with this room, you step back into the hallway.";
}