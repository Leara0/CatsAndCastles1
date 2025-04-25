using CatsAndCastles1.Text;

namespace CatsAndCastles1.UserInteractions;

public class UserInteractiveMenu
{
    public static int GiveChoices(List<string> options, string leave = "")
    {
        Screen.Print(TextGeneral.HowToPickAnItem+ "\n", 6);//add padding to offset color change code
        
        int optionSelected = 0;
        ConsoleKeyInfo key;
        bool isSelected = false;
        (int left, int top) = Console.GetCursorPosition();
        string selected = "--> \u001b[32m";
        Console.CursorVisible = false;


        while (!isSelected)
        {
            Console.SetCursorPosition(left, top);
            for (int i = 0; i < options.Count; i++)
                Screen.Print($"{(optionSelected != i ? "   \u001b[0m" : selected )}{options[i]}\u001b[0m");
            if (leave != "")
                Screen.Print($"{(optionSelected == options.Count ? selected : "   \u001b[0m")}{leave}\u001b[0m");
            

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
        Screen.Print($"(You selected: {options[optionSelected]}");
    }
}