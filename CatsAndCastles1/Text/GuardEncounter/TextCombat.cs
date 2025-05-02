namespace CatsAndCastles1.Text.GuardEncounter;

public static class TextCombat
{
    # region Weapon Mods Fields

    public const string BroomAndDustPanMod = "1D4+1";
    public const string ManaclesMod = "1D6+1";
    public const string DaggerMod = "1D8+2";
    public const string CatFigurineMod = "1D4+1";
    public const string FirePokerMod = "1D6+2";
    public const string LargeStoneMod = "1D6+1";
    public const string LongDaggerMod = "1D8+3";
    public const string DogStatueMod = "1D4+1";
    public const string ShortSwordMod = "1D10+2";
    public const string RustedLanternMod = "1D4+1";
    public const string DustyBookMod = "1D4+1";
    public const string CandleStubMod = "1D4+0";
    public const string PawsMod = "1D4+0";

    #endregion

    #region Weapon Choosing

    public const string CheckInventory =
        "You quickly check your inventory, assessing what you have and what might help you in " +
        "battle.\n\n";

    public const string FightWithPaws = ("Your pack is empty. Your only choice is to fight with your paws: D4 +0");

    public const string ChooseYourWeapon =
        "Here are the items in your inventory that can be used as weapons. Each one deals damage based on a dice roll and a modifier. " +
        "The format follows this pattern: the first number shows how many dice to roll, the second tells you how many " +
        "sides the dice have, and the number after the plus sign is the modifier. " +
        "\nFor example, 1D6+2 means you’ll roll one six-sided die and add 2 to the result.\n\n" +
        "Which weapon would you like to fight with?\n";

    public const string ChosenWeapon = "\nYou have chosen to fight with ";

    public const string ChooseShield =
        "\nYour pack holds a shield — it would offer +1 protection in this fight, but its " +
        "weight might slow you down, making you less agile. Do you want to use it in this fight?";
  
    public const string BadGuyWeapon = "Your opponent will be fighting with ";
    public const string HeroWeaponReminder = "You will be fighting with ";
    public const string WithAShield = " and will be using a shield.";
    public const string WithoutAShield = " and will not be using a shield.";

    # endregion
    
    # region Combat Encounter
    public const string CombatIntro = "All your choices and luck have lead to this moment - there is no turning back." +
                                      "\n\nThe guard dog snarls, its stance low and ready to strike. It's just you " +
                                      "and the beast, locked in a battle for survival." +
                                      "\n\nThe air is thick with tension. The dog's muscles bunch, its eyes locked onto you. " +
                                      "The fight is about to begin.\n\n";

    public const string GuardsHealthCheck = "Your opponent's health is ";
    public const string HeroHealthCheck = "Your health is ";
    public const string OutOf = " out of ";
    

    public const string GuardAttacksFirst =
        "You have lost the element of surprise due to your attempt to avoid confrontation. The guard will attack first.";

    public const string YouAttack = "You attack. You roll a D";
    public const string OpponentAttack = "Your opponent attacks. They roll a D";
    public const string ShieldDeflects = "The shield deflects 1 damage.";
    public const string YouKilledGuard = "\nYou are victorious in the fight against the guard";
    public const string DefeatWarden =
        "\nThe battle was brutal. The Warden was relentless. You dodged, clawed, bit, and fought " +
        "with everything you had." +
        "\n\nNow, the Warden lies motionless, its massive form still, its armor dented and " +
        "bloodied. You stand victorious. Your body aches, your breath comes ragged, " +
        "but you are alive.";
    public const string GuardWins = "\nThe guard has been victorious in this fight\n";
    # endregion
    
    
}