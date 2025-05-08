using CatsAndCastles1.Lists;
using CatsAndCastles1.Text.GuardEncounter;

namespace CatsAndCastles1.UserInteractions;

public class UIGuard
{
    // this will be a method to get the user's choice for what action to do
    //I'm using this method so the bribe option includes the amount of gold in your purse
    public static int GetActionChoice(Inventory inventory)
    {
        var listOfOptions = ListGuardSpecificText.CreateBribeOptionsList(inventory);
        int choice = UserInteractiveMenu.GiveChoices(listOfOptions, TextGuard.RunawayOption);
        return choice;
    }
}