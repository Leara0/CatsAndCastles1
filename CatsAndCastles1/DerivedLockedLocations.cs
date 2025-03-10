namespace CatsAndCastles1;

public class DerivedLockedLocations(string description, List<string> itemsThatWontHelp) :
    DerivedItemsLocation
{
    private List<string> _allPossibleUsefulItems = ListsForLockedPlaces.AllPossibleOptions;
    public List<string> ItemsThatWontHelp { get; set; } = itemsThatWontHelp;
    private readonly UserInput _userInput = new UserInput();
    UserInteractionLockedRooms userInteractionLockedRoom = new UserInteractionLockedRooms();

   #region Methods

   public List<string> MakeListForInteractiveMenu(Inventory inventory)
   {
       List<string> optionsForIMenu = new List<string>();

       foreach (string item in inventory.Pack)
       {
           foreach (string usefulItems in _allPossibleUsefulItems)
               if (item == usefulItems)
                   optionsForIMenu.Add(usefulItems);
       }

       return optionsForIMenu;
   }
    public virtual string GetObjectChoice(Inventory inventory)
    {
        List<string> listForIMenu = MakeListForInteractiveMenu(inventory);


        int choiceNumber = userInteractionLockedRoom.GetChoiceForLockedRoom(listForIMenu);
        if (choiceNumber == listForIMenu.Count)
            return ""; //if they choose to do nothing return ""

        string itemChoice = listForIMenu[choiceNumber];
        return itemChoice;
    }
    

    public void ApproachLockedDoor()
    {
        Console.Clear();
        Console.WriteLine(description); //@TODO change this to the description in the parameters
        _userInput.DramaticPauseClrScreen();
    }

    public virtual string InteractWithLockedDoor(Inventory inventory)
    {
        Console.WriteLine(TextLocation.AtDoorCheckInventory);
        if (MakeListForInteractiveMenu(inventory).Count == 0)
        {
            Console.WriteLine(TextLocation.AtDoorCheckInventoryFindNothing);
            _userInput.DramaticPauseClrScreen();
            return "leave"; //explain you found nothing and return empty string to indicate leave this location
        }

        string item = GetObjectChoice(inventory);
        if (item == "")
        {
            _userInput.DramaticPauseClrScreen();
            return "leave"; //leave this area if they choose to
        }

        if (ItemsThatWontHelp.Contains(item))
        {
            if (item == TextItemDescription.RingOfKeys)
                Console.WriteLine(TextLocation.KeysWontWork);
            if (item == TextItemDescription.LockPickSet)
                Console.WriteLine(TextLocation.LockPickWontWork);
            _userInput.DramaticPauseClrScreen();
            return ""; // if you tried a tool that doesn't work you need to loop again
        }

        return item;
    }

    public void ApproachOpenDoor()
    {
        Console.WriteLine(TextLocation.OpenDoor); //approach door
        _userInput.DramaticPauseClrScreen();
    }

    public bool AttemptStoneOnDoor(Characters cat)
    {
        return userInteractionLockedRoom.UseStoneOnDoor(cat);
    }

    public bool AttemptShieldOnDoor(Characters cat, string item, Inventory inventory)
    {
        return userInteractionLockedRoom.UseShieldOnDoor(cat, item, inventory);
    }

    #endregion
}