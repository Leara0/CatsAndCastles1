using CatsAndCastles1.Characters;
using CatsAndCastles1.Lists;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GuardInteractions;

public class Combat
{
    public void EngageInCombat(Hero cat, BadGuy badGuy, Inventory inventory)
    {
        Console.Clear();
        Screen.Print(TextCombat.CombatIntro);
        UserInput.DramaticPauseClrScreen();

        UIWeapons.GetHeroWeaponChoice(cat, inventory.Pack); //this includes words about picking a weapon
        UIWeapons.GetShieldChoice(cat, inventory.Pack);

        //earlier this was a problem when I removed the dramatic pause (chatGPT suggested a sleep to synchronize things 
        //but after I added and removed the sleep it started working again
        AssignBadGuyWeaponAndShield(badGuy);

        //review weapons choices
        Screen.Print(TextCombat.HeroWeaponReminder + cat.Weapon);
        Screen.Print(cat.HasShield? TextCombat.WithAShield : TextCombat.WithoutAShield);
        //Screen.Print(TextGuard.GuardWeaponReminder + badGuy.Weapon);
        //if (badGuy.HasShield) Screen.Print(TextGuard.WithAShield);
        UserInput.DramaticPauseClrScreen();
        
        if (badGuy.AttemptedBribeFailed || badGuy.CaughtCat) //TODO make sure this code is right
        {
            Screen.Print(TextCombat.GuardAttacksFirst);
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
            Screen.Print(TextCombat.YouKilledGuard);
            badGuy.IsDead = true;
            //@TODO looting
            return; //get out of this combat method
        }

        if (cat.Health == 0)
        {
            Screen.Print(TextCombat.GuardWins);
            cat.Location = Hero.Place.PassedOut; //@TODO finish this part so it works!
        }
            
        badGuy.CaughtCat = false;
        badGuy.AttemptedBribeFailed = false; //at the end of combat it doesn't matter if you got caught running away
        //or if your attempted bribe failed because you fought it out
    }

    void HeroAttacks(Hero cat, BadGuy guard)
    {
        Screen.Print(TextCombat.YouAttack + cat.WeaponDie);
        Attack(cat, guard);
        Console.WriteLine();
        HealthMessage(guard);
        Console.WriteLine();
        Thread.Sleep(200);
    }

    void GuardAttacks(BadGuy guard, Hero cat)
    {
        Screen.Print(TextCombat.OpponentAttack + guard.WeaponDie);
        Attack(guard, cat);
        HealthMessage(cat);
        Thread.Sleep(200);
    }

    void Attack(Character attacker, Character defender)
    {
        int damage = Screen.DiceRoller(attacker.WeaponDie) + attacker.WeaponMod;
        Screen.Print(TextGeneral.Damage + damage);
        defender.Health -= damage;
        if (defender.HasShield)
        {
            Screen.Print(TextCombat.ShieldDeflects);
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
        Screen.Print(TextCombat.BadGuyWeapon + badGuy.Weapon);

        pick = rnd.Next(1, 3);
        if (pick == 1)
        {
            Screen.Print(TextCombat.WithAShield);
            badGuy.HasShield = true;
        }
        else
        {
            Screen.Print(TextCombat.WithoutAShield);
            badGuy.HasShield = false;
        }
    }

    void HealthMessage(Character character)
    {
        character.Health = int.Max(character.Health, 0);
        if (character is Hero)
            Screen.Print(TextCombat.HeroHealthCheck + character.Health + TextCombat.OutOf + character.MaxHealth);
        else
            Screen.Print(TextCombat.GuardsHealthCheck + character.Health + TextCombat.OutOf + character.MaxHealth);
    }
}