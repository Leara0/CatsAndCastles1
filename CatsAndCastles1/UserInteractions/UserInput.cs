namespace CatsAndCastles1.UserInteractions;

public class UserInput()
{
    UserInteractiveMenu _userInteractiveMenu = new UserInteractiveMenu();
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


            Console.WriteLine("I'm sorry, but that isn't a valid choice. ");
            Console.WriteLine("Please enter a number that corresponds with options above.");
        } while (true);
    }

    public string GetName()
    {
        Console.WriteLine("What is your name (or a name you like)?");
        do
        {
            var name = Console.ReadLine() ?? string.Empty;
            if (!string.IsNullOrEmpty(name))
                return char.ToUpper(name[0]) + name.Substring(1);
            else
            {
                Console.WriteLine("I'm sorry, that's not a valid input. Please try again");
            }
        } while (true);
    }

    public void DramaticPause()
    {
        Console.WriteLine("Please press 'Enter' to continue...");
        Console.ReadLine();
    }

    public void DramaticPauseClrScreen()
    {
        Console.WriteLine("\nPlease press 'Enter' to continue...");
        Console.ReadLine();
        Console.Clear();
    }

    public int GetChoice(List<string> choiceOptions, string extra)
    {
        return _userInteractiveMenu.GiveChoices(choiceOptions, extra);
    }
}