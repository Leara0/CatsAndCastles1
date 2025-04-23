namespace CatsAndCastles1;

public class WeaponText
{
    # region Weapon Choice

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

    public const string YesShield = "\nYou've chosen to use a shield in this fight";
    public const string NoShield = "\nYou've chosen not to use a shield in this fight";

    public const string BadGuyWeapon = "Your opponent will be fighting with ";
    public const string YesBGShield = "Your opponent will be using a shield in this fight";
    public const string NoBGShield = "Your opponent does not have a shield";

    # endregion
}