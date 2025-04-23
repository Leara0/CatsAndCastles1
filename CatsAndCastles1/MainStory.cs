using CatsAndCastles1.Characters;
using CatsAndCastles1.GameTreeSwitchBoards;
using CatsAndCastles1.Lists;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.OldPartsOfTheGame;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1;

public class MainStory
{
    private readonly UserInput _userInput = new UserInput();

    //LocationsLists LocationsLists = new LocationsLists();
    UIInventory userInteractBK = new UIInventory();

    public void RunGame()
    {
        #region instantiating Classes

        #region Character Class Instantiation

        var cat = new Hero();
        {
            cat.Health = 60;
            cat.MaxHealth = cat.Health;
            cat.Location = Hero.Place.MainRoom;
        }

        var backPackMethod = new Inventory();
        {
            backPackMethod.Pack = new List<string>(); // creates a new pack 
            backPackMethod.DiscardedItems = new List<string>(); // create a record of all items that have been discarded
        }

        var guardDog1 = new BadGuy
        (
            GuardLists.Guard1Wording,
            ItemsAtLocationsList.Guard1Items,
            ItemsAtLocationsList.Guard1Description,
            "guard dog"
        );
        {
            guardDog1.Health = guardDog1.SetHealth(25, 35);
            guardDog1.MaxHealth = guardDog1.Health;
        }
        var guardDog2 = new BadGuy
        (
            GuardLists.Guard2Wording,
            ItemsAtLocationsList.Guard2Items,
            ItemsAtLocationsList.Guard2Description,
            "guard dog"
        );
        {
            guardDog2.Health = guardDog2.SetHealth(25, 35);
            guardDog2.MaxHealth = guardDog2.Health;
        }
        var warden = new BadGuy
        (
            GuardLists.WardenWording,
            ItemsAtLocationsList.WardenItems,
            ItemsAtLocationsList.WardenDescription,
            "warden"
        );
        {
            warden.Health = warden.SetHealth(60, 75);
            warden.MaxHealth = warden.Health;
        }

        #endregion

        #region MainRoom Location Class Instantiation

        Location mainRoom = new Location
        (
            Text.StartInRoom,
            Text.FirstRoomChoices,
            OptionsAtLocationsList.MainRoomChoices
        );
        ItemsLocation closet = new ItemsLocation
        (
            Text.ExploreCloset,
            ItemsAtLocationsList.ClosetItems,
            ItemsAtLocationsList.ClosetDescription
        );
        ItemsLocation nightstand = new ItemsLocation
        (
            Text.ExploreNightStand,
            ItemsAtLocationsList.NightStandItems,
            ItemsAtLocationsList.NightStandDescription
        );
        ItemsLocation bookshelf = new ItemsLocation
        (
            Text.ExploreBookshelf,
            ItemsAtLocationsList.BookshelfItems,
            ItemsAtLocationsList.BookshelfDescription
        );
        ItemsLocation hearth = new ItemsLocation
        (
            Text.ExploreHearth,
            ItemsAtLocationsList.HearthItems,
            ItemsAtLocationsList.HearthDescription
        );
        LockedLocations mainDoor =
            new LockedLocations
            (
                Text.ApproachDoor,
                LockPickingToolsList.UnHelpfulKeys
            );
        WindowLocation window = new WindowLocation
        (
            Text.ExploreWindow,
            LockPickingToolsList.AllPossibleOptions,
            LockPickingToolsList.WindowNeedsRope
        );

        #endregion

        #region ThirdFloor Location Class Instantiation

        Location thirdFloor = new Location
        (
            Text.ThirdFloorEntrance,
            Text.ThirdFloorTreeHeading,
            OptionsAtLocationsList.ThirdFloorChoices
        );
        LockedLocations studyF3D2 = new LockedLocations
        (
            Text.ApproachDoor,
            Text.ExploreStudyF3D2,
            LockPickingToolsList.UnHelpfulLockPick,
            ItemsAtLocationsList.StudyF3D2Items,
            ItemsAtLocationsList.StudyF3D2Description
        );
        LockedLocations bedroomF3D3 = new LockedLocations
        (
            Text.ApproachDoor,
            Text.ExploreBedroomF3D3,
            LockPickingToolsList.UnHelpfulKeys,
            ItemsAtLocationsList.BedroomF3D3Items,
            ItemsAtLocationsList.BedroomF3D3Description
        );
        bedroomF3D3.ChangeDoorLockStatus(true);
        LockedLocations closetF3D4 = new LockedLocations
        (
            Text.ApproachDoor,
            Text.ExploreClosetF3D4,
            LockPickingToolsList.UnHelpfulNothing,
            ItemsAtLocationsList.ClosetF3D4Items,
            ItemsAtLocationsList.ClosetF3D4Description
        );

        #endregion

        # region SecondFloor Location Class Instantiation

        Location secondFloor = new Location
        (
            Text.SecondFloorEntrance,
            Text.SecondFloorTreeHeading,
            OptionsAtLocationsList.SecondFloorChoices 
            );
        LockedLocations meetingRoomF2D1 = new LockedLocations
        (
            Text.ApproachDoor, Text.ExploreMeetingRoomF2R1,
            LockPickingToolsList.UnHelpfulLockPick, 
            ItemsAtLocationsList.MeetingRoomF2R1Items,
            ItemsAtLocationsList.MeetingRoomF2R1Description
            );
        LockedLocations guardQuartersF2D2 = new LockedLocations
        (
            Text.ApproachDoor, 
            Text.ExploreGuardRoomF2R2,
            LockPickingToolsList.UnHelpfulNothing, 
            ItemsAtLocationsList.GuardRoomF2R2Items,
            ItemsAtLocationsList.GuardRoomF2R2Description
            );
        guardQuartersF2D2.ChangeDoorLockStatus(true);
        LockedLocations closetF2R3 = new LockedLocations
        (
            Text.ApproachDoor, 
            Text.ExploreClosetF2R3,
            LockPickingToolsList.UnHelpfulNothing, 
            ItemsAtLocationsList.ClosetF2R3Items,
            ItemsAtLocationsList.ClosetF2R3Description
            );
        LockedLocations libraryF2R4 = new LockedLocations
        (
            Text.ApproachDoor, 
            Text.ExploreLibraryF2R4,
            LockPickingToolsList.UnHelpfulLockPick, 
            ItemsAtLocationsList.LibraryF2R4Items,
            ItemsAtLocationsList.LibraryF2R4Description
            );

        #endregion

        #region Decision Trees

        MainRoomGameTree mainRoomGameTree = new MainRoomGameTree();
        ThirdFloorTree thirdFloorTree = new ThirdFloorTree();
        SecondFloorTree secondFloorTree = new SecondFloorTree();

        #endregion

        #endregion


        IntroFluff introFluff = new IntroFluff();
        introFluff.IntroCutScene();
        mainRoom.PrintIntro();
        //TODO put the tree for the castle here!
        do
        {
            switch (cat.Location)
            {
                case Hero.Place.MainRoom:
                    mainRoomGameTree.MainRoomSwitchboard(backPackMethod, cat, mainRoom, closet, nightstand, bookshelf,
                        hearth, mainDoor, window);
                    break;
                case Hero.Place.ThirdFloor:
                    thirdFloorTree.ThirdFloorSwitchboard(backPackMethod, cat, guardDog1, thirdFloor, studyF3D2, bedroomF3D3,
                        closetF3D4);
                    break;
                case Hero.Place.SecondFloor:
                    secondFloorTree.SecondFloorSwitchboard(backPackMethod, cat, guardDog2, secondFloor, meetingRoomF2D1,
                        guardQuartersF2D2, closetF2R3, libraryF2R4);
                    break;
                case Hero.Place.FirstFloor:
                    Screen.Print(
                        "Congrats on making it to the first floor. It's not built yet so you get to start over!");
                    Console.ReadLine();
                    cat.Location = Hero.Place.MainRoom;
                    break;
                case Hero.Place.OutsideCastle:
                    break;
            }
        } while (true); //@TODO CHange this!! Or maybe not and just end game with Environment.Exit(0);


        //CastleWithExitStrategies(cat, backPackMethod, mainRoom, guardDog1, guardDog2, warden);

        DeadEnding(cat);
        // you end up here if you fall out of the exit strategies loop - ie if you
        // die and choose not to escape
    }

