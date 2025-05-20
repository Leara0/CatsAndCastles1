using CatsAndCastles1.DisplayingText;
using CatsAndCastles1.Text.Inventory;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.LocationClasses;

public class Location
{
    
    private readonly UserInput _userInput = new UserInput();
    
    private readonly string _locationIntro ="";
    private bool DoorOpen { get; set; }
    public List<string> OptionsAtLocation { get; set; } = new List<string>();
    private readonly string _menuHeader = "";
    

    protected Location()
    {
        
    }

    public Location(string locationIntro, string pickMenuHeader, List<string> optionsAtLocation)
    {
        _locationIntro = locationIntro;
        _menuHeader = pickMenuHeader;
        OptionsAtLocation = optionsAtLocation;
    }


    public int DecideWhereToExplore() // this is the method to call all the stuff for this location
    {
        Console.Clear();
        Screen.Print(_menuHeader);
        int choice =  _userInput.GetChoice(OptionsAtLocation,  TextWorkInventory.PackOption);
        return choice;
    }

    public void PrintIntro()
    {
        Screen.Print(_locationIntro);
        UserInput.DramaticPauseClrScreen();
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