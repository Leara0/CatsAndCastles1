using CatsAndCastles1.Text;
using CatsAndCastles1.Text.Inventory;

namespace CatsAndCastles1.Lists.ItemsAtLocations;

public class ListItemGuard
{
    public static readonly List<string> Guard1Description =
    [
        TextInventoryItems.RingOfKeysDesc,
        TextInventoryItems.DogWhistleDesc,
        TextInventoryItems.CrudeShieldDesc,
    ];

    public static readonly List<string> Guard1Items =
    [
        TextInventoryItems.RingOfKeys,
        TextInventoryItems.DogWhistle,
        TextInventoryItems.CrudeShield,
    ];

    public static readonly List<string> Guard2Description =
    [
        TextInventoryItems.TenCoinsDesc,
        TextInventoryItems.WorryBeadsDesc,
        TextInventoryItems.BatteredShieldDesc,
        TextInventoryItems.DogWhistleDesc
    ];

    public static readonly List<string> Guard2Items =
    [
        TextInventoryItems.TenCoins,
        TextInventoryItems.WorryBeads,
        TextInventoryItems.BatteredShield,
        TextInventoryItems.DogWhistle,
    ];

    public static readonly List<string> WardenDescription =
    [
        TextInventoryItems.TwentyCoinsDesc,
        TextInventoryItems.LoafOfBreadDesc,
        TextInventoryItems.GlassVialDesc
    ];

    public static readonly List<string> WardenItems =
    [
        TextInventoryItems.TwentyCoins,
        TextInventoryItems.LoafOfBread,
        TextInventoryItems.GlassVial
    ];
}