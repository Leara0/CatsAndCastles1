namespace CatsAndCastles1;

public class MainStory
{
    private readonly UserInput _userInput = new UserInput();
    LocationsLists _locationsLists = new LocationsLists();
    UIInventory userInteractBK = new UIInventory();
    
    public void RunGame()
    {
        #region instantiating Classes
        #region Character Class Instantiation
        var cat = new MainCharacter();
        {
            cat.Health = 60;
            cat.Location = MainCharacter.Place.MainRoom;
        }

        var backPackMethod = new Inventory();
        {
            backPackMethod.Pack = new List<string>(); // creates a new pack 
            backPackMethod.DiscardedItems = new List<string>(); // create a record of all items that have been discarded
        }

        var guardDog1 = new Character();
        {
            guardDog1.Health = guardDog1.SetHealth(25, 35);
        }
        var guardDog2 = new Character();
        {
            guardDog2.Health = guardDog2.SetHealth(25, 35);
        }
        var warden = new Character();
        {
            warden.Health = warden.SetHealth(60, 75);
        }
        #endregion
        
        #region MainRoom Location Class Instantiation
        Location mainRoom = new Location(Text.StartInRoom, Text.FirstRoomChoices, 
            _locationsLists.MainRoomChoices);
        ItemsLocation closet = new ItemsLocation
            (Text.ExploreCloset, _locationsLists.ClosetItems, _locationsLists.ClosetDescription);
        ItemsLocation nightstand = new ItemsLocation
            (Text.ExploreNightStand, _locationsLists.NightStandItems, _locationsLists.NightStandDescription);
        ItemsLocation bookshelf = new ItemsLocation
            (Text.ExploreBookshelf, _locationsLists.BookshelfItems, _locationsLists.BookshelfDescription);
        ItemsLocation hearth = new ItemsLocation
            (Text.ExploreHearth, _locationsLists.HearthItems, _locationsLists.HearthDescription);
        LockedLocations mainDoor =
            new LockedLocations(Text.ApproachDoor, LockedPlacesLists.UnHelpfulKeys);
        WindowLocation window = new WindowLocation(Text.ExploreWindow, 
            LockedPlacesLists.AllPossibleOptions, LockedPlacesLists.WindowNeedsRope);
        #endregion
        
        #region ThirdFloor Location Class Instantiation
        Location thirdFloor = new Location(Text.ThirdFloorEntrance, 
            Text.ThirdFloorTreeHeading, _locationsLists.ThirdFloorChoices);
        //DerivedLockedLocations floor3Door2 =
            new LockedLocations(Text.ApproachDoor, LockedPlacesLists.UnHelpfulLockPick);
        
        
        
        #endregion
        
        #endregion
        IntroFluff introFluff = new IntroFluff();
        GameTree gameTree = new GameTree();
        introFluff.IntroCutScene();
        gameTree.MainRoomSwitchboard(backPackMethod, cat, mainRoom, closet, nightstand, bookshelf, hearth, mainDoor, window);

        //CastleWithExitStrategies(cat, backPackMethod, mainRoom, guardDog1, guardDog2, warden);

        DeadEnding(cat);
        // you end up here if you fall out of the exit strategies loop - ie if you
        // die and choose not to escape
    }

    private void DeadEnding(MainCharacter cat)
    {
        if (cat.Location == MainCharacter.Place.Dead)
            Console.WriteLine("\nAs the darkness takes hold, a strange sense of peace washes over you. " +
                              "The struggle, the fear, the desperate clawing for survival — it all fades into " +
                              "nothingness.\n\nThe castle will remain, its cold stone walls holding secrets " +
                              "you will never uncover. The paths you might have taken, the dangers you might " +
                              "have bested, all slip away like mist in the morning sun." +
                              "\n\nPerhaps you were never meant to escape." +
                              "\n\nAnd so, the little explorer’s journey comes to an end." +
                              "\n\nGame Over.");
    }


    private void CastleWithExitStrategies(MainCharacter cat, BackPack backPack, Character guardDog1,
        Character guardDog2, Character warden)
    {
        do // you get here after you come to the end of one of the main room story lines
        {
            switch (cat.Location)
            {
                case MainCharacter.Place.PassedOut: //@add something about taking health in main room
                    PassOut(cat, backPack);
                    break;
                case MainCharacter.Place.ThirdFloor:
                    ThirdFloor thirdFloor = new ThirdFloor();
                    thirdFloor.ThirdFloorStory(cat, backPack, guardDog1);
                    break; //I put this in here so it just stops after you defeat the guard so the loop stops for ho
                case MainCharacter.Place.SecondFloor:
                    SecondFloor secondFloor = new SecondFloor();
                    secondFloor.SecondFloorStory(cat, backPack, guardDog2);
                    break;
                case MainCharacter.Place.FirstFloor:
                    FirstFloor firstFloor = new FirstFloor();
                    firstFloor.FirstFloorStory(cat, backPack, warden);
                    break;
                case MainCharacter.Place.OutsideCastle:
                    OutsideCastle outside = new OutsideCastle();
                    outside.OutsideTheCastle(cat, backPack);
                    break;
            }
        } while
            (!cat.EndGame); //@fix change to while(cat.Status != Characters.State.Dead && cat.BonusStatus != Characters.BonusState.EscapedCastle)
    }


    private void PassOut(MainCharacter cat, BackPack backPack)
    {
        //MainRoom mainRoom = new MainRoom(cat, backPack);
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
            cat.Location = MainCharacter.Place.Dead;
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
            //mainRoom.SubsequentWakeUp();
        }
        else
        {
            cat.Location = MainCharacter.Place.Dead;
            cat.EndGame = true;
        }
    }
}