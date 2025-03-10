namespace CatsAndCastles1;

public class UserInteractionLockedRooms
{
    UserInput _userInput = new UserInput();
    Random _rnd = new Random();

    public int GetChoiceForLockedRoom(List<string> listOfItems)
    {
        UserInteractiveMenu userInteractiveMenu = new UserInteractiveMenu();
        int choiceNumber = userInteractiveMenu.GiveChoices(listOfItems, TextLocation.LeaveLockedDoor);
        return choiceNumber;
    }

    public bool UseStoneOnDoor(Characters cat)
    {
        Console.WriteLine(TextLocation.UseStoneOnDoor);
        _userInput.DramaticPause();
        int roll = _rnd.Next(1, 21);
        Console.WriteLine(TextLocation.YourRoll + roll.ToString());
        if (roll > 16)
        {
            Console.WriteLine(TextLocation.StoneOrShieldWorked);
            return true;
        }

        cat.Health -= roll;
        roll = _rnd.Next(1, 7) + 1;
        Console.WriteLine(TextLocation.StoneDidntWork + roll.ToString() + TextLocation.StoneEndOfDamage);
        _userInput.DramaticPauseClrScreen();

        return false;
    }

    public bool UseShieldOnDoor(string item, Inventory inventory)
    {
        Console.WriteLine(TextLocation.UseShieldOnDoor);
        _userInput.DramaticPause();
        int roll = _rnd.Next(1, 21);
        Console.WriteLine(TextLocation.YourRoll + roll.ToString());
        if (roll > 16)
        {
            Console.WriteLine(TextLocation.StoneOrShieldWorked);
            return true;
        }

        if (roll < 6)
        {
            Console.WriteLine(TextLocation.ShieldBreaks);
            inventory.Pack.Remove(item);
            _userInput.DramaticPauseClrScreen();
            return false;
        }

        
        roll = _rnd.Next(1, 7) + 1;
        Console.WriteLine(TextLocation.ShieldDidntWork + roll.ToString() + TextLocation.StoneEndOfDamage);
        _userInput.DramaticPauseClrScreen();

        return false;
        }
}