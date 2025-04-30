using CatsAndCastles1.Characters;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.EndOfGame;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.EndOfGame.PassOutOrDie;

public class PassOut
{
    public static void LooseALife(Hero cat)
    {
        cat.Lives--;
        Screen.Print(TextPassOutOrDie.PassingOut);


        if (cat.Lives < 1)
        {
            DoIfNoMoreLives(cat);
            UserInput.DramaticPauseClrScreen();
            return;
        }

        Screen.Print(LivesLeftMessage(cat));
        UserInput.DramaticPauseClrScreen();

        Screen.Print(TextPassOutOrDie.OptionsIntro);


        int choice = UIPassOutDieEndOfGame.ReviveOrQuit();
        if (choice == 1) EndGameDead();//game ends if you quit

        cat.Location = Hero.Place.MainRoom;
        IntroFluff.SubsequentWakeUp(cat);
        Console.Clear();
    }

    static void DoIfNoMoreLives(Hero cat)
    {
        Screen.Print(TextPassOutOrDie.AllLivesAreLost);
        UserInput.DramaticPauseClrScreen();
        EndGameDead();
    }

    static string LivesLeftMessage(Hero cat)
    {
        return TextPassOutOrDie.LivesLeft1 + (9 - cat.Lives) + TextPassOutOrDie.LivesLeft2 + cat.Lives +
               TextPassOutOrDie.LivesLeft3;
    }

    static void EndGameDead()
    {
        Screen.Print(TextPassOutOrDie.Death);
        UserInput.DramaticPauseClrScreen();
        Environment.Exit(0);
    }
}