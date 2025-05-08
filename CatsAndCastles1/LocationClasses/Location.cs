using CatsAndCastles1.Text;
using CatsAndCastles1.Text.Inventory;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.LocationClasses;

public class Location
{
    
    UserInput UserInput = new UserInput();
    
   public string LocationIntro;
    private bool DoorOpen { get; set; }
    public List<string> OptionsAtLocation { get; set; }
    private readonly string _menuHeader = "";
    

    protected Location()
    {
        
    }

    public Location(string locationIntro, string pickMenuHeader, List<string> optionsAtLocation)
    {
        LocationIntro = locationIntro;
        _menuHeader = pickMenuHeader;
        OptionsAtLocation = optionsAtLocation;
    }


    public int DecideWhereToExplore() // this is the method to call all the stuff for this location
    {
        Console.Clear();
        Screen.Print(_menuHeader);
        int choice =  UserInput.GetChoice(OptionsAtLocation,  TextWorkInventory.PackOption);
        return choice;
    }

    public void PrintIntro()
    {
        Screen.Print(LocationIntro);
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