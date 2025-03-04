namespace CatsAndCastles1;

public class BackpackMethods
{
    private readonly UserInput _userInput = new UserInput();
    
    //#region Fields
    //public string[] Options = new string[3];
    //public string[] Descriptions = new string[3];
    
    public string emptySpot = "a faint outline marking the spot where something once rested";
    
    //#end region
    public string[] Pack { get; set; } = new string[5];
    public List<string> DiscardedItems { get; set; }


    public int Wallet { get; set; }
    public int NumberOfSheets { get; set; }
    
    public int NumberOfItemsInPack() // counts how many items are in pack
    {
        var counter = 0;
        for (int i = 0; i < Pack.Length; i++)
        {
            if (Pack[i] != "empty")
            {
                counter++;
            }
        }

        return counter;
    }

    public bool GoldInPack(string gold)
    {
        bool goldAlreadyInPack = false;
        foreach (string thing in Pack)
        {
            if (thing.Contains("gold"))
                goldAlreadyInPack = true;
        }
        return goldAlreadyInPack;
    }
    public bool SheetsInPack(string sheet)
    {
        bool sheetsAlreadyInPack = false;
        foreach (string thing in Pack)
        {
            if (thing.Contains("sheet"))
                sheetsAlreadyInPack = true;
        }
        return sheetsAlreadyInPack;
    }
    
    
    
    public bool AddItemToPack(Characters cat, string item)
    {
        bool goldAlreadyInPack = GoldInPack(item);
        bool sheetsAlreadyInPack = SheetsInPack(item);
        

        //dealt with full pack in different method
        //brush up method to remove item from pack


        //fix this check for is the item has been removed and a way to update the textDescription for the location
        if (item == emptySpot)
        {
            Console.WriteLine("Nothing remains in this spot. Please make an alternate selection");
            Console.WriteLine("Press 'enter' to continue");
            Console.ReadLine();
            return false;
        }


        if (item.Contains("coins"))
            item = AddMoney(item);
        if (item.Contains("sheets"))
            item = AddSheets(item);


        if (goldAlreadyInPack && item.Contains("gold"))
        {
            for (int i = 0; i < Pack.Length; i++) // then add it to an empty space in the pack
            {
                if (Pack[i].Contains("gold") && item.Contains("gold"))
                {
                    Pack[i] = item;
                    break;
                }
            }
        }
        else if (sheetsAlreadyInPack && item.Contains("sheet"))
        {
            for (int i = 0; i < Pack.Length; i++) // then add it to an empty space in the pack
            {
                if (Pack[i].Contains("sheet") && item.Contains("sheet"))
                {
                    Pack[i] = item;
                    break;
                }
            }
        }
        else
        {
            for (int i = 0; i < Pack.Length; i++)
            {
                if (Pack[i] == "empty")
                {
                    Pack[i] = item;
                    break;
                }
            }
        }


        Console.WriteLine($"You pack now contains {item}");
        ListOfAllItemsPickedUp
            .Add(item); //and add the item to the list of all items that have been picked up
        Console.WriteLine("Press 'enter' to continue");
        Console.ReadLine();
        return true;
    }
}