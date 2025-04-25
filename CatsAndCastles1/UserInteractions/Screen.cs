namespace CatsAndCastles1.UserInteractions;

public class Screen
{
    public static List<string> CreateListOfStrings(string text, int extraPadding =0)
    {
        int targetScreenWidth = Console.WindowWidth - Console.WindowWidth / 4;
        List<string> listOfStrings = new List<string>();
        int nextEscapeReturn = text.IndexOf('\n');

        if (text.Length < targetScreenWidth && nextEscapeReturn == -1)
        {
            return [text];
        }

        do
        {
            string currentLine;

            if (nextEscapeReturn != -1 && nextEscapeReturn < targetScreenWidth)
            {
                currentLine = text.Substring(0, nextEscapeReturn);
                text = text.Substring(nextEscapeReturn + 1);
            }
            else
            {
                currentLine = text.Substring(0, (targetScreenWidth));
                var lastSpace = currentLine.LastIndexOf(' ');
                currentLine = text.Substring(0, lastSpace);
                text = text.Substring(lastSpace + 1);
            }

            listOfStrings.Add(currentLine);
            nextEscapeReturn = text.IndexOf('\n');
        } while (text.Length > targetScreenWidth || nextEscapeReturn != -1);

        listOfStrings.Add(text);

        return listOfStrings;
    }

    public static void Print(string text, int extraPadding =0)
    {
        TextBlockToList(CreateListOfStrings(text, extraPadding), extraPadding);
    }

    public static void TextBlockToList(List<string> textList, int extraPadding) => textList.ForEach(x => CenterLineOfText(x, extraPadding));


    public static void CenterLineOfText(string text, int extraPadding = 0)
    {
        int screenWidth = Console.WindowWidth;

        if (text.StartsWith("\n"))
        {
            Console.WriteLine();
            text = text.TrimStart('\n');
        }

        int textLength = text.Length;

        int padding = (screenWidth + textLength) / 2;


        Console.WriteLine(text.PadLeft(padding+extraPadding));
    }
    
    

    public static int DiceRoller(int maxRoll)
    {
        var rnd = new Random();
        int X = 0;
        (int, int Y) cursorPosition = Console.GetCursorPosition();
        var roll = 0;
        for (int i = 0; i < 20; i++)
        {
            roll = rnd.Next(1, maxRoll + 1);
            Print(roll.ToString());
            Thread.Sleep(100);
            Console.SetCursorPosition(X, cursorPosition.Y);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(X, cursorPosition.Y);
            
        }
        roll = rnd.Next(1, maxRoll + 1);
        Print(roll.ToString());
        Thread.Sleep(500);
        return roll;
    }
}