using CatsAndCastles1.Characters;
using CatsAndCastles1.Lists;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GuardInteractions;

public class Combat
{
    public void EngageInCombat(Hero cat, BadGuy badGuy, Inventory inventory)
    {
        Console.Clear();
        Screen.Print(TextGuard.CombatIntro);
        UserInput.DramaticPauseClrScreen();

        UIWeapons.GetHeroWeaponChoice(cat, inventory.Pack); //this includes words about picking a weapon
        UIWeapons.GetShieldChoice(cat, inventory.Pack);
        if(cat.HasShield) Screen.Print(TextWeapons.YesShield);
        else Screen.Print(TextWeapons.HaveNoShield);
        
        
        UserInput.DramaticPause();
        AssignBadGuyWeaponAndShield(badGuy);

        //review weapons choices
        Screen.Print(TextGuard.HeroWeaponReminder + cat.Weapon);
        if (cat.HasShield) Screen.Print(TextGuard.WithAShield);
        //Screen.Print(TextGuard.GuardWeaponReminder + badGuy.Weapon);
        //if (badGuy.HasShield) Screen.Print(TextGuard.WithAShield);
        UserInput.DramaticPause();
        Console.WriteLine();

        if (badGuy.AttemptedBribeFailed || badGuy.CaughtCat) //TODO make sure this code is right
        {
            Screen.Print(TextGuard.GuardAttacksFirst);
            GuardAttacks(badGuy, cat);
        }

        while (cat.Health > 0) //don't include badGuy because of break in code
        {
            HeroAttacks(cat, badGuy);
            if (badGuy.Health == 0) break;

            GuardAttacks(badGuy, cat);
            UserInput.DramaticPauseClrScreen();
        }

        if (badGuy.Health == 0)
        {
            Screen.Print(TextGuard.YouKilledGuard);
            badGuy.IsDead = true;
            //@TODO looting
            return; //get out of this combat method
        }

        if (cat.Health == 0)
        {
            Screen.Print(TextGuard.GuardWins);
            cat.Location = Hero.Place.PassedOut; //@TODO finish this part so it works!
        }
            
        badGuy.CaughtCat = false;
        badGuy.AttemptedBribeFailed = false; //at the end of combat it doesn't matter if you got caught running away
        //or if your attempted bribe failed because you fought it out
    }

    void HeroAttacks(Hero cat, BadGuy guard)
    {
        Screen.Print(TextGuard.YouAttack + cat.WeaponDie);
        Attack(cat, guard);
        Console.WriteLine();
        HealthMessage(guard);
        Console.WriteLine();
        Thread.Sleep(200);
    }

    void GuardAttacks(BadGuy guard, Hero cat)
    {
        Screen.Print(TextGuard.OpponentAttack + guard.WeaponDie);
        Attack(guard, cat);
        HealthMessage(cat);
        Thread.Sleep(200);
    }

    void Attack(Character attacker, Character defender)
    {
        int damage = Screen.DiceRoller(attacker.WeaponDie) + attacker.WeaponMod;
        Screen.Print(Text.Damage + damage);
        defender.Health -= damage;
        if (defender.HasShield)
        {
            Screen.Print(TextGuard.ShieldDeflects);
            defender.Health++;
        }
    }

    void AssignBadGuyWeaponAndShield(BadGuy badGuy)
    {
        var rnd = new Random();
        var pick = rnd.Next(1, 7);
        badGuy.Weapon = WeaponsInfoList.BadGuyWeapons[pick];
        badGuy.WeaponDie = WeaponsInfoList.DieForBGWeapon[pick];
        badGuy.WeaponMod = WeaponsInfoList.ModForBGWeapon[pick];
        Screen.Print(TextWeapons.BadGuyWeapon + badGuy.Weapon);

        pick = rnd.Next(1, 3);
        if (pick == 1)
        {
            Screen.Print(TextWeapons.YesBGShield);
            badGuy.HasShield = true;
        }
        else
        {
            Screen.Print(TextWeapons.NoBGShield);
            badGuy.HasShield = false;
        }
    }

    void HealthMessage(Character character)
    {
        character.Health = int.Max(character.Health, 0);
        if (character is Hero)
            Screen.Print(TextGuard.HeroHealthCheck + character.Health + TextGuard.OutOf + character.MaxHealth);
        else
            Screen.Print(TextGuard.GuardsHealthCheck + character.Health + TextGuard.OutOf + character.MaxHealth);
    }
}