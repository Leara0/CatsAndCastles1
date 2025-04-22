namespace CatsAndCastles1.Lists;

public class WeaponModsList
{
    public static string[,] WeaponsAndDamage =
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
            WeaponText.BroomAndDustPanMod,
            WeaponText.ManaclesMod,
            WeaponText.DaggerMod,
            WeaponText.CatFigurineMod,
            WeaponText.FirePokerMod,
            WeaponText.LargeStoneMod,
            WeaponText.LongDaggerMod,
            WeaponText.DogStatueMod,
            WeaponText.ShortSwordMod,
            WeaponText.RustedLanternMod,
            WeaponText.DustyBookMod,
            WeaponText.CandleStubMod,
            WeaponText.PawsMod
        }
    };

    public  List<int> DieForWeapon = [4, 6, 8, 4, 6, 6, 8, 4, 10, 4, 4, 4, 4];
    public  List<int> ModForWeapon = [1, 1, 2, 1, 2, 1, 3, 1, 2, 1, 1, 0, 0];
    
    public List<string> CreateWeaponsOptionList(Inventory inventory)
    {
        List<string> weaponsInPack = new List<string>();
        for (int i = 0; i < inventory.Pack.Count; i++)
        {
            for (int j = 0; j < WeaponsAndDamage.GetLength(1); j++)
            {
                if (WeaponsAndDamage[0, j] == inventory.Pack[i])
                {
                    weaponsInPack.Add(inventory.Pack[i] + "- damage: " + WeaponsAndDamage[1, j]);
                }
            }
        }
        return weaponsInPack;
    }
}