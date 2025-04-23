using CatsAndCastles1.Characters;
using CatsAndCastles1.Lists;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GuardInteractions;

public class UIWeapons
{
    UserInteractiveMenu userInteractiveMenu = new UserInteractiveMenu();
    public void GetHeroWeaponChoice(Hero cat, List<string> inventoryPack)//pass in inventory.Pack
    {
        var weaponModList = new WeaponsInfoList();
        
        Screen.Print(WeaponText.CheckInventory);
        
        if (inventoryPack.Count == 0) //if inventory is empty
        {
            Screen.Print(WeaponText.FightWithPaws);
            cat.WeaponDie = 4;
            cat.WeaponMod = 0;
        }
        else
        {
            Screen.Print(WeaponText.ChooseYourWeapon);
            //create a list for the weapon version of the pack
            var (weaponOptionsList, weaponsIndex) = weaponModList.CreateWeaponsOptionList(inventoryPack);
            
            //call the interactive menu to get the user's weapon choice
            var choice = userInteractiveMenu.GiveChoices(weaponOptionsList);
            
            //assign the weapon to the cat (assign the weapon die and weapon mod to the cat)
            cat.WeaponDie = weaponModList.DieForHeroWeapon[weaponsIndex[choice]];
            cat.WeaponMod = weaponModList.ModForHeroWeapon[weaponsIndex[choice]];
            cat.Weapon = WeaponsInfoList.HeroWeaponsAndDamage[0, weaponsIndex[choice]];
            Screen.Print(WeaponText.ChosenWeapon + WeaponsInfoList.HeroWeaponsAndDamage[0,weaponsIndex[choice]]);
            UserInput.DramaticPauseClrScreen();
        }
    }

    public void AssignBadGuyWeaponAndShield(BadGuy badGuy)
    {
        var rnd = new Random();
        var pick = rnd.Next(1, 7);
        badGuy.Weapon = WeaponsInfoList.BadGuyWeapons[pick];
        badGuy.WeaponDie = WeaponsInfoList.DieForBGWeapon[pick];
        badGuy.WeaponMod = WeaponsInfoList.ModForBGWeapon[pick];
        Screen.Print(WeaponText.BadGuyWeapon + badGuy.Weapon);
        
        pick = rnd.Next(1, 3);
        if (pick == 1)
        {
            Screen.Print(WeaponText.YesBGShield);
            badGuy.HasShield = true;
        }
        else
        {
            Screen.Print(WeaponText.NoBGShield);
            badGuy.HasShield = false;
        }
    }

    public void GetShieldChoice(Hero cat, List<string> inventoryPack)
    {
        if (inventoryPack.Any(item => WeaponsInfoList.ShieldOptions.Contains(item)))
        {
            Screen.Print(WeaponText.ChooseShield);
            var choice = userInteractiveMenu.GiveChoices(new List<string> { "yes", "no" });
            if (choice == 0)
            {
                Screen.Print(WeaponText.YesShield);
                cat.HasShield = true;
            }
            else
            {
                Screen.Print(WeaponText.NoShield);
                cat.HasShield = false;
            }
        }
    }
}