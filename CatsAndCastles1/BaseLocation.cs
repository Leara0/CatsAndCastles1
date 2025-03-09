namespace CatsAndCastles1;

public class BaseLocation
{
    
    private readonly UserInput _userInput = new UserInput();
    UserInteractionsBackpack userInteractionsBackpack = new UserInteractionsBackpack();
    UserInput userInput = new UserInput();
    
    private string LocationIntro;
    public bool DoorUnlocked { get; set; }
    public List<string> OptionsAtLocation { get; set; }
    

    public BaseLocation()
    {
        
    }

    public BaseLocation(string locationIntro, List<string> optionsAtLocation)
    {
        OptionsAtLocation = optionsAtLocation;
        LocationIntro = locationIntro;
    }


    //order of events:
    //print locationIntro
    //call interactiveMenu on the OptionsAtLocation
    //that feeds into... game tree??
    public int RoomMethod() // this is the method to call all the stuff for this location
    {
        Console.Clear();
        Console.WriteLine(LocationIntro);
        int choice =  userInput.GetChoice(OptionsAtLocation, LocationText.DiscardRevisitOption);
        return choice;
    }

    public void isDoorUnlocked(bool isUnlocked)
    {
        DoorUnlocked = isUnlocked;
    }
}