using CatsAndCastles1.Characters;
using CatsAndCastles1.Lists;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GuardInteractions;

public class Combat
{
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
    //I still need to get a weapon to the guard....
    /*void Combat(Hero cat, BadGuy guardDog)
    {
        
  
           var guardMaxHealth = guardDog.Health;
           string[] weaponAndShield = ChooseWeapon();
           cat.Weapon = weaponAndShield[0];
           if (weaponAndShield[1] == "1")
               cat.HasShield = true;
           else
               cat.HasShield = false;


           guardDog.Weapon = ChooseGuardDogWeapon();
           if (rnd.Next(1, 11) > 8)
               guardDog.HasShield = true;
           else
               guardDog.HasShield = false;
           // cat and guardDog have Health and Weapons


           Screen.Print(
               "All your choices and luck have lead to this moment - there is no turning back." +
               "\n\nThe guard dog snarls, its stance low and ready to strike. It's just you " +
               "and the beast, locked in a battle for survival." +
               "\n\nThe air is thick with tension. The dog's muscles bunch, its eyes locked onto you. " +
               "The fight is about to begin." +
               $"\n\nThe {(guardNumber == 2 ? "warden" : "guard")}'s health is {guardDog.Health}. " +
               $"\nYour health is {cat.Health}.");


           WeaponsReminder(cat, "cat");
           WeaponsReminder(guardDog, "guardDog");
           _userInput.DramaticPause();


           int attack;
           if (cat.Caught)
           {
               attack = Attack(guardDog);
               cat.Health -= attack;
               Console.Write($"\nThe guard dog attacks first doing {attack} damage. ");
               if (cat.HasShield)
               {
                   Console.Write("Your shield deflects 1 damage");
                   cat.Health++;
               }


               Screen.Print($"\nYour remaining health is {(Math.Max(cat.Health, 0))} out of 60");




               if (cat.Health > 0)
               {
                   Screen.Print(Text.CatBorder1);
                   _userInput.DramaticPause();
                   
                   
               }
           }


           do
           {
               attack = Attack(cat);
               guardDog.Health -= attack;
               Console.Write($"\nYou attack doing {attack} damage. ");
               if (guardDog.HasShield)
               {
                   Console.Write("Their shield deflects 1 damage.");
                   guardDog.Health++;
               }


               Screen.Print($"\nThe {(guardNumber == 2 ? "warden" : "guard")}'s remaining health is " +
                                 $"{Math.Max(guardDog.Health, 0)} out of {guardMaxHealth}");
               if (guardDog.Health <= 0)
               {
                   Screen.Print("\nYou are victorious in the fight against the guard");
                   guardDog.IsDead = true;//@TODO I changed this from enum Dead to bool so probably need to fix in other places
                   LocationTextBody();
                   return;
               }


               attack = Attack(guardDog);
               cat.Health -= attack;
               Console.Write($"\nThe guard dog attacks you doing {attack} damage. ");
               if (cat.HasShield)
               {
                   Console.Write("Your shield deflects 1 damage");
                   cat.Health++;
               }


               Screen.Print($"\nYour remaining health is {(cat.Health >= 0 ? cat.Health : "0")} out of 60");
               if (cat.Health > 0)
               {
                   Screen.Print(Text.CatBorder1);
                   _userInput.DramaticPause();
                   
               }
           } while (cat.Health > 0);


           if (cat.Health <= 0)
           {
               Screen.Print("\nThe guard has been victorious in this fight\n");
               cat.Location = Hero.Place.PassedOut;
           }
       }*/
}