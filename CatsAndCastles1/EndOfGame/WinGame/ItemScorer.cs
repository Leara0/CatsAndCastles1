using CatsAndCastles1.Text.EndOfGame;
using CatsAndCastles1.Text.Inventory;


namespace CatsAndCastles1.EndOfGame.WinGame
{
    public static class ItemScorer
    {
        
        public static readonly Dictionary<string, (int Points, string Category)> ItemPoints = new()
        {
            { TextInventoryItems.Dagger, (3, TextScoreTabulation.CombatGear) },
            { TextInventoryItems.LongDagger, (3, TextScoreTabulation.CombatGear) },
            { TextInventoryItems.FirePoker, (3, TextScoreTabulation.CombatGear) },
            { TextInventoryItems.LargeStone, (2, TextScoreTabulation.CombatGear) },
            { TextInventoryItems.ShortSword, (3, TextScoreTabulation.CombatGear) },
            { TextInventoryItems.BatteredShield, (3, TextScoreTabulation.CombatGear) },
            { TextInventoryItems.CrudeShield, (3, TextScoreTabulation.CombatGear) },
            { TextInventoryItems.Shield, (3, TextScoreTabulation.CombatGear) },
            { TextInventoryItems.LockPickSet, (2, TextScoreTabulation.CombatGear) },
            { TextInventoryItems.Rope, (2, TextScoreTabulation.CombatGear) },
            { TextInventoryItems.Manacles, (2, TextScoreTabulation.CombatGear) },

            { TextInventoryItems.RingOfKeys, (2, TextScoreTabulation.TradeGoods) },
            { TextInventoryItems.DogWhistle, (2, TextScoreTabulation.TradeGoods) },

            { TextInventoryItems.LoafOfBread, (1, TextScoreTabulation.Provisions) },
            { TextInventoryItems.DriedMeat, (2, TextScoreTabulation.Provisions) },
            { TextInventoryItems.HardCheese, (2, TextScoreTabulation.Provisions) },
            { TextInventoryItems.TwoSheets, (1, TextScoreTabulation.Provisions) },

            { TextInventoryItems.CatFigurine, (1, TextScoreTabulation.CuriousItems) },
            { TextInventoryItems.CatCollar, (1, TextScoreTabulation.CuriousItems) },
            { TextInventoryItems.DogStatue, (1, TextScoreTabulation.CuriousItems) },
            { TextInventoryItems.BookOfPrayers, (1, TextScoreTabulation.CuriousItems) },
            { TextInventoryItems.DustyBook, (1, TextScoreTabulation.CuriousItems) },
            { TextInventoryItems.Glasses, (1, TextScoreTabulation.CuriousItems) },
            { TextInventoryItems.WorryBeads, (1, TextScoreTabulation.CuriousItems) },
            { TextInventoryItems.CandleStub, (1, TextScoreTabulation.CuriousItems) },
            { TextInventoryItems.Dice, (1, TextScoreTabulation.CuriousItems) },
            { TextInventoryItems.CatWantedPoster, (1, TextScoreTabulation.CuriousItems) },

            { TextInventoryItems.BroomAndDustPan, (0, TextScoreTabulation.Burdens) },
            { TextInventoryItems.RustedLantern, (0, TextScoreTabulation.Burdens) },
        };
        
        public static readonly Dictionary<string, string> CategoryDescriptions = new()
        {
            { TextScoreTabulation.CombatGear, TextScoreTabulation.CombatGearDesc },
            { TextScoreTabulation.TradeGoods, TextScoreTabulation.TradeGoodsDesc },
            { TextScoreTabulation.Provisions, TextScoreTabulation.ProvisionsDesc },
            { TextScoreTabulation.CuriousItems, TextScoreTabulation.CuriousItemsDesc },
            { TextScoreTabulation.Burdens, TextScoreTabulation.BurdensDesc }
        };


        public static (int TotalScore, Dictionary<string, (int Score, List<string> ItemList)>) CalculateScores(
            List<string> pack, int purse)
        {
            var totalScore = 0;
            var categoryWeaponsAndScores = new Dictionary<string, (int score, List<string> itemList)>();
            var itemScores = new List<(string ItemName, int Points)>();
//what am I trying to do?


            // Score items
            foreach (var item in pack)
            {
                //check if the item is in the dictionary
                if (ItemPoints.TryGetValue(item, out var itemInfo))
                {
                    // if it is, add the score to the total score 
                    totalScore += itemInfo.Points;
                    //itemScores.Add((item, itemInfo.Points)); I don't think I'm using this anymore

                    // add the category as a key to the dictionary
                    if (!categoryWeaponsAndScores.ContainsKey(itemInfo.Category))
                        categoryWeaponsAndScores[itemInfo.Category] = (0, new List<string>());

                    //and add the score and weapon (list) to the new dictionary  
                    var currentItem = categoryWeaponsAndScores[itemInfo.Category];
                    currentItem.score += itemInfo.Points;
                    currentItem.itemList.Add(item);
                    categoryWeaponsAndScores[itemInfo.Category] = currentItem;
                }
            }

            // Score coins
            int coinScore = purse / 10;
            totalScore += coinScore;
            if (coinScore > 0)
            {
                if (!categoryWeaponsAndScores.ContainsKey("Trade Goods"))
                {
                    categoryWeaponsAndScores["Trade Goods"] = (0, new List<string>());
                }

                var currentItem = categoryWeaponsAndScores["Trade Goods"];
                currentItem.Item1 += coinScore;
                currentItem.Item2.Add("gold coins");
                categoryWeaponsAndScores["Trade Goods"] = currentItem;
            }


            return (totalScore, categoryWeaponsAndScores);
        }
    }
}