using CatsAndCastles1.Text;
using CatsAndCastles1.Text.Inventory;

namespace CatsAndCastles1.Lists;

public class ListLockPickingTools
{
    public static List<string> AllPossibleOptions = new List<string>()
    {
        TextInventoryItems.LockPickSet,
        TextInventoryItems.BatteredShield,
        TextInventoryItems.RingOfKeys,
        TextInventoryItems.CrudeShield,
        TextInventoryItems.Shield,
        TextInventoryItems.LargeStone,

    };

    public static List<string> UnHelpfulKeys = new List<string>()
    {
        TextInventoryItems.RingOfKeys,
    };

    public static List<string> UnHelpfulLockPick = new List<string>()
    {
        TextInventoryItems.LockPickSet,
    };
    
    public static List<string> UnHelpfulPickAndKeys = new List<string>()
    {
        TextInventoryItems.LockPickSet,
        TextInventoryItems.RingOfKeys,
    };

    public static List<string> WindowNeedsRope = new List<string>()
    {
        TextInventoryItems.Rope
    };

    public static List<string> UnHelpfulNothing = new List<string>()
    {

    };






}