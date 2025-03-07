namespace CatsAndCastles1;

//@fix - questions for deep improvements
//question about enums that can take strings
//I have a LONG list of items that can be found in each room and I'd rather they not all be strings.
//I want to make them variables but I don't really want to declare that many variables

//I also want to be able to reuse item names but my system for tracking if an item has been taken from a
//particular location is to record the specific name
//otherwise I'd need a different system to track if every object number from each location has been picked
//up
public class MainStory
{
    private readonly UserInput _userInput = new UserInput();
    LocationDescriptions locationDescriptions = new LocationDescriptions();
    UserInteractionsBackpack userInteractBK = new UserInteractionsBackpack();
    

    public void RunGame()
    {
        var cat = new Characters();
        {
            cat.Name = _userInput.GetName();
            cat.Health = 60;
            cat.Location = Characters.Place.MainRoom;
        }
        //Setup the locations @TODO add the rest
        InteractWithLocation closet = new InteractWithLocation
            (LocationText.ExploreCloset, locationDescriptions.ClosetDescription, locationDescriptions.ClosetItems);
        InteractWithLocation nightStand = new InteractWithLocation
            (LocationText.ExploreNightStand, locationDescriptions.NightStandDescription, locationDescriptions.NightStandItems);
        InteractWithLocation bookshelf = new InteractWithLocation
            (LocationText.ExploreBookshelf, locationDescriptions.BookshelfDescription, locationDescriptions.BookshelfItems);


        var backPackMethod = new BackpackMethods();
        {
            backPackMethod.Pack = new List<string>(); // creates a new pack 
            backPackMethod.DiscardedItems = new List<string>(); // create a record of all items that have been discarded
        }

        var guardDog1 = new Characters();
        {
            guardDog1.Location = Characters.Place.ThirdFloor; // @fix is this later used???
            guardDog1.Health = guardDog1.SetHealth(25, 35);
        }
        var guardDog2 = new Characters();
        {
            guardDog2.Location = Characters.Place.SecondFloor;
            guardDog2.Health = guardDog2.SetHealth(25, 35);
        }
        var warden = new Characters();
        {
            warden.Location = Characters.Place.FirstFloor;
            warden.Health = warden.SetHealth(60, 75);
        }
        //var mainRoom = new MainRoom(cat, backPackMethod);

        closet.DisplayLocationInfo();
        closet.AddItemsToInventory(backPackMethod);
        closet.DisplayLocationInfo();
        closet.AddItemsToInventory(backPackMethod);

        
        //CastleWithExitStrategies(cat, backPackMethod, mainRoom, guardDog1, guardDog2, warden);


        // you end up here if you fall out of the exit strategies loop - ie if you
        // die and choose not to escape
        if (cat.Location == Characters.Place.Dead)
            Console.WriteLine("\nAs the darkness takes hold, a strange sense of peace washes over you. " +
                              "The struggle, the fear, the desperate clawing for survival — it all fades into " +
                              "nothingness.\n\nThe castle will remain, its cold stone walls holding secrets " +
                              "you will never uncover. The paths you might have taken, the dangers you might " +
                              "have bested, all slip away like mist in the morning sun." +
                              "\n\nPerhaps you were never meant to escape." +
                              "\n\nAnd so, the little explorer’s journey comes to an end." +
                              "\n\nGame Over.");
    }


    private void CastleWithExitStrategies(Characters cat, BackPack backPack, MainRoom mainRoom, Characters guardDog1,
        Characters guardDog2, Characters warden)
    {
        mainRoom.RunMainRoom();
        do // you get here after you come to the end of one of the main room story lines
        {
            switch (cat.Location)
            {
                case Characters.Place.PassedOut: //@add something about taking health in main room
                    PassOut(cat, backPack);
                    break;
                case Characters.Place.ThirdFloor:
                    ThirdFloor thirdFloor = new ThirdFloor();
                    thirdFloor.ThirdFloorStory(cat, backPack, guardDog1);
                    break; //I put this in here so it just stops after you defeat the guard so the loop stops for ho
                case Characters.Place.SecondFloor:
                    SecondFloor secondFloor = new SecondFloor();
                    secondFloor.SecondFloorStory(cat, backPack, guardDog2);
                    break;
                case Characters.Place.FirstFloor:
                    FirstFloor firstFloor = new FirstFloor();
                    firstFloor.FirstFloorStory(cat, backPack, warden);
                    break;
                case Characters.Place.OutsideCastle:
                    OutsideCastle outside = new OutsideCastle();
                    outside.OutsideTheCastle(cat, backPack);
                    break;
            }
        } while
            (!cat.EndGame); //@fix change to while(cat.Status != Characters.State.Dead && cat.BonusStatus != Characters.BonusState.EscapedCastle)
    }


    private void PassOut(Characters cat, BackPack backPack)
    {
        MainRoom mainRoom = new MainRoom(cat, backPack);
        cat.Lives--;

        Console.WriteLine(
            "\nThe pain is immediate and blinding, the world tilts around you, and darkness swallows you whole. " +
            "For a moment, there is nothing—no pain, no sound, no sense of time. " +
            "Then, a strange awareness creeps in. A feeling both familiar and deeply unsettling." +
            "\n\nCats have nine lives... but you suddenly realize this isn’t your first brush with death.");
        if (cat.Lives < 1)
        {
            Console.WriteLine("Nine lives, and you’ve spent them all. Shadows close in once more — but this time, " +
                              "there is no return.");
            cat.Location = Characters.Place.Dead;
            cat.EndGame = true;
            return;
        }


        Console.WriteLine(
            $"You’ve already lost {9 - cat.Lives}. That leaves only {cat.Lives} more chances. {cat.Lives} more lives " +
            $"to escape this cursed castle before the darkness takes you for good.");
        if (cat.LostToGuard)
        {
            Console.WriteLine("\nIf you choose to return, the guard will still bear the wounds you inflicted. " +
                              "They will not regain his strength.");
        }

        Console.WriteLine($"\nA choice stands before you:" +
                          $"\n\n1. Revive in the room you first woke in and try again to escape." +
                          $"\n2. Accept defeat and let the darkness claim you. (End Game.)" +
                          $"\n\nWhat will you do?... \n");
        if (_userInput.UserChoice() == "1")
        {
            mainRoom.SubsequentWakeUp();
        }
        else
        {
            cat.Location = Characters.Place.Dead;
            cat.EndGame = true;
        }
    }
}