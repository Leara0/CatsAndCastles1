using CatsAndCastles1.Characters;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.Locations;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1;

public class IntroFluff
{
    public void IntroCutScene()
    {
        Console.Clear();
        Screen.Print(TextGeneral.CatBorder1);
        Screen.Print(TextMainRoom.IntroCutScene);
        Screen.Print(TextMainRoom.StartInRoom);
        UserInput.DramaticPauseClrScreen();
        }

    public void SubsequentWakeUp(Character cat)
    {
        cat.Health = 60;
        Screen.Print(TextMainRoom.SubsequentWakeUp);
        Screen.Print(TextMainRoom.StartInRoom);
        UserInput.DramaticPauseClrScreen();
        }

    
}