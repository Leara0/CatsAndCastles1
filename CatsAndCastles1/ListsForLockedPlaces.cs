namespace CatsAndCastles1;

public class ListsForLockedPlaces
{
    public static List<string> AllPossibleOptions = new List<string>()
    {
        TextItemDescription.LockPickSet,
        TextItemDescription.BatteredShield,
        TextItemDescription.RingOfKeys,
        TextItemDescription.CrudeShield,
        TextItemDescription.Shield,
        TextItemDescription.LargeStone,

    };

    public static List<string> UnHelpfulKeys = new List<string>()
    {
        TextItemDescription.RingOfKeys,
    };

    public static List<string> UnHelpfulLockPick = new List<string>()
    {
        TextItemDescription.LockPickSet,
    };
    
    public static List<string> UnHelpfulPickAndKeys = new List<string>()
    {
        TextItemDescription.LockPickSet,
        TextItemDescription.RingOfKeys,
    };

    public static List<string> WindowNeedsRope = new List<string>()
    {
        TextItemDescription.Rope
    };






}