    private void DeadEnding(Hero cat)
    {
        if (cat.Location == Hero.Place.Dead)
            Screen.Print("\nAs the darkness takes hold, a strange sense of peace washes over you. " +
                         "The struggle, the fear, the desperate clawing for survival — it all fades into " +
                         "nothingness.\n\nThe castle will remain, its cold stone walls holding secrets " +
                         "you will never uncover. The paths you might have taken, the dangers you might " +
                         "have bested, all slip away like mist in the morning sun." +
                         "\n\nPerhaps you were never meant to escape." +
                         "\n\nAnd so, the little explorer’s journey comes to an end." +
                         "\n\nGame Over.");
    }


    /*private void CastleWithExitStrategies(Hero cat, BackPack backPack, Character guardDog1,
        Character guardDog2, Character warden)
    {
        do // you get here after you come to the end of one of the main room story lines
        {
            switch (cat.Location)
            {
                case Hero.Place.PassedOut: //@add something about taking health in main room
                    PassOut(cat, backPack);
                    break;
                case Hero.Place.ThirdFloor:
                    ThirdFloor thirdFloor = new ThirdFloor();
                    thirdFloor.ThirdFloorStory(cat, backPack, guardDog1);
                    break; //I put this in here so it just stops after you defeat the guard so the loop stops for ho
                case Hero.Place.SecondFloor:
                    SecondFloor secondFloor = new SecondFloor();
                    secondFloor.SecondFloorStory(cat, backPack, guardDog2);
                    break;
                case Hero.Place.FirstFloor:
                    FirstFloor firstFloor = new FirstFloor();
                    firstFloor.FirstFloorStory(cat, backPack, warden);
                    break;
                case Hero.Place.OutsideCastle:
                    OutsideCastle outside = new OutsideCastle();
                    outside.OutsideTheCastle(cat, backPack);
                    break;
            }
        } while
            (!cat.EndGame); //@fix change to while(cat.Status != Characters.State.Dead && cat.BonusStatus != Characters.BonusState.EscapedCastle)
    }*/


