using CatsAndCastles1.Characters;
using CatsAndCastles1.Lists;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GuardInteractions;

public static class GuardCombat
{
    public static void EngageInCombat(Hero cat, BadGuy badGuy, Inventory inventory)
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
        Screen.PrintHeroAttack(TextCombat.HeroWeaponReminder + cat.Weapon);
        Screen.PrintHeroAttack(cat.HasShield? TextCombat.WithAShield : TextCombat.WithoutAShield);
        
        UserInput.DramaticPauseClrScreen();
        
        if (badGuy.Bribe == BadGuy.Outcome.Failure || badGuy.Flee == BadGuy.Outcome.Failure) //TODO make sure this code is right
        {
            Screen.Print(TextCombat.GuardAttacksFirst);
            GuardAttacks(badGuy, cat);
            UserInput.DramaticPauseClrScreen();
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
            if (badGuy.Type != BadGuy.GuardType.Warden)Screen.Print(TextCombat.YouKilledGuard);
            else Screen.Print(TextCombat.DefeatWarden);
            badGuy.IsDead = true;
            //@TODO looting
            UserInput.DramaticPauseClrScreen();
            return; //get out of this combat method
        }

        if (cat.Health == 0)
        {
            Screen.Print(TextCombat.GuardWins);
            cat.Location = Hero.Place.PassedOut; //@TODO finish this part so it works!
        }

    }

    static void  HeroAttacks(Hero cat, BadGuy guard)
    {
        Screen.PrintHeroAttack(TextCombat.YouAttack + cat.WeaponDie);
        Attack(cat, guard);
        Console.WriteLine();
        HealthMessage(guard);
        Console.WriteLine();
        Thread.Sleep(200);
    }

    static void  GuardAttacks(BadGuy guard, Hero cat)
    {
        Screen.PrintBadGuyAttack(TextCombat.OpponentAttack + guard.WeaponDie);
        Attack(guard, cat);
        HealthMessage(cat);
        Thread.Sleep(200);
    }

    static void Attack(Character attacker, Character defender)
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

    static void  AssignBadGuyWeaponAndShield(BadGuy badGuy)
    {
        var rnd = new Random();
        var pick = rnd.Next(0, ListWeaponsInfo.BadGuyWeapons.Count);
        badGuy.Weapon = ListWeaponsInfo.BadGuyWeapons[pick];
        badGuy.WeaponDie = ListWeaponsInfo.DieForBGWeapon[pick];
        badGuy.WeaponMod = ListWeaponsInfo.ModForBGWeapon[pick];
        Screen.PrintBadGuyAttack(TextCombat.BadGuyWeapon + badGuy.Weapon);

        pick = rnd.Next(1, 3);
        if (pick == 1)
        {
            Screen.PrintBadGuyAttack(TextCombat.WithAShield);
            badGuy.HasShield = true;
        }
        else
        {
            Screen.PrintBadGuyAttack(TextCombat.WithoutAShield);
            badGuy.HasShield = false;
        }
    }

    static  void HealthMessage(Character character)
    {
        character.Health = int.Max(character.Health, 0);
        if (character is Hero)
            Screen.Print(TextCombat.HeroHealthCheck + character.Health + TextCombat.OutOf + character.MaxHealth);
        else
            Screen.Print(TextCombat.GuardsHealthCheck + character.Health + TextCombat.OutOf + character.MaxHealth);
    }
    
}