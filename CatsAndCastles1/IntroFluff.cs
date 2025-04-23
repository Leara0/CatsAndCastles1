using CatsAndCastles1.Characters;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1;

public class IntroFluff
{
    public void IntroCutScene()
    {
        Console.Clear();
        Screen.Print(Text.CatBorder1);
        Screen.Print(Text.IntroCutScene);
        Screen.Print(Text.StartInRoom);
        UserInput.DramaticPauseClrScreen();
        }

    public void SubsequentWakeUp(Character cat)
    {
        cat.Health = 60;
        Screen.Print(Text.SubsequentWakeUp);
        Screen.Print(Text.StartInRoom);
        UserInput.DramaticPauseClrScreen();
        }

    
}