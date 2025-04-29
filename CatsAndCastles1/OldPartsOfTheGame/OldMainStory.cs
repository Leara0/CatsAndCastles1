using CatsAndCastles1.Characters;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.OldPartsOfTheGame;

public class OldMainStory
{
    //CastleWithExitStrategies(cat, backPackMethod, mainRoom, guardDog1, guardDog2, warden);

    //DeadEnding(instancesC.Cat);
    // you end up here if you fall out of the exit strategies loop - ie if you
    // die and choose not to escape
    private void DeadEnding(Hero cat)
    {
        //if (cat.Location == Hero.Place.Dead)
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
            //cat.Location = Hero.Place.Dead;
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
        var _userInput = new UserInput();
        if (_userInput.UserChoice() == "1")
        {
            //mainRoom.SubsequentWakeUp();
        }
        else
        {
            //cat.Location = Hero.Place.Dead;
            cat.EndGame = true;
        }
    }
}