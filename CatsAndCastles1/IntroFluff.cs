using CatsAndCastles1.Characters;
using CatsAndCastles1.DisplayingText;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.Locations;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1;

public class IntroFluff
{
    public void IntroCutScene()
    {
        Console.Clear();
        //put in welcome screen plus animation
        while (Console.WindowHeight < 25)
        {
            Screen.Print(TextGeneral.ESCAPETooSmallConsole);
            UserInput.DramaticPauseClrScreen();
        }

        //This is animation welcome screen. 
        Animation.PrintWelcome();
        Thread.Sleep(1000);
        Animation.CatIntroAnimation();
        UIAnimation.ContinueAnimation(); //continues sparkles until enter is pressed
        Console.Clear();
        Thread.Sleep(300);

        Screen.Print(TextMainRoom.IntroCutScene);
        Screen.Print(TextMainRoom.StartInRoom);
        UserInput.DramaticPauseClrScreen();
    }

    public static void SubsequentWakeUp(Character cat)
    {
        Console.Clear();
        Screen.Print(TextMainRoom.SubsequentWakeUp);
        Screen.Print(TextMainRoom.StartInRoom);
        UserInput.DramaticPauseClrScreen();
    }
}