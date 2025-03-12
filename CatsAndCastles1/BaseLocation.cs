namespace CatsAndCastles1;

public class BaseLocation
{
    
    UserInput _userInput = new UserInput();
    
    private readonly string _locationIntro;
    private bool DoorOpen { get; set; }
    public List<string> OptionsAtLocation { get; set; }
    private readonly string _menuHeader = "";
    

    protected BaseLocation()
    {
        
    }

    public BaseLocation(string locationIntro, string pickMenuHeader, List<string> optionsAtLocation)
    {
        OptionsAtLocation = optionsAtLocation;
        _locationIntro = locationIntro;
        _menuHeader = pickMenuHeader;
    }


    //order of events:
    //print locationIntro
    //call interactiveMenu on the OptionsAtLocation
    //that feeds into... game tree??
    public int RoomMethod() // this is the method to call all the stuff for this location
    {
        Console.Clear();
        Console.WriteLine(_menuHeader);
        int choice =  _userInput.GetChoice(OptionsAtLocation, Text.PackOption);
        return choice;
    }

    public void PrintIntro()
    {
        Console.WriteLine(_locationIntro);
        _userInput.DramaticPauseClrScreen();
    }

    public void ChangeDoorLockStatus(bool isUnlocked)
    {
        DoorOpen = isUnlocked;
    }

    public bool DoorIsOpen()
    {
        return DoorOpen;
    }

}