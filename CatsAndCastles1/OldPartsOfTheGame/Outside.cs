namespace CatsAndCastles1;


public class OutsideCastle
{
    public void OutsideTheCastle(MainCharacter cat, BackPack backPack)
    {
        SuccessfulEscape(cat);
        //@add something about checking backpack for supplies and gold to make it to the next town
    }


    public void SuccessfulEscape(MainCharacter cat)
    {
        Console.WriteLine("Cool night air rushes over you, crisp and clean, so different from the stale dampness of " +
                          "the castle. The sky stretches vast and open above, dotted with stars. Grass, soft and dewy, " +
                          "brushes against your paws. " +
                          "\n\nThe terrain ahead is dark and shrouded in mist, but already the oppressive atmosphere " +
                          "of the castle begins to lift. You've escaped—and you silently thank your lucky stars");
        Console.WriteLine("for it. As you stand there, the cold fog wrapping around you, you realize the path");
        Console.WriteLine("home is unclear.");
        Console.WriteLine("For now, the only thing that matters is that you are free.");
        Console.WriteLine("The journey ahead may be uncertain, but one thing is sure: you've survived the night.");
        Console.WriteLine("\n   >   >   >   >   >   >   >   >   =^.^=   <   <   <   <   <   <   <   <   <   \n");
        Console.WriteLine("Please press any key to continue...");
        Console.ReadKey();
        cat.EndGame = true;
    }
}