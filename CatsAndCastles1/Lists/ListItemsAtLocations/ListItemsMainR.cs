using CatsAndCastles1.Text.Inventory;

namespace CatsAndCastles1.Lists.ListItemsAtLocations;

public static class ListItemsMainR
{
    public static readonly List<string> ClosetDescription =
    [
        TextInventoryItems.TwoSheetsDesc,
        TextInventoryItems.BroomAndDustPanDesc,
        TextInventoryItems.ManaclesDesc,
    ];

    public static readonly List<string> ClosetItems =
    [
        TextInventoryItems.TwoSheets,
        TextInventoryItems.BroomAndDustPan,
        TextInventoryItems.Manacles,
    ];

    public static readonly List<string> NightStandDescription =
    [
        TextInventoryItems.TenCoinsDesc,
        TextInventoryItems.GlassesDesc,
        TextInventoryItems.BookOfPrayersDesc
    ];

    public static readonly List<string> NightStandItems =
    [
        TextInventoryItems.TenCoins,
        TextInventoryItems.Glasses,
        TextInventoryItems.BookOfPrayers
    ];

    public static readonly List<string> BookshelfDescription =
    [
        TextInventoryItems.DaggerDesc,
        TextInventoryItems.LockPickSetDesc,
        TextInventoryItems.CatFigurineDesc
    ];

    public static readonly List<string> BookshelfItems =
    [
        TextInventoryItems.Dagger,
        TextInventoryItems.LockPickSet,
        TextInventoryItems.CatFigurine
    ];

    public static readonly List<string> HearthDescription =
    [
        TextInventoryItems.FirePokerDesc,
        TextInventoryItems.LargeStoneDesc,
        TextInventoryItems.BatteredShieldDesc
    ];

    public static readonly List<string> HearthItems =
    [
        TextInventoryItems.FirePoker,
        TextInventoryItems.LargeStone,
        TextInventoryItems.BatteredShield
    ];

}