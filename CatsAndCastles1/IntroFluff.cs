namespace CatsAndCastles1;

public class IntroFluff
{
    private readonly UserInput _userInput = new UserInput();
    public void IntroCutScene()
    {
        Console.Clear();
        Console.WriteLine(Text.CatBorder1);
        Console.WriteLine(Text.IntroCutScene);
        Console.WriteLine(Text.StartInRoom);
        _userInput.DramaticPauseClrScreen();
        }

    public void SubsequentWakeUp(Characters cat)
    {
        cat.Health = 60;
        Console.WriteLine(Text.SubsequentWakeUp);
        Console.WriteLine(Text.StartInRoom);
        _userInput.DramaticPauseClrScreen();
        }

    
}