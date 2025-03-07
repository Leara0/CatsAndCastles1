using System.Net.Mime;

namespace CatsAndCastles1;

public class InteractiveMenu
{
    public int GiveChoices(List<string> options, string leave)
    {
        int optionSelected = 0;
        ConsoleKeyInfo key;
        bool isSelected = false;
        (int left, int top) = Console.GetCursorPosition();
        string color = "--> \u001b[32m";
        Console.CursorVisible = false;


        while (!isSelected)
        {
            Console.SetCursorPosition(left, top);
            for (int i = 0; i < options.Count; i++)
                Console.WriteLine($"{(optionSelected == i ? color : "    ")}{options[i]}\u001b[0m");
            if (leave != "")
                Console.WriteLine($"{(optionSelected == options.Count ? color : "    ")}{leave}\u001b[0m");
            

            key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (optionSelected == 0)
                    {
                        optionSelected = options.Count;
                        break;
                    }

                    optionSelected--;
                    break;
                case ConsoleKey.DownArrow:
                    if (optionSelected == options.Count)
                    {
                        optionSelected = 0;
                        break;
                    }

                    optionSelected++;
                    break;
                case ConsoleKey.Enter:
                    isSelected = true;
                    break;
            }
        }

        return optionSelected;
        Console.Clear();
        Console.WriteLine($"(You selected: {options[optionSelected]}");
    }
}