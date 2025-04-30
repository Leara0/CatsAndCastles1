using CatsAndCastles1.Characters;
using CatsAndCastles1.Lists;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.EndOfGame;
using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GuardInteractions;

public static class GuardCombatHelper
{
    public static void IntroStuff(Hero cat)
    {
        Console.Clear();
        Screen.Print(TextCombat.CombatIntro);
        UserInput.DramaticPauseClrScreen();
        Reveal9Lives(cat);
    }

    public static void Reveal9Lives(Hero cat)
    {
        if (!cat.FirstCombatTriggered)
        {
            Screen.Print(TextPassOutOrDie.RevealNineLives);
            UserInput.DramaticPauseClrScreen();
        }

        cat.FirstCombatTriggered = true;
    }

    public static void WeaponAssignmentAndReview(Inventory inventory, Hero cat, BadGuy badGuy)
    {
        UIWeapons.GetHeroWeaponChoice(cat, inventory.Pack); //this includes words about picking a weapon
        UIWeapons.GetShieldChoice(cat, inventory.Pack);

        // Note: Timing issues happened here previously. DramaticPause resolves it reliably.
        AssignBadGuyWeaponAndShield(badGuy);

        //review weapons choices
        Screen.PrintHeroAttack(TextCombat.HeroWeaponReminder + cat.Weapon);
        Screen.PrintHeroAttack(cat.HasShield ? TextCombat.WithAShield : TextCombat.WithoutAShield);

        UserInput.DramaticPauseClrScreen();
    }

    public static void AssignBadGuyWeaponAndShield(BadGuy badGuy)
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

    public static void GuardAttacks(BadGuy guard, Hero cat)
    {
        Screen.PrintBadGuyAttack(TextCombat.OpponentAttack + guard.WeaponDie);
        GuardCombat.Attack(guard, cat);
        GuardCombat.HealthMessage(cat);
        Thread.Sleep(200);
    }

    public static void WrapUpGuardDeath(BadGuy badGuy)
    {
        Screen.Print(badGuy.Type != BadGuy.GuardType.Warden ? TextCombat.YouKilledGuard : 
            TextCombat.DefeatWarden);
        badGuy.IsDead = true;

        UserInput.DramaticPauseClrScreen();
    }

    public static void WrapUpCatDeath(Hero cat)
    {
        Screen.Print(TextCombat.GuardWins);
        cat.Location = Hero.Place.PassedOut; //@TODO finish this part so it works!
    }
}