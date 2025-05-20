using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.Text.Inventory;

namespace CatsAndCastles1.Lists;

public class ListWeaponsInfo
{
    public static readonly string[,] HeroWeaponsAndDamage =
    {
        {
            TextInventoryItems.BroomAndDustPan,
            TextInventoryItems.Manacles,
            TextInventoryItems.Dagger,
            TextInventoryItems.CatFigurine,
            TextInventoryItems.FirePoker,
            TextInventoryItems.LargeStone,
            TextInventoryItems.LongDagger,
            TextInventoryItems.DogStatue,
            TextInventoryItems.ShortSword,
            TextInventoryItems.RustedLantern,
            TextInventoryItems.DustyBook,
            TextInventoryItems.CandleStub,
           },
        {
            TextCombat.BroomAndDustPanMod,
            TextCombat.ManaclesMod,
            TextCombat.DaggerMod,
            TextCombat.CatFigurineMod,
            TextCombat.FirePokerMod,
            TextCombat.LargeStoneMod,
            TextCombat.LongDaggerMod,
            TextCombat.DogStatueMod,
            TextCombat.ShortSwordMod,
            TextCombat.RustedLanternMod,
            TextCombat.DustyBookMod,
            TextCombat.CandleStubMod,
           }
    };

    public readonly List<int> DieForHeroWeapon = [4, 6, 8, 4, 6, 6, 8, 4, 10, 4, 4, 4];
    public readonly List<int> ModForHeroWeapon = [1, 1, 2, 1, 2, 1, 3, 1, 2, 1, 1, 0];

    public static readonly List<string> BadGuyWeapons =
    [
        TextInventoryItems.Manacles,
        TextInventoryItems.Dagger,
        TextInventoryItems.Dagger,
        TextInventoryItems.Dagger,
        TextInventoryItems.LongDagger,
        TextInventoryItems.GuardPaws
    ];

    public static readonly List<int>  DieForBGWeapon = [6, 8, 8, 8, 8, 4];
    public static readonly List<int> ModForBGWeapon = [1, 2, 2, 2, 3, 0];

    public static readonly List<string> ShieldOptions =
    [
        TextInventoryItems.BatteredShield,
        TextInventoryItems.CrudeShield,
        TextInventoryItems.Shield,
    ];

    public (List<string> WeaponList, List<int> PositionInList) CreateWeaponsOptionList(List<string> inventoryPack)
    {
        List<string> weaponsInPack = new List<string>();
        var positionInList = new List<int>();
        foreach (var item in inventoryPack)
        {
            for (int j = 0; j < HeroWeaponsAndDamage.GetLength(1); j++)
            {
                if (HeroWeaponsAndDamage[0, j] == item)
                {
                    weaponsInPack.Add(item + "- damage: " + HeroWeaponsAndDamage[1, j]);
                    positionInList.Add(j);
                }
            }
           
        }
        return (weaponsInPack, positionInList);
    }
}