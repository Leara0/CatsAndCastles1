using CatsAndCastles1.Text.EndOfGameText;

namespace CatsAndCastles1.UserInteractions;

public class UIPassOutDieEndOfGame
{
    public static int ReviveOrQuit()
    {
        var choice = UserInteractiveMenu.GiveChoices([ TextPassOutOrDie.ReviveOption], TextPassOutOrDie.Quit);
        return choice;
    }
}