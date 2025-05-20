using CatsAndCastles1.Characters;
using CatsAndCastles1.DisplayingText;
using CatsAndCastles1.Text.Locations;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1;

public class IntroFluff
{
    public void IntroCutScene()
    {
        Console.Clear();
        //put in welcome screen plus animation
        Animation.PrintWelcome();
        Thread.Sleep(1000);
        Animation.CatIntroAnimation();
        Animation.ContinueAnimation();
        Console.Clear();
        Thread.Sleep(500);
        
        Screen.Print(TextMainRoom.IntroCutScene);
        Screen.Print(TextMainRoom.StartInRoom);
        UserInput.DramaticPauseClrScreen();
        }

    public static void SubsequentWakeUp(Character cat)
    {
        Console.Clear();
        cat.Health = 1;
        Screen.Print(TextMainRoom.SubsequentWakeUp);
        Screen.Print(TextMainRoom.StartInRoom);
        UserInput.DramaticPauseClrScreen();
        }

    
}