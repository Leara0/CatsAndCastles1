namespace CatsAndCastles1;

public class IntroFluff
{
    private readonly UserInput _userInput = new UserInput();
    public void IntroCutScene()
    {
        Console.Clear();
        Console.WriteLine(LocationText.CatBorder1);
        Console.WriteLine(LocationText.IntroCutScene);
        Console.WriteLine(LocationText.StartInRoom);
        _userInput.DramaticPauseClrScreen();
        }

    public void SubsequentWakeUp(Characters cat)
    {
        cat.Health = 60;
        Console.WriteLine(LocationText.SubsequentWakeUp);
        Console.WriteLine(LocationText.StartInRoom);
        _userInput.DramaticPauseClrScreen();
        }

    
}