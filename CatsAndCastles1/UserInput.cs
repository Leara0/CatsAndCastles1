namespace CatsAndCastles1;

public class UserInput
{
    public string UserChoice(int numberOfOptions = 2)
    {
        do
        {
            string input = Console.ReadLine().Trim();
            for (int i = 1; i <= numberOfOptions; i++)
            {
                string iNumber = i.ToString();
                if (iNumber == input)
                {
                    Console.Clear();
                    return input;
                }
            }


            Console.WriteLine("I'm sorry, but that isn't a valid choice. ");
            Console.WriteLine("Please enter a number that corresponds with options above.");
        } while (true);
    }
    
    public string GetName()
    {
        Console.WriteLine("What is your name (or a name you like)?");
        var name = Console.ReadLine();
        return char.ToUpper(name[0]) + name.Substring(1);
    }
}