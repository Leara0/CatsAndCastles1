using CatsAndCastles1.Text.Inventory;

namespace CatsAndCastles1.Lists;

public static class ListLockPickingTools
{
    public static readonly List<string> AllPossibleOptions = 
    [
        TextInventoryItems.LockPickSet,
        TextInventoryItems.BatteredShield,
        TextInventoryItems.RingOfKeys,
        TextInventoryItems.CrudeShield,
        TextInventoryItems.Shield,
        TextInventoryItems.LargeStone,

    ];

    public static readonly List<string> UnHelpfulKeys = 
    [
        TextInventoryItems.RingOfKeys,
    ];

    public static readonly List<string> UnHelpfulLockPick = 
    [
        TextInventoryItems.LockPickSet,
    ];
    
    public static readonly List<string> UnHelpfulPickAndKeys = 
    [
        TextInventoryItems.LockPickSet,
        TextInventoryItems.RingOfKeys,
    ];

    public static readonly List<string> WindowNeedsRope = 
    [
        TextInventoryItems.Rope
    ];

    public static readonly List<string> UnHelpfulNothing = new List<string>();







}