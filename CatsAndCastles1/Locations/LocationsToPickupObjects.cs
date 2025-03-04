namespace CatsAndCastles1;

public class LocationsToPickupObjects(string[] locations)
{
    private readonly UserInput _userInput = new UserInput();
    
    public bool FirstItemGone { get; set; }
    public bool SecondItemGone { get; set; }
    public bool ThirdItemGone { get; set; }

    public void LocationDescription(string[] locationText)
    {//This is what happens when you first enter a room
        Console.WriteLine(locationText[0]);
        Console.WriteLine(locationText[1]);
        Console.WriteLine(locationText[2]);
        Console.WriteLine(locationText[3]);
        Console.WriteLine(LocationText.ChoiceToTakeItems);
        _userInput.DramaticPauseClrScreen();    
    }

    
}