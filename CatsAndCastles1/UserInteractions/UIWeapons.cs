using CatsAndCastles1.Characters;
using CatsAndCastles1.Lists;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GuardInteractions;

public class UIWeapons
{
    public static void GetHeroWeaponChoice(Hero cat, List<string> inventoryPack) //pass in inventory.Pack
    {
        var weaponModList = new WeaponsInfoList();

        Screen.Print(TextWeapons.CheckInventory);

        if (inventoryPack.Count == 0) //if inventory is empty
        {
            Screen.Print(TextWeapons.FightWithPaws);
            cat.Weapon = Text.Paws;
            cat.WeaponDie = 4;
            cat.WeaponMod = 0;
        }
        else
        {
            Screen.Print(TextWeapons.ChooseYourWeapon);
            //create a list for the weapon version of the pack
            var (weaponOptionsList, weaponsIndex) = weaponModList.CreateWeaponsOptionList(inventoryPack);

            //call the interactive menu to get the user's weapon choice
            var choice = UserInteractiveMenu.GiveChoices(weaponOptionsList);

            //assign the weapon to the cat (assign the weapon die and weapon mod to the cat)
            cat.WeaponDie = weaponModList.DieForHeroWeapon[weaponsIndex[choice]];
            cat.WeaponMod = weaponModList.ModForHeroWeapon[weaponsIndex[choice]];
            cat.Weapon = WeaponsInfoList.HeroWeaponsAndDamage[0, weaponsIndex[choice]];
            Screen.Print(TextWeapons.ChosenWeapon + WeaponsInfoList.HeroWeaponsAndDamage[0, weaponsIndex[choice]]);
            UserInput.DramaticPauseClrScreen();
        }
    }

    public static void GetShieldChoice(Hero cat, List<string> inventoryPack)
    {
        if (inventoryPack.Any(item => WeaponsInfoList.ShieldOptions.Contains(item)))
        {
            Screen.Print(TextWeapons.ChooseShield);
            var choice = UserInteractiveMenu.GiveChoices(new List<string> { "yes", "no" });
            if (choice == 0) cat.HasShield = true;
            else cat.HasShield = false;
        }
    }
}