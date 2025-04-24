namespace CatsAndCastles1.Text.Inventory;

public class TextWorkInventory
{
    public const string PackOption = "Your pack. You can inspect the contents and discard ones you no longer want.";

    public const string DiscardRevisitOption = "Item/s you’ve chosen to discard — perhaps too hastily.";

    public const string PrepToListItems = "\nYou find the following item/s that might be helpful:\n";

    public const string ChoiceToTakeItems =
        "Each item has its own allure, yet you know that adding too much to your pack could slow you down. " +
        "You also have the option to leave this location without taking anything, knowing you can always return " +
        "later if desired... ";

    public const string NothingLeft =
        "You've scoured every nook and cranny of this area. Every hidden corner has been " +
        "examined, and every item of value has been claimed. There's nothing left here — this " +
        "location has been completely cleared.";

    public const string EmptyStash = "There are no items in your discard stash.";
    public const string EmptyInventory = "There are no items in your inventory.";

    public const string PickUpFromStash = "You study your discard stash, taking in all the items you've left behind. " +
                                          "Some might still be useful on your journey.";

    public const string AmountInCoinPurse = "Your coin purse currently contains: ";
    public const string GoldCoins = " gold coins.\n";

    public const string ThinkAboutInventory =
        "You take a moment to review the contents " +
        "of your pack, weighing the value of each item. Some may no longer serve your journey " +
        "as well as others, and space is precious since you can only carry 5 items.";

    public const string InsufficientFunds = "You don't have enough funds for this transaction";
    public const string RemoveNothing = "do not remove any items";
    public const string PickUpNothing = "leave all the items as they are";

}