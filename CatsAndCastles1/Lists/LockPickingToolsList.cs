namespace CatsAndCastles1.Lists;

public class LockPickingToolsList
{
    public static List<string> AllPossibleOptions = new List<string>()
    {
        Text.LockPickSet,
        Text.BatteredShield,
        Text.RingOfKeys,
        Text.CrudeShield,
        Text.Shield,
        Text.LargeStone,

    };

    public static List<string> UnHelpfulKeys = new List<string>()
    {
        Text.RingOfKeys,
    };

    public static List<string> UnHelpfulLockPick = new List<string>()
    {
        Text.LockPickSet,
    };
    
    public static List<string> UnHelpfulPickAndKeys = new List<string>()
    {
        Text.LockPickSet,
        Text.RingOfKeys,
    };

    public static List<string> WindowNeedsRope = new List<string>()
    {
        Text.Rope
    };

    public static List<string> UnHelpfulNothing = new List<string>()
    {

    };






}