namespace CatsAndCastles1;

public class UserInput ()
{
    BackpackMethods packMethods = new BackpackMethods();
    InteractiveMenu _interactiveMenu;
    public int selectionNumber;
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

    public bool SpaceInPack(string item, BackPack backpack) //this method will deal with a full pack
    {
        if (packMethods.NumberOfItemsInPack() == 5)
        {
            Console.WriteLine("Your pack is too burdened to add any more items. You must remove" +
                              $" something to make space for {item}.");
            selectionNumber =  _interactiveMenu.GiveChoices(backpack.Pack, "Do not remove any items");
            if (selectionNumber < backpack.Pack.Length)
            {
                //RemoveItemFromPack(item, backpack);
                return true;
            }
        }
        return false;
    }

    public void GetSelectionAndChangeInventory(string[] options, BackPack backpack)
    {
        selectionNumber = _interactiveMenu.GiveChoices(options, "Leave this area.");
        //now go to the Pack methods class and change the pack to include options[selectedNumber]
        //also update location instance to track item picked up
        if (selectionNumber == options.Length)
            return; // this means that if you chose to pick nothing up you don't change inventory
        string item = options[selectionNumber];
        if (SpaceInPack(item, backpack))
        {
            
        }
        //show interactive menu options <-- these are all user interactions
        //capture choice
        //feed into backpack
    }


}