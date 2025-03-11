namespace CatsAndCastles1;

public class ThirdFloor()
{
    private readonly UserInput _userInput = new UserInput();
    private readonly Fight fight = new Fight();
   public void ThirdFloorStory(Characters cat, BackPack backPack, Characters guardDog1)
   {
       //MainRoom mainRoom = new MainRoom(cat, backPack);
       cat.SuccessfulBribed = false;

       Console.Clear();
       Console.WriteLine(TextLocation.ThirdFloorEntrance);


       if (guardDog1.Location != Characters.Place.Dead && !cat.SuccessfulBribed)
       {
           // if the guard is not dead & not bribed you must deal with him
           fight.GuardDogEncounter(cat, backPack, guardDog1, 0);
           if (cat.Location == Characters.Place.SecondFloor || cat.Location == Characters.Place.PassedOut)
               //// if you successfully run away (to floor 2) or get knocked out
               return;
          
           Console.WriteLine(TextLocation.DealtWithGuard);
          
       }


       do
       {
           Console.WriteLine(TextLocation.ThirdFloorTreeHeading);
           Console.WriteLine("\nPlease make a selection:" +
                             "\n'1' - Return to the room from whence you came. You now see the door is marked 1" +
                             "\n'2' - Approach a large worn door, marked with the number 2." +
                             "\n'3' - Approach the door that is standing ajar, marked with a 3." +
                             "\n'4' - Approach the room at the end of the hallway, marked with a faded 4." +
                             "\n'5' - Head down the spiral staircase." +
                             "\n'6' - Access your inventory");
           if (guardDog1.Location == Characters.Place.Dead)
               Console.WriteLine("'7' - Revisit the guard's body to loot anything you missed");
           switch (_userInput.UserChoice(7))
           {
               case "1":
                   Console.WriteLine("You turn back toward the door you first escaped from, the worn wood familiar " +
                                     "beneath your paws. Pushing it open, you step inside once more. The room is " +
                                     "just as you left it — dim, old, and eerily silent.\n");
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
                   Console.WriteLine("You feel you’ve explored enough for now. The stairway at the end of the hall " +
                                     "beckons, offering the chance to move closer to freedom. " +
                                     "\n\nWith a soft sigh, you make your way to the stairs, each step taking you " +
                                     "closer to your goal. This floor fades into the shadows behind you as you " +
                                     "descend, the stairwell opens up to new, uncertain territory.");
                   Console.WriteLine("\nPress 'enter' to continue...");
                   Console.ReadLine();
                   Console.Clear();
                   cat.Location = Characters.Place.SecondFloor;
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
                   if (guardDog1.Location == Characters.Place.Dead)
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


   void EnterRoom(Characters cat, BackPack backPack, string room)
   {
       DescriptionOfItems(room);
       Console.WriteLine("\n Do you want to take any of these items with you? Press '1' to take items and '2' " +
                         "to leave the room");
       if (_userInput.UserChoice() == "1")
           backPack.TakeItems(cat, room);
       Console.WriteLine("Feeling finished with this room, you step back into the hallway. ");
   }


   void DescriptionOfItems(string room)
   {
       switch (room)
       {
           case "third floor room 2":
               Console.WriteLine($"You step toward the room marked '2', its worn surface showing " +
                                 $"signs of age but no immediate hints of what lies beyond. The handle is cool beneath " +
                                 $"your paw, the door resisting slightly as you press against it." +
                                 $"\n\n You step inside, the dim light revealing a sparse but " +
                                 "functional room. Dust lingers in the air, undisturbed." +
                                 "\n\nYour eyes scan the space. On the nightstand, you spot a long dagger resting beside a " +
                                 "small pile of 13 gold coins. Across the room, an open closet reveals a single set of bedsheets " +
                                 "on a shelf.");
               break;
           case "third floor room 3":
               Console.WriteLine("You step toward the ajar door, nudging it open with caution. The room beyond is " +
                                 "dim, the air carrying a faint, unfamiliar scent. As you scan your surroundings, " +
                                 "a few things catch your eye.\n\nOn a small table, you find a small glass vial " +
                                 "filled with a shimmering liquid. You don’t know exactly what it does, but something " +
                                 "about it feels... good. Beside it, you spot 12 gold coins stacked neatly and a " +
                                 "collar with a bell – meant for a cat? but why is it here?.");
               break;
           case "third floor room 4":
               // can't get in here in floor 3
               break;
       }
   }


   void LootBody(Characters cat, BackPack backPack, Characters guardDog)
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

