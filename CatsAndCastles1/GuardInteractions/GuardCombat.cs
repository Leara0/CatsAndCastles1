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
        GuardCombatHelper.IntroStuff(cat);

        GuardCombatHelper.WeaponAssignmentAndReview(inventory, cat, badGuy);

        GuardAttacksFirstIfEvasionFailed(cat, badGuy);

        while (cat.Health > 0) //don't include badGuy because of break in code
        {
            HeroAttacks(cat, badGuy);
            if (badGuy.Health == 0) break;

            GuardCombatHelper.GuardAttacks(badGuy, cat);
            UserInput.DramaticPauseClrScreen();
        }

        if (badGuy.Health == 0)
        {
            GuardCombatHelper.WrapUpGuardDeath(badGuy);
            return; //get out of this combat method
        }

        if (cat.Health == 0) GuardCombatHelper.WrapUpCatDeath(cat);
    }

    static void GuardAttacksFirstIfEvasionFailed(Hero cat, BadGuy badGuy)
    {
        if (badGuy.Bribe == BadGuy.Outcome.Failure ||
            badGuy.Flee == BadGuy.Outcome.Failure) //TODO make sure this code is right
        {
            Screen.Print(TextCombat.GuardAttacksFirst);
            GuardCombatHelper.GuardAttacks(badGuy, cat);
            UserInput.DramaticPauseClrScreen();
        }
    }

    static void HeroAttacks(Hero cat, BadGuy guard)
    {
        Screen.Print(TextCombat.YouAttack + cat.WeaponDie, 0,ConsoleColor.DarkBlue);
        Attack(cat, guard);
        Console.WriteLine();
        HealthMessage(guard);
        Console.WriteLine();
        Thread.Sleep(200);
    }

    public static void Attack(Character attacker, Character defender)
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

    public static void HealthMessage(Character character)
    {
        character.Health = Math.Max(character.Health, 0);
        if (character is Hero)
            Screen.Print(TextCombat.HeroHealthCheck + character.Health + TextCombat.OutOf + character.MaxHealth);
        else
            Screen.Print(TextCombat.GuardsHealthCheck + character.Health + TextCombat.OutOf + character.MaxHealth);
    }
}