    private void PassOut(Hero cat, BackPack backPack)
    {
        //MainRoom mainRoom = new MainRoom(cat, backPack);
        cat.Lives--;

        Screen.Print(
            "\nThe pain is immediate and blinding, the world tilts around you, and darkness swallows you whole. " +
            "For a moment, there is nothing—no pain, no sound, no sense of time. " +
            "Then, a strange awareness creeps in. A feeling both familiar and deeply unsettling." +
            "\n\nCats have nine lives... but you suddenly realize this isn’t your first brush with death.");
        if (cat.Lives < 1)
        {
            Screen.Print("Nine lives, and you’ve spent them all. Shadows close in once more — but this time, " +
                         "there is no return.");
            cat.Location = Hero.Place.Dead;
            cat.EndGame = true;
            return;
        }


        Screen.Print(
            $"You’ve already lost {9 - cat.Lives}. That leaves only {cat.Lives} more chances. {cat.Lives} more lives " +
            $"to escape this cursed castle before the darkness takes you for good.");
        if (cat.LostToGuard)
        {
            Screen.Print("\nIf you choose to return, the guard will still bear the wounds you inflicted. " +
                         "They will not regain his strength.");
        }

        Screen.Print($"\nA choice stands before you:" +
                     $"\n\n1. Revive in the room you first woke in and try again to escape." +
                     $"\n2. Accept defeat and let the darkness claim you. (End Game.)" +
                     $"\n\nWhat will you do?... \n");
        if (_userInput.UserChoice() == "1")
        {
            //mainRoom.SubsequentWakeUp();
        }
        else
        {
            cat.Location = Hero.Place.Dead;
            cat.EndGame = true;
        }
    }
}