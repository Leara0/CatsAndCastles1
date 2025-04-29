using CatsAndCastles1.Text;

namespace CatsAndCastles1.UserInteractions;

public class UIPassOutDieEndOfGame
{
    public static int ReviveOrQuit()
    {
        var choice = UserInteractiveMenu.GiveChoices(new List<string> { TextPassOutOrDie.ReviveOption, TextPassOutOrDie.Quit});
        return choice;
    }
}