namespace CatsAndCastles1.Lists;

public class WeaponsInfoList
{
    public static string[,] HeroWeaponsAndDamage =
    {
        {
            Text.BroomAndDustPan,
            Text.Manacles,
            Text.Dagger,
            Text.CatFigurine,
            Text.FirePoker,
            Text.LargeStone,
            Text.LongDagger,
            Text.DogStatue,
            Text.ShortSword,
            Text.RustedLantern,
            Text.DustyBook,
            Text.CandleStub,
            Text.Paws
        },
        {
            TextWeapons.BroomAndDustPanMod,
            TextWeapons.ManaclesMod,
            TextWeapons.DaggerMod,
            TextWeapons.CatFigurineMod,
            TextWeapons.FirePokerMod,
            TextWeapons.LargeStoneMod,
            TextWeapons.LongDaggerMod,
            TextWeapons.DogStatueMod,
            TextWeapons.ShortSwordMod,
            TextWeapons.RustedLanternMod,
            TextWeapons.DustyBookMod,
            TextWeapons.CandleStubMod,
            TextWeapons.PawsMod
        }
    };

    public List<int> DieForHeroWeapon = [4, 6, 8, 4, 6, 6, 8, 4, 10, 4, 4, 4, 4];
    public List<int> ModForHeroWeapon = [1, 1, 2, 1, 2, 1, 3, 1, 2, 1, 1, 0, 0];

    public static List<string> BadGuyWeapons =
    [
        Text.Manacles,
        Text.Dagger,
        Text.Dagger,
        Text.Dagger,
        Text.LongDagger,
        Text.GuardPaws
    ];

    public static List<int>  DieForBGWeapon = [6, 8, 8, 8, 8, 4];
    public static List<int> ModForBGWeapon = [1, 2, 2, 2, 3, 0];

    public static List<string> ShieldOptions =
    [
        Text.BatteredShield,
        Text.CrudeShield,
        Text.Shield,
    ];

    public (List<string> WeaponList, List<int> PositionInList) CreateWeaponsOptionList(List<string> inventoryPack)
    {
        List<string> weaponsInPack = new List<string>();
        var positionInList = new List<int>();
        for (int i = 0; i < inventoryPack.Count; i++)
        {
            for (int j = 0; j < HeroWeaponsAndDamage.GetLength(1); j++)
            {
                if (HeroWeaponsAndDamage[0, j] == inventoryPack[i])
                {
                    weaponsInPack.Add(inventoryPack[i] + "- damage: " + HeroWeaponsAndDamage[1, j]);
                    positionInList.Add(j);
                }
            }
        }

        return (weaponsInPack, positionInList);
    }
}