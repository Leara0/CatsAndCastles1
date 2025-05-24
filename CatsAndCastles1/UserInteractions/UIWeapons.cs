using CatsAndCastles1.Characters;
using CatsAndCastles1.DisplayingText;
using CatsAndCastles1.Lists;
using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.Text.Inventory;

namespace CatsAndCastles1.UserInteractions;

public class UIWeapons
{
    public static void GetHeroWeaponChoice(Hero cat, List<string> inventoryPack) //pass in inventory.Pack
    {
        var weaponModList = new ListWeaponsInfo();

        Screen.Print(TextCombat.CheckInventory);

        if (inventoryPack.Count == 0) //if inventory is empty
        {
            Screen.Print(TextCombat.FightWithPaws);
            cat.Weapon = TextInventoryItems.Paws;
            cat.WeaponDie = 4;
            cat.WeaponMod = 0;
        }
        else
        {
            Screen.Print(TextCombat.ChooseYourWeapon);
            //create a list for the weapon version of the pack
            var (weaponOptionsList, weaponsIndex) = weaponModList.CreateWeaponsOptionList(inventoryPack);

            //call the interactive menu to get the user's weapon choice
            var choice = UserInteractiveMenu.GiveChoices(weaponOptionsList,
                TextInventoryItems.Paws + "- damage: " + TextCombat.PawsMod);
            

            //assign the weapon to the cat (assign the weapon die and weapon mod to the cat)
            bool chosePaws = choice == weaponOptionsList.Count;

            if (chosePaws)
            {
                cat.Weapon = TextInventoryItems.Paws;
                cat.WeaponDie = 4;
                cat.WeaponMod = 0;
            }
            else
            {
                int selectedIndex = weaponsIndex[choice];
                cat.Weapon = ListWeaponsInfo.HeroWeaponsAndDamage[0, selectedIndex];
                cat.WeaponDie = weaponModList.DieForHeroWeapon[selectedIndex];
                cat.WeaponMod = weaponModList.ModForHeroWeapon[selectedIndex];
            }

            Screen.Print(TextCombat.ChosenWeapon + cat.Weapon +".");
        }

        UserInput.DramaticPauseClrScreen();
    }

    public static void GetShieldChoice(Hero cat, List<string> inventoryPack)
    {
        if (!inventoryPack.Any(item => ListWeaponsInfo.ShieldOptions.Contains(item)))
            return;
        Screen.Print(TextCombat.ChooseShield);
        var choice = UserInteractiveMenu.GiveChoices([ "yes"],"no");
        cat.HasShield = choice == 0;
        UserInput.DramaticPauseClrScreen();
    }
}