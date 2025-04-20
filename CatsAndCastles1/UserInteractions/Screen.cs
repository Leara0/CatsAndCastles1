namespace CatsAndCastles1;

public class Screen
{
    public static List<string> CreateListOfStrings(string text)
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
                nextEscapeReturn = text.IndexOf('\n');
                currentLine = text.Substring(0, nextEscapeReturn);
                text = text.Substring(nextEscapeReturn + 1);
                listOfStrings.Add(currentLine);
            }
            else
            {
                currentLine = text.Substring(0, (targetScreenWidth));
                text = text.Substring(targetScreenWidth);
                var nextSpace = text.IndexOf(' ');
                var fragment = text.Substring(0, nextSpace);
                currentLine += fragment;
                text = text.Substring(nextSpace + 1);
                listOfStrings.Add(currentLine);
            }

            nextEscapeReturn = text.IndexOf('\n');
        } while (text.Length > targetScreenWidth || nextEscapeReturn != -1);

        listOfStrings.Add(text);

        return listOfStrings;
    }

    public static void Print(string text)
    {
        TextBlockToList(CreateListOfStrings(text));
    }

    public static void TextBlockToList(List<string> textList) => textList.ForEach(x => CenterLineOfText(x));


    public static void CenterLineOfText(string text)
    {
        int screenWidth = Console.WindowWidth;

        if (text.StartsWith("\n"))
        {
            Console.WriteLine();
            text = text.TrimStart('\n');
        }

        int textLength = text.Length;

        int padding = (screenWidth + textLength) / 2;


        Console.WriteLine(text.PadLeft(padding));
    }
}