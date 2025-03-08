namespace CatsAndCastles1;

public class BaseLocation(string locationIntro, List<string> optionsAtLocation)
{
    private readonly UserInput _userInput = new UserInput();
    UserInteractionsBackpack userInteractionsBackpack = new UserInteractionsBackpack();
    UserInput userInput = new UserInput();
    public bool DoorUnlocked { get; set; }
    public List<string> OptionsAtLocation = optionsAtLocation;


    //order of events:
    //print locationIntro
    //call interactiveMenu on the OptionsAtLocation
    //that feeds into... game tree??
    public int RoomMethod() // this is the method to call all the stuff for this location
    {
        Console.Clear();
        Console.WriteLine(locationIntro);
        int choice =  userInput.GetChoice(optionsAtLocation, LocationText.DiscardRevisitOption);
        return choice;
    }

    public void isDoorUnlocked(bool isUnlocked)
    {
        DoorUnlocked = isUnlocked;
    }
}