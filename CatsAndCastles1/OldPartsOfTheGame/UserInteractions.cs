using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.OldPartsOfTheGame;

public class UserInteractions
{
    public string UserChoice(int numberOfOptions = 2)
    {
        do
        {
            string input = Console.ReadLine().Trim() ?? string.Empty;
            for (int i = 1; i <= numberOfOptions; i++)
            {
                string iNumber = i.ToString();
                if (iNumber == input)
                {
                    Console.Clear();
                    return input;
                }
            }


            Screen.Print("I'm sorry, but that isn't a valid choice. ");
            Screen.Print("Please enter a number that corresponds with options above.");
        } while (true);
    }   
}