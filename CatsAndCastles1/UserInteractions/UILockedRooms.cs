using CatsAndCastles1.Characters;

namespace CatsAndCastles1.UserInteractions;

public class UILockedRooms
{
    UserInput _userInput = new UserInput();
    Random _rnd = new Random();

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
        int roll = _rnd.Next(1, 21);
        Screen.Print(Text.YourRoll + roll +"\n");
        if (roll > 16)
        {
            Screen.Print(Text.StoneOrShieldWorked);
            return true;
        }

        roll = _rnd.Next(1, 7) + 1;
        cat.Health -= roll;
        Screen.Print(Text.StoneDidntWork + roll + Text.StoneEndOfDamage + Text.YourHealth + cat.Health);
        
        return false;
    }

    public bool UseShieldOnDoor(Character cat, string item, Inventory inventory)
    {
        Screen.Print(Text.UseShieldOnDoor);
        _userInput.DramaticPause();
        int roll = _rnd.Next(1, 21);
        Screen.Print(Text.YourRoll + roll +"\n");
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

        roll = _rnd.Next(1, 7) + 1;
        cat.Health -= roll;
        Screen.Print(Text.ShieldDidntWork + roll + Text.StoneEndOfDamage +
                          Text.YourHealth + cat.Health);
        return false;
        }
}