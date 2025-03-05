using System.Net.Mime;

namespace CatsAndCastles1;

public class BackpackMethods //I got rid of the chance to use sheets to climb down. Now its just the rope options
{
    private readonly UserInput _userInput = new UserInput();


    //public string[] Options = new string[3];
    //public string[] Descriptions = new string[3];

    public string _emptySpot = "a faint outline marking the spot where something once rested";
    private int _purse = 0;


    #region Properties

    public string[] Pack { get; set; } = new string[5];
    public List<string> DiscardedItems { get; set; }

    #endregion

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

    /*public bool GoldInPack(string item)
    {
        bool goldAlreadyInPack = false;
        foreach (string thing in Pack)
        {
            if (thing.Contains("gold"))
                goldAlreadyInPack = true; //maybe then complete adding gold to pack
        }

        return goldAlreadyInPack;
    }*/

    public void AddGoldToPurse(string item)
    {
        var amount = int.Parse(item.Substring(0, 2));
        _purse += amount;
        //Console.WriteLine($"Your coin purse now contains {_purse} gold coin/s.");
        //@TODO move this line somewhere else! 
    }


    public bool AddItemToPack(Characters cat, string item)
    {
        //@TODO fix this check for is the item has been removed and a way to update the textDescription for the location
        if (item == _emptySpot)
        {
            Console.WriteLine("Nothing remains in this spot. Please make an alternate selection");
            Console.WriteLine("Press 'enter' to continue");
            Console.ReadLine();
            return false;
        }

        for (int i = 0; i < Pack.Length; i++)
        {
            if (Pack[i] == "empty")
            {
                Pack[i] = item;
                break;
            }
        }


        Console.WriteLine($"You pack now contains {item}");
        // @TODO create a method to track what was added 
        _userInput.DramaticPause();
        return true;
    }
}