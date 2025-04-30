namespace CatsAndCastles1.Text.EndOfGame
{
    public static class TextScoreTabulation
    {
        public const string HeadTowardOutsideDoor =
            "\nYou stagger forward, each step pulling you away from the gloom of the castle, " +
            "away from the danger, away from death itself. One final push, and you're free.";

        public const string GetOutside =
            "Cool night air rushes over you, crisp and clean—so unlike the stale dampness of the castle. " +
            "Above, the sky stretches wide and star-filled. Soft, dewy grass brushes against your paws.\n\n" +
            "Though the terrain ahead is dark and veiled in mist, the weight of the castle is already beginning to lift. " +
            "You’ve escaped—and you silently thank your lucky stars. But as the cold fog coils around you, " +
            "you realize the road home remains uncertain.\n\n" +
            "Steeling yourself for what lies ahead, you take a moment to review your inventory, tallying the items " +
            "that might still serve you on the journey to come.";
       
        public const string CombatGear = "Combat Gear";
        public const string TradeGoods = "Trade Goods";
        public const string Provisions = "Provisions";
        public const string CuriousItems = "Curious Items";
        public const string Burdens = "Burdens";
        


        public const string CombatGearDesc = "These items will help you fight or defend yourself during your journey.";
        public const string TradeGoodsDesc = "These may open doors, bribe guards, or be bartered for safe passage.";

        public const string ProvisionsDesc =
            "Food and supplies that will keep you alive through long stretches of wilderness.";

        public const string CuriousItemsDesc =
            "These oddities might comfort you, provide clues, or unlock hidden opportunities.";

        public const string BurdensDesc = "Items that weigh you down without offering much real use.";
        
        public const string NoDesc = "No description available.";
        
       
        public const string ScoreBreakdown = "\nYou earned {0} points for {1}: {2}";
        public const string ItemsInGroupIntro = "Item/s in this group include: {0}";

        public const string FinalScoreIntro = "\nYour final survival score is: {0} points.\n";
        public const string BestEnding = "You leave the castle extraordinarily well-prepared. Whatever lies beyond, you stand ready.";
        public const string GoodEnding = "You have a solid chance of surviving the challenges ahead.";
        public const string OkayEnding = "You carry enough to get by, though the road may be harsh.";
        public const string BadEnding = "You leave with little to your name — survival will not come easily.";
    }
}