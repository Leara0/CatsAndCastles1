namespace CatsAndCastles1;

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
        Console.WriteLine(Text.UseStoneOnDoor);
        _userInput.DramaticPause();
        int roll = _rnd.Next(1, 21);
        Console.WriteLine(Text.YourRoll + roll +"\n");
        if (roll > 16)
        {
            Console.WriteLine(Text.StoneOrShieldWorked);
            return true;
        }

        roll = _rnd.Next(1, 7) + 1;
        cat.Health -= roll;
        Console.WriteLine(Text.StoneDidntWork + roll + Text.StoneEndOfDamage + Text.YourHealth + cat.Health);
        
        return false;
    }

    public bool UseShieldOnDoor(Character cat, string item, Inventory inventory)
    {
        Console.WriteLine(Text.UseShieldOnDoor);
        _userInput.DramaticPause();
        int roll = _rnd.Next(1, 21);
        Console.WriteLine(Text.YourRoll + roll +"\n");
        if (roll > 16)
        {
            Console.WriteLine(Text.StoneOrShieldWorked);
            return true;
        }

        if (roll < 6)
        {
            Console.WriteLine(Text.ShieldBreaks);
            inventory.Pack.Remove(item);
            return false;
        }

        roll = _rnd.Next(1, 7) + 1;
        cat.Health -= roll;
        Console.WriteLine(Text.ShieldDidntWork + roll + Text.StoneEndOfDamage +
                          Text.YourHealth + cat.Health);
        return false;
        }
}