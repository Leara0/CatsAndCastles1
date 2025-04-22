using CatsAndCastles1.Characters;

namespace CatsAndCastles1.UserInteractions;

public class UILockedRooms
{
    UserInput _userInput = new UserInput();


    public int GetChoiceForLockedRoom(List<string> listOfItems)
    {
        UserInteractiveMenu userInteractiveMenu = new UserInteractiveMenu();
        int choiceNumber = userInteractiveMenu.GiveChoices(listOfItems, Text.LeaveLockedDoor);
        return choiceNumber;
    }

    public bool UseStoneOnDoor(Character cat)
    {
        Screen.Print(Text.UseStoneOnDoor);
        _userInput.DramaticPause();
        int roll = Screen.DiceRoller(20);
        Screen.Print(Text.YourRoll + roll + "\n");
        if (roll > 16)
        {
            Screen.Print(Text.StoneOrShieldWorked);
            return true;
        }

        Screen.Print(Text.StoneDidntWork + Text.DetBluntObjectDamage);
        _userInput.DramaticPause();
        roll = Screen.DiceRoller(6) + 1;
        cat.Health -= roll;
        Screen.Print(Text.Damage + roll + "\n");
        Screen.Print(Text.YourHealth + cat.Health + Text.OutOfTotalHealth + cat.MaxHealth);
        return false;
    }

    public bool UseShieldOnDoor(Character cat, string item, Inventory inventory)
    {
        Screen.Print(Text.UseShieldOnDoor);
        _userInput.DramaticPause();
        int roll = Screen.DiceRoller(20);
        Screen.Print(Text.YourRoll + roll + "\n");
        if (roll > 16)
        {
            Screen.Print(Text.StoneOrShieldWorked);
            return true;
        }

        if (roll < 6)
        {
            Screen.Print(Text.ShieldBreaks);
            inventory.Pack.Remove(item);
            return false;
        }


        Screen.Print(Text.ShieldDidntWork + Text.DetBluntObjectDamage);
        _userInput.DramaticPause();
        roll = Screen.DiceRoller(6) + 1;
        cat.Health -= roll;
        Screen.Print(Text.Damage + roll + "\n");
        Screen.Print(Text.YourHealth + cat.Health + Text.OutOfTotalHealth + cat.MaxHealth);
        return false;
    }
}