using CatsAndCastles1.Text.EndOfGame;
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
    }
    
}