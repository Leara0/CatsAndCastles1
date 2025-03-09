namespace CatsAndCastles1;

public class ListsForLockedPlaces
{
    public List<string> AllPossibleOptions = new List<string>()
    {
        TextItemDescription.LockPickSet,
        TextItemDescription.BatteredShield,
        TextItemDescription.RingOfKeys,
        TextItemDescription.CrudeShield,
        TextItemDescription.Shield,
        TextItemDescription.LargeStone,

    };

    public List<string> UnHelpfulKeys = new List<string>()
    {
        TextItemDescription.RingOfKeys,
    };

    public List<string> UnHelpfulLockPick = new List<string>()
    {
        TextItemDescription.LockPickSet,
    };
    
    public List<string> UnHelpfulPickAndKeys = new List<string>()
    {
        TextItemDescription.LockPickSet,
        TextItemDescription.RingOfKeys,
    };
    
    




}