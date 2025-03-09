namespace CatsAndCastles1;

public class DerivedLockedLocations(string description, List<string> itemsThatHelp) :
    BaseLocation
{
    //what is my goal here:
    /*Create a tree for what items you have vs need
     *
     *
     */
    private List<string> ItemsThatCouldHelp { get; set; } = itemsThatHelp;
    int situation = 0;


    public string GetObjectChoice(Inventory inventory)
    {
        List<string> listForIMenu = MakeListForInteractiveMenu(inventory);
        UserInteractionLockedRooms userInteractionLockedRoom = new UserInteractionLockedRooms();

        int choiceNumber = userInteractionLockedRoom.GetChoiceForLockedRoom(listForIMenu);
        if (choiceNumber == listForIMenu.Count)
            return "";//if they choose to do nothing return ""

        string itemChoice = listForIMenu[choiceNumber];
        return itemChoice;
    }


    public List<string> MakeListForInteractiveMenu(Inventory inventory)
    {
        List<string> optionsForIMenu = new List<string>();

        for (int i = 0; i < inventory.Pack.Count; i++)
        {
            for (int j = 0; j < ItemsThatCouldHelp.Count; j++)
                if (inventory.Pack[i] == ItemsThatCouldHelp[j])
                    optionsForIMenu.Add(ItemsThatCouldHelp[j]);
        }

/*bool packContainsItem1 = false;
        bool packContainsItem2 = false;
        bool packContainsItem3 = false;

        if (inventory.Pack.Contains(ItemsThatCouldHelp[0]))
            packContainsItem1 = true;
        if (inventory.Pack.Contains(ItemsThatCouldHelp[1]))
            packContainsItem2 = true;
        if (inventory.Pack.Contains(ItemsThatCouldHelp[2]))
            packContainsItem3 = true;

        if (packContainsItem1 && packContainsItem2 && packContainsItem3)
        {
            optionsForIMenu.Add(ItemsThatCouldHelp[0]);
            optionsForIMenu.Add(ItemsThatCouldHelp[1]);
            optionsForIMenu.Add(ItemsThatCouldHelp[2]);
        }
        else if (packContainsItem1 && packContainsItem2)
        {
            optionsForIMenu.Add(ItemsThatCouldHelp[0]);
            optionsForIMenu.Add(ItemsThatCouldHelp[1]);
        }
        else if (packContainsItem1 && packContainsItem3)
        {
            optionsForIMenu.Add(ItemsThatCouldHelp[0]);
            optionsForIMenu.Add(ItemsThatCouldHelp[2]);
        }
        else if (packContainsItem2 && packContainsItem3)
        {
            optionsForIMenu.Add(ItemsThatCouldHelp[1]);
            optionsForIMenu.Add(ItemsThatCouldHelp[2]);
        }
        else if (packContainsItem1)
        {
            optionsForIMenu.Add(ItemsThatCouldHelp[0]);
        }
        else if (packContainsItem2)
        {
            optionsForIMenu.Add(ItemsThatCouldHelp[1]);
        }
        else if (packContainsItem3)
        {
            optionsForIMenu.Add(ItemsThatCouldHelp[2]);
        }

        for (int i = 0; i < optionsForIMenu.Count; i++)
        {
            if (optionsForIMenu[i].Contains("shield"))
                optionsForIMenu[i] = "the shield";
        } // change the phrases to make better sense in a list*/


        return optionsForIMenu;
    }
}