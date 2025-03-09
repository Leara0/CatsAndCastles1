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

    public bool UseStoneOnDoor()
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
        //failure message
        return false;
    }

    public bool UseShieldOnDoor()
    {
        return false;
    }

}