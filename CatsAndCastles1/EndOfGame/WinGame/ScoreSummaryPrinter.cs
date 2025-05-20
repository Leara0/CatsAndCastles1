using CatsAndCastles1.DisplayingText;
using CatsAndCastles1.Text.EndOfGameText;

namespace CatsAndCastles1.EndOfGame.WinGame
{
    public static class ScoreSummaryPrinter
    {
        public static void PrintSummary(Inventory inventory)
        {
            var packInventory = inventory.Pack;
            int coinCount = inventory.CheckPurseInventory();
            var (totalScore, scoresAndItems) = ItemScorer.CalculateScores(packInventory, coinCount);
            
            //what do I want to happen
            //score is broken down in the following way:
            // Category - category description
            // (Items in that category)

            

            foreach (var (category, scoreItem) in scoresAndItems.OrderByDescending(x => x.Value))
            {
                string description = ItemScorer.CategoryDescriptions.ContainsKey(category) 
                    ? ItemScorer.CategoryDescriptions[category] 
                    : TextScoreTabulation.NoDesc;
                
                Screen.Print(string.Format(TextScoreTabulation.ScoreBreakdown, scoreItem.Score, category, description));
                string itemList = JoinWithAnd(scoreItem.ItemList);
                Screen.Print(string.Format(TextScoreTabulation.ItemsInGroupIntro, itemList));
                
                
            }
            Screen.Print(string.Format(TextScoreTabulation.FinalScoreIntro, totalScore));
            Screen.Print($"\n{GetFinalSummary(totalScore)}");
        }

        private static string GetFinalSummary(int score)
        {
            if (score >= 20)
                return TextScoreTabulation.BestEnding;
            if (score >= 13)
                return TextScoreTabulation.GoodEnding;
            if (score >= 8)
                return TextScoreTabulation.OkayEnding;
            return TextScoreTabulation.BadEnding;
        }
        private static string JoinWithAnd(List<string> items)
        {
            if (items == null || items.Count == 0) return "";
            if (items.Count == 1) return items[0];
            if (items.Count == 2) return $"{items[0]} and {items[1]}";

            return string.Join(", ", items.Take(items.Count - 1)) + ", and " + items.Last();
        }
    }
}