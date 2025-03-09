namespace CatsAndCastles1;

public class BaseLocation
{
    
    UserInput _userInput = new UserInput();
    
    private readonly string _locationIntro;
    private bool DoorOpen { get; set; }
    public List<string> OptionsAtLocation { get; set; }
    

    protected BaseLocation()
    {
        
    }

    public BaseLocation(string locationIntro, List<string> optionsAtLocation)
    {
        OptionsAtLocation = optionsAtLocation;
        _locationIntro = locationIntro;
    }


    //order of events:
    //print locationIntro
    //call interactiveMenu on the OptionsAtLocation
    //that feeds into... game tree??
    public int RoomMethod() // this is the method to call all the stuff for this location
    {
        Console.Clear();
        Console.WriteLine(_locationIntro);
        int choice =  _userInput.GetChoice(OptionsAtLocation, TextLocation.DiscardRevisitOption);
        return choice;
    }

    public void ChangeDoorLockStatus(bool isUnlocked)
    {
        DoorOpen = isUnlocked;
    }

    public bool DoorisOpen()
    {
        return DoorOpen;
    }

}