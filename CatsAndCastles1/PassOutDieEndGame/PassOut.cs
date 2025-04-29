using CatsAndCastles1.Characters;
using CatsAndCastles1.Text;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.PassOutDieEndGame;

public class PassOut
{
    public static void LooseALife(Hero cat)
    {
        cat.Lives--;
        Screen.Print(TextPassOutOrDie.PassingOut);
    }
}