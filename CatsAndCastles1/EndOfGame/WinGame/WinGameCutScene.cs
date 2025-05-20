using CatsAndCastles1.DisplayingText;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.EndOfGameText;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.EndOfGame.WinGame;

public class WinGameCutScene
{
    public static void WinCutScene(Inventory inventory)
    {
        Screen.Print(TextScoreTabulation.HeadTowardOutsideDoor);
        UserInput.DramaticPauseClrScreen();
        Screen.Print(TextScoreTabulation.GetOutside);
        UserInput.DramaticPauseClrScreen();
        
        ScoreSummaryPrinter.PrintSummary(inventory);
        Console.WriteLine();
        Screen.Print(TextGeneral.GoodLuck1);
        Screen.Print(TextGeneral.GoodLuck2);
        Screen.Print(TextGeneral.GoodLuck3);
        Screen.Print(TextGeneral.GoodLuck4);
        Screen.Print(TextGeneral.GoodLuck5);
    }
    
}