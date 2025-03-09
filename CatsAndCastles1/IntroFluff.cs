namespace CatsAndCastles1;

public class IntroFluff
{
    private readonly UserInput _userInput = new UserInput();
    public void IntroCutScene()
    {
        Console.Clear();
        Console.WriteLine(TextLocation.CatBorder1);
        Console.WriteLine(TextLocation.IntroCutScene);
        Console.WriteLine(TextLocation.StartInRoom);
        _userInput.DramaticPauseClrScreen();
        }

    public void SubsequentWakeUp(Characters cat)
    {
        cat.Health = 60;
        Console.WriteLine(TextLocation.SubsequentWakeUp);
        Console.WriteLine(TextLocation.StartInRoom);
        _userInput.DramaticPauseClrScreen();
        }

    
}