using CatsAndCastles1.Characters;
using CatsAndCastles1.Lists;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GuardInteractions;

public class UIWeapons
{
    public void GetWeaponChoice(Hero cat, Inventory inventory)
    {
        var weaponModList = new WeaponModsList();
        var userInteractiveMenu = new UserInteractiveMenu();
        //add some text about picking the weapon
        
        if (inventory.Pack.Count == 0) //if inventory is empty
        {
            //put text here to tell you you will be fighting with paws because inventory is empty
        }
        else
        {
            //create a list for the weapon version of the pack
            var weaponOptionsList = weaponModList.CreateWeaponsOptionList(inventory);
            
            //call the interactive menu to get the user's weapon choice
            var choice = userInteractiveMenu.GiveChoices(weaponOptionsList);
            
            //assign the weapon to the cat (assign the weapon die and weapon mod to the cat)
            cat.WeaponDie = weaponModList.DieForWeapon[choice];
            cat.WeaponMod = weaponModList.ModForWeapon[choice];
            
            //no need to return the number since I'm assigning the weapon to the cat instance
        }
    }

    

    //@TODO Move this out of here when ready

    /*
     * The plan...
     * Use InteractiveMenu to display items in inventory to choose from
     * How to inform user of strength of each item???
     * Maybe add it to the end of the Interactive Menu???
     * foreach(string weapon in pack)
     * {
     *
     *
     * Or maybe make multidimensional array with [0,i] being weapon name and [1,i] being the modifier
     * then go through the inventory in outter loop and go through the multidim array in an inner loop and
     * print if you get a match
     */


    public int DefenseChoice(string defense)
    {
        switch (defense)
        {
            case "the shield":
            case "the crude shield":
            case "the worn shield":
            case "the sturdy shield":
                return 2;
            default:
                return 0;
        }
    }
}