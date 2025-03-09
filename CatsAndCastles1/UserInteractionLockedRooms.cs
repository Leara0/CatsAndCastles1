namespace CatsAndCastles1;

public class UserInteractionLockedRooms
{
    public int GetChoiceForLockedRoom(List<string> listOfItems)
    {
        UserInteractiveMenu userInteractiveMenu = new UserInteractiveMenu();
        int choiceNumber = userInteractiveMenu.GiveChoices(listOfItems, LocationText.LeaveLockedDoor);
        return choiceNumber;
    }
}