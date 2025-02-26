namespace CatsAndCastles1;


public class SecondFloor
{
   //@fix readjust all this to be the second floor!!!


   public void SecondFloorStory(Characters cat, BackPack backPack, Characters guardDog)
   {
       cat.SuccessfulBribed = false;


       Console.WriteLine("You reach the second floor, your paws light against the cold stone. The hallway " +
                         "stretches before you, nearly identical to the one above. Four doors line the hallway, " +
                         "each one marked with a number — just like on the previous floor." +
                         "\n\nYou feel lucky that there’s no guard patrolling here, but the absence is strange. " +
                         "Why is this hall unguarded? What makes it different? The silence presses in, thick with " +
                         "dust and mystery.");




       do
       {
           Console.WriteLine("Your tail flicks as you consider your options.?");
           Console.WriteLine("\nPlease make a selection:" +
                             "\n'1' - A sturdy and solid door, its frame slightly warped with age" +
                             "\n'2' - A heavy, reinforced, with deep scratches marring the bottom edge. " +
                             "The number appears to have fallen or been torn off but the un-aged wood shows it was a 2" +
                             "\n'3' - A plain wooden door marked 3, the door is unremarkable but intact." +
                             "\n'4' - The smallest of the four doors, marked 4. A faint scent of something unfamiliar " +
                             "wafting from the barely open door." +
                             "\n'5' - Continue down the stairs, drawing ever closer to the castle’s lower " +
                             "levels — and possibly, your escape." +
                             "\n'6' - If doubt gnaws at you, you could  turn back and return upstairs, " +
                             "retracing your steps to see if there's anything you've overlooked." +
                             "\n'7' - Access your inventory;");
           switch (backPack.UserChoice(7))
           {
               case "1": // need keys or lock pick to get in here
                   Console.WriteLine("You approach Door 1 and test the handle — it's locked.");
                   if (backPack.Pack.Contains("the ring of keys") || backPack.Pack.Contains("the rusted set of tools"))
                       EnterRoom(cat, backPack, "second floor room 1");
                   else
                       Console.WriteLine(
                           "You check your pack, hoping for something useful, but you don’t have any keys. " +
                           "nor do you have the lock pick kit." +
                           "\n\nWith no way inside, you step back into the hall.");
                   break;
               case "2": //can't get in here
                   Console.WriteLine("You approach another door and test the handle—it doesn't budge. Locked." +
                                     "\n\nReaching into your pack, you retrieve the rusted set of tools and " +
                                     "attempt to pick the lock. The metal clicks and shifts, but no matter " +
                                     "how carefully you work, the mechanism refuses to give. This door isn't " +
                                     $"opening—not with the tools you have now. " +
                                     $"{(backPack.Pack.Contains("the ring of keys") ? "You try the keys you got from " +
                                         "the guard but none work" : "")}" +
                                     "\n\nWith no other choice, you step back into the hallway. What will you do next?");
                   Console.WriteLine("\nPress 'enter' to continue...");
                   Console.ReadLine();
                   Console.Clear();
                   break;
               case "3": //need keys
                   Console.WriteLine("You stand in the hall, eyeing Door 3. Testing the handle—locked.");
                   if (backPack.Pack.Contains("the ring of keys"))
                       EnterRoom(cat, backPack, "second floor room 3");
                   else
                       Console.WriteLine(
                           "You check your pack, hoping for something useful, but you don’t have any keys. " +
                           "Your lock pick kit is of no use here, the mechanism refusing to budge." +
                           "\n\nWith no way inside, you step back into the hall.");
                   break;
               case "4": //guard dog
                   Room4(cat, backPack, guardDog);
                   if (cat.Location == Characters.Place.PassedOut)
                       return;
                   break;
               case "5": // go downstairs
                   Console.WriteLine("Standing in the hallway, you glance at the doors. " +
                                     "You feel you’ve explored enough for now. The stairway at the end of the " +
                                     "hall beckons, offering the chance to move closer to freedom." +
                                     "\n\nWith a flick of your tail, you head toward the stairs, leaving this" +
                                     " floor behind as you descend into the unknown.");
                   Console.WriteLine("Press 'enter' to continue...");
                   Console.ReadLine();
                   cat.SuccessfulBribed = false;
                   cat.Location = Characters.Place.FirstFloor;
                   Console.Clear();
                   return;
               case "6":
                   Console.WriteLine("You turn and head back toward the stairs, making your way up. You feel there" +
                                     "must be something you missed and are eager to retrace your steps.");
                   cat.SuccessfulBribed = false;
                   cat.Location = Characters.Place.ThirdFloor;
                   Console.WriteLine("Press 'enter' to continue...");
                   Console.ReadLine();
                   Console.Clear();
                   return;
               case "7":
                   backPack.ListContentsOfPack();
                   Console.WriteLine("Would you like to use or remove any items?" +
                                     "\nPlease press '1' to use or remove an item and '2' to continue exploring the room");
                   while (backPack.UserChoice() == "1")
                   {
                       backPack.RemoveItemsFromPack(cat);
                       backPack.ListContentsOfPack();
                       Console.WriteLine("Would you like to use or remove another item?" +
                                         "\nPress '1' to use or remove another item and '2' to continue exploring the room");
                   }


                   Console.WriteLine(
                       "After a quick assessment, you tuck your things back into your pack. The choices" +
                       "once again lay before you.");
                   break;
           }
       } while (true); // keeps going until the cat goes upstairs, downstairs or passes out
   }


   public void EnterRoom(Characters cat, BackPack backPack, string room)
   {
       DescriptionOfItems(room, backPack);
       Console.WriteLine("\nDo you want to take any of these items with you? Press '1' to take items and '2' " +
                         "to leave the room");
       if (backPack.UserChoice() == "1")
           backPack.TakeItems(cat, room);
       Console.WriteLine("Feeling finished with this room, you step back into the hallway.");
   }


   public void DescriptionOfItems(string room, BackPack backPack = null)
   {
       switch (room)
       {
           case "second floor room 1":
               Console.WriteLine($"\nFortunately, you remember the {(backPack.Pack.Contains("the ring of keys") ?
                   "keys you took from the guard" : "rusty set of tools in your pack")}. You fish them out of " +
                                 $"your pack and try one after another until—click. The door swings open." +
                                 $"\n\nInside, the room is dim and sparse, but a few items catch your eye:" +
                                 $"\n\nA small stone canine state." +
                                 $"\nA small elixir, while its contents are unknown, you have a good feeling about it." +
                                 $"\nA shield, propped against the far wall.");


               break;
           case "second floor room 3": //need keys
               Console.WriteLine("Fortunately, you remember the keys you took from the guard. " +
                                 "You fish them out of your pack and try one after another until—click. " +
                                 "The door swings open." +
                                 "\n\nInside, the space is sparse, likely unused for some time. Dust clings to the " +
                                 "surfaces, disturbed only by the faintest signs of past movement. Your eyes scan " +
                                 "the room, and among the gloom, you spot a few items that might be of use:" +
                                 "\n\nFour sets of sheets, neatly folded and stacked against the wall." +
                                 "\nA small pile of gold coins, glinting faintly in the low light." +
                                 "\nA mysterious elixir, sealed in a simple glass vial. Whatever it does, " +
                                 "you can’t be sure, but you have a good feeling about it." +
                                 "\n\nYou flick your tail, considering. ");
               break;
           case "second floor room 4":
               // can't get in here in floor 3
               break;
       }
   }


   void LootBody(Characters cat, BackPack backPack, Characters guardDog)
   {
       Console.WriteLine("\nYou see the body of the guard you dispatched and take a moment to search it, uncovering:");


       backPack.AssignItemsBasedOnLocation("guard two", guardDog);
       for (int i = 0; i < backPack.Options.Length; i++)
       {
           if (backPack.ListOfAllItemsPickedUp.Contains(backPack.Options[i]))
               backPack.Descriptions[i] = backPack.emptySpot;
           Console.WriteLine($"- {backPack.Descriptions[i]}");
       }


       Console.WriteLine("Press '1' to loot and '2' to move on.");
       if (backPack.UserChoice() == "1")
       {
           backPack.TakeItems(cat, "guard two", guardDog);
       }


       Console.WriteLine("You leave the corpse\n\n.");
   }


   void Room4(Characters cat, BackPack backPack, Characters guardDog)
   {
       if (guardDog.Location != Characters.Place.Dead && !cat.SuccessfulBribed)
           //if you haven't defeated or bribed the guard yet
       {
           Fight.GuardDogEncounter(cat, backPack, guardDog, 1);
           if ((guardDog.Location != Characters.Place.Dead && !cat.SuccessfulBribed) ||
               cat.Location ==
               Characters.Place.PassedOut) // if you successfully run away or get knocked out leave this room
               return;
       }


       Console.WriteLine("The room is dimly lit by a flickering candle mounted on a crumbling wall. " +
                         "Amidst scattered debris and a few signs of hurried movement, you spot several " +
                         "items that seem to have been left behind in the chaos:" +
                         "\n\nA 20-foot length of rope, coiled neatly in one corner, its fibers " +
                         "surprisingly sturdy." +
                         "\nA health elixir, its glass vial containing a shimmering liquid that " +
                         "promises to mend wounds." +
                         "\nA short sword, its blade modest but sharp, glinting in the low light — " +
                         "a weapon that could serve you well.");
       if (guardDog.Location == Characters.Place.Dead)
           Console.WriteLine("The guard’s fallen form lies nearby, a silent testament to the battle " +
                             "you just fought.");
      
       var stayInRoom = true;
       do
       {
           Console.WriteLine(
               "The items in room 4 lie around you, you sense that they might be the keys to " +
               "surviving what lies ahead...");
           Console.Write("\nPlease make a choice:" +
                         "\nPress '1' if you'd like to take some items from this room with you." +
                         "Press '2' if you'd like to return to the hall.");
           if (guardDog.Location == Characters.Place.Dead)
               Console.WriteLine(
                   "Press '3' if you'd like to return to the guard's body to see if you missed " +
                   "anything");
          
           switch (backPack.UserChoice(3))
           {
               case "1":
                   backPack.TakeItems(cat, "second floor room 4");
                   Console.WriteLine("You've taken what you like from this room for now. You head towards the door " +
                                     "but take another look around.");
                   break;
               case "2":
                   stayInRoom = false;
                   break;
               case "3":
                   if (guardDog.Location == Characters.Place.Dead)
                       LootBody(cat, backPack, guardDog);
                   else
                       Console.WriteLine("That is not a valid selection.");
                   break;
           }
       } while (stayInRoom);
       Console.WriteLine("Feeling done with this room you return to the hall");
   }
}

