namespace CatsAndCastles1;

public class ThirdFloor()
{
    private readonly UserInput _userInput = new UserInput();
    private readonly Fight fight = new Fight();
   public void ThirdFloorStory(MainCharacter cat, BackPack backPack, Character guardDog1)
   {
       //MainRoom mainRoom = new MainRoom(cat, backPack);
       cat.SuccessfulBribed = false;

       Console.Clear();
       Console.WriteLine(Text.ThirdFloorEntrance);


       if (!guardDog1.IsDead && !cat.SuccessfulBribed)
       {
           // if the guard is not dead & not bribed you must deal with him
           fight.GuardDogEncounter(cat, backPack, guardDog1, 0);
           if (cat.Location == MainCharacter.Place.SecondFloor || cat.Location == MainCharacter.Place.PassedOut)
               //// if you successfully run away (to floor 2) or get knocked out
               return;
          
           Console.WriteLine(Text.DealtWithGuard);
          
       }


       do
       {
           Console.WriteLine(Text.ThirdFloorTreeHeading);
           Console.WriteLine("\nPlease make a selection:" +
                             "\n'1' - " +
                             "\n'2' - " +
                             "\n'3' - " +
                             "\n'4' - " +
                             "\n'5' - " +
                             "\n'6' - Access your inventory");
           if (guardDog1.IsDead)
               Console.WriteLine("'7' - Revisit the guard's body to loot anything you missed");
           switch (_userInput.UserChoice(7))
           {
               case "1":
                   Console.WriteLine(Text.ReEnterMainRoom);
                   //mainRoom.MainRoomMethod();
                   return;
               case "2":
                   EnterRoom(cat, backPack, "third floor room 2");
                   break;
               case "3":
                   EnterRoom(cat, backPack, "third floor room 3");
                   break;
               case "4": //@add everyone wants to be able to get into all the doors!
                   Console.WriteLine("You approach another door and test the handle—it doesn't budge. Locked.");
                   if (backPack.Pack.Contains("the ring of keys"))
                       Console.WriteLine("You try the keys you got from the guard but none work.\"");
                   if (backPack.Pack.Contains("the rusted set of tools"))
                       Console.WriteLine("n\nReaching into your pack, you retrieve the rusted set of tools and " +
                                         "attempt to pick the lock. The metal clicks and shifts, but no matter " +
                                         "how carefully you work, the mechanism refuses to give. These tools will not be" +
                                         "helping you get this door open.");
                   Console.WriteLine("With no other choice, you step back into the hallway. What will you do next?");
                   break;


               case "5":
                   Console.WriteLine(Text.HeadDownStairs);
                   Console.WriteLine("\nPress 'enter' to continue...");
                   Console.ReadLine();
                   Console.Clear();
                   cat.Location = MainCharacter.Place.SecondFloor;
                   return;
               case "6":
                   backPack.ListContentsOfPack();
                   Console.WriteLine("Would you like to use or remove any items?" +
                                     "\nPlease press '1' to use or remove an item and '2' to continue exploring the room");
                   while (_userInput.UserChoice() == "1")
                   {
                       backPack.RemoveItemsFromPack(cat);
                   }


                   Console.WriteLine(
                       "After a quick assessment, you tuck your things back into your pack. The choices" +
                       "once again lay before you.");
                   break;
               case "7":
                   if (guardDog1.IsDead)
                       LootBody(cat, backPack, guardDog1);
                   else
                   {
                       Console.WriteLine("I'm sorry, but that isn't a valid choice. ");
                       Console.WriteLine("Press 'enter' to continue...");
                       Console.ReadLine();
                       Console.Clear();
                   }


                   break;
           }
       } while (true); // this keeps going until the player goes back into the main room or down to floor 2
   }


   void EnterRoom(MainCharacter cat, BackPack backPack, string room)
   {
       DescriptionOfItems(room);
       Console.WriteLine("\n Do you want to take any of these items with you? Press '1' to take items and '2' " +
                         "to leave the room");
       if (_userInput.UserChoice() == "1")
           backPack.TakeItems(cat, room);
       Console.WriteLine("");
   }


   void DescriptionOfItems(string room)
   {
       switch (room)
       {
           case "third floor room 2":
               Console.WriteLine();
               break;
           case "third floor room 3":
               Console.WriteLine();
               break;
           case "third floor room 4":
               // can't get in here in floor 3
               break;
       }
   }


   void LootBody(MainCharacter cat, BackPack backPack, Character guardDog)
   {
       Console.WriteLine("\nYou return to the body and take a moment to search it, uncovering:");


       backPack.AssignItemsBasedOnLocation("guard one", guardDog);
       for (int i = 0; i < backPack.Options.Length; i++)
       {
           if (backPack.ListOfAllItemsPickedUp.Contains(backPack.Options[i]))
               backPack.Descriptions[i] = backPack.emptySpot;
           Console.WriteLine($"- {backPack.Descriptions[i]}");
       }


       Console.WriteLine("Press '1' to loot and '2' to move on.");
       if (_userInput.UserChoice() == "1")
       {
           backPack.TakeItems(cat, "guard one", guardDog);
       }


       Console.WriteLine("You leave the corpse\n\n.");
   }




   //** someday add in healing elixirs??
}

