using CatsAndCastles1.Characters;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.Text.Locations;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.OldPartsOfTheGame;

public class ThirdFloor()
{
    private readonly UserInput _userInput = new UserInput();
    private readonly OldFight _oldFight = new OldFight();
   public void ThirdFloorStory(Hero cat, BackPack backPack, Character guardDog1)
   {
       //MainRoom mainRoom = new MainRoom(cat, backPack);
       cat.SuccessfulBribed = false;

       Console.Clear();
       Screen.Print(TextThirdFloor.ThirdFloorEntrance);


       if (!guardDog1.IsDead && !cat.SuccessfulBribed)
       {
           // if the guard is not dead & not bribed you must deal with him
           _oldFight.GuardDogEncounter(cat, backPack, guardDog1, 0);
           if (cat.Location == Hero.Place.SecondFloor || cat.Location == Hero.Place.PassedOut)
               //// if you successfully run away (to floor 2) or get knocked out
               return;
          
           Screen.Print(TextGuard.DealtWithGuard);
          
       }


       do
       {
           Screen.Print(TextThirdFloor.ThirdFloorTreeHeading);
           Screen.Print("\nPlease make a selection:" +
                             "\n'1' - " +
                             "\n'2' - " +
                             "\n'3' - " +
                             "\n'4' - " +
                             "\n'5' - " +
                             "\n'6' - Access your inventory");
           if (guardDog1.IsDead)
               Screen.Print("'7' - Revisit the guard's body to loot anything you missed");
           switch (_userInput.UserChoice(7))
           {
               case "1":
                   Screen.Print(TextThirdFloor.ReEnterMainRoom);
                   //mainRoom.MainRoomMethod();
                   return;
               case "2":
                   EnterRoom(cat, backPack, "third floor room 2");
                   break;
               case "3":
                   EnterRoom(cat, backPack, "third floor room 3");
                   break;
               case "4": //@add everyone wants to be able to get into all the doors!
                   Screen.Print("You approach another door and test the handle—it doesn't budge. Locked.");
                   if (backPack.Pack.Contains("the ring of keys"))
                       Screen.Print("You try the keys you got from the guard but none work.\"");
                   if (backPack.Pack.Contains("the rusted set of tools"))
                       Screen.Print("n\nReaching into your pack, you retrieve the rusted set of tools and " +
                                         "attempt to pick the lock. The metal clicks and shifts, but no matter " +
                                         "how carefully you work, the mechanism refuses to give. These tools will not be" +
                                         "helping you get this door open.");
                   Screen.Print("With no other choice, you step back into the hallway. What will you do next?");
                   break;


               case "5":
                   Screen.Print(TextGeneral.HeadDownStairs);
                   Screen.Print("\nPress 'enter' to continue...");
                   Console.ReadLine();
                   Console.Clear();
                   cat.Location = Hero.Place.SecondFloor;
                   return;
               case "6":
                   backPack.ListContentsOfPack();
                   Screen.Print("Would you like to use or remove any items?" +
                                     "\nPlease press '1' to use or remove an item and '2' to continue exploring the room");
                   while (_userInput.UserChoice() == "1")
                   {
                       backPack.RemoveItemsFromPack(cat);
                   }


                   Screen.Print(
                       "After a quick assessment, you tuck your things back into your pack. The choices" +
                       "once again lay before you.");
                   break;
               case "7":
                   if (guardDog1.IsDead)
                       LootBody(cat, backPack, guardDog1);
                   else
                   {
                       Screen.Print("I'm sorry, but that isn't a valid choice. ");
                       Screen.Print("Press 'enter' to continue...");
                       Console.ReadLine();
                       Console.Clear();
                   }


                   break;
           }
       } while (true); // this keeps going until the player goes back into the main room or down to floor 2
   }


   void EnterRoom(Hero cat, BackPack backPack, string room)
   {
       DescriptionOfItems(room);
       Screen.Print("\n Do you want to take any of these items with you? Press '1' to take items and '2' " +
                         "to leave the room");
       if (_userInput.UserChoice() == "1")
           backPack.TakeItems(cat, room);
       Screen.Print("");
   }


   void DescriptionOfItems(string room)
   {
       switch (room)
       {
           case "third floor room 2":
               Screen.Print("c");
               break;
           case "third floor room 3":
               Screen.Print("c");
               break;
           case "third floor room 4":
               // can't get in here in floor 3
               break;
       }
   }


   void LootBody(Hero cat, BackPack backPack, Character guardDog)
   {
       Screen.Print("\nYou return to the body and take a moment to search it, uncovering:");


       backPack.AssignItemsBasedOnLocation("guard one", guardDog);
       for (int i = 0; i < backPack.Options.Length; i++)
       {
           if (backPack.ListOfAllItemsPickedUp.Contains(backPack.Options[i]))
               backPack.Descriptions[i] = backPack.emptySpot;
           Screen.Print($"- {backPack.Descriptions[i]}");
       }


       Screen.Print("Press '1' to loot and '2' to move on.");
       if (_userInput.UserChoice() == "1")
       {
           backPack.TakeItems(cat, "guard one", guardDog);
       }


       Screen.Print("You leave the corpse\n\n.");
   }




   //** someday add in healing elixirs??
}

