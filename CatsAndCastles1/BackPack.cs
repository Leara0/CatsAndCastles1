namespace CatsAndCastles1;


public class BackPack
{
   public string emptySpot = "a faint outline marking the spot where something once rested";
   public string[] Pack { get; set; } = new string[5];
   public List<string> DiscardedItems { get; set; }


   public List<string>
       ListOfAllItemsPickedUp { get; set; } //use this to prevent player from picking up the same object multiple times


   public int Wallet { get; set; }


   public int NumberOfSheets { get; set; }
   //@add is it possible to make all possible items into an enum so I don't have to worry about string typos


   public string UserChoice(int numberOfOptions = 2)
   {
       do
       {
           string input = Console.ReadLine().Trim();
           for (int i = 1; i <= numberOfOptions; i++)
           {
               string iNumber = i.ToString();
               if (iNumber == input)
               {
                   Console.Clear();
                   return input;
               }
           }


           Console.WriteLine("I'm sorry, but that isn't a valid choice. ");
           Console.WriteLine("Please enter a number that corresponds with options above.");
       } while (true);
   }


   public int NumberOfItemsInPack() // counts how many items are in pack
   {
       var counter = 0;
       for (int i = 0; i < Pack.Length; i++)
       {
           if (Pack[i] != "empty")
           {
               counter++;
           }
       }


       return counter;
   }


   public void ListContentsOfPack()
   {
       Console.WriteLine("The contents of your pack are as follows:");
       for (int i = 0; i < Pack.Length; i++)
           Console.WriteLine($"  {i + 1} - {Pack[i]}");
   }




   public void PickUpItemsFromDiscarded(Characters cat)
   {
       Console.WriteLine("Your discarded stash contains the following item/s:");
       for (int i = 0; i < DiscardedItems.Count; i++)
       {
           Console.WriteLine($"{i + 1} - {DiscardedItems[i]}");
       }


       Console.WriteLine($"\nPlease type the number of the item you would like to pick up. " +
                         $"Or press {DiscardedItems.Count + 1} to return to exploring the room");


       int response = Convert.ToInt32(UserChoice(DiscardedItems.Count + 1));


       if (response < DiscardedItems.Count + 1)
       {
           AddItemToPack(cat, DiscardedItems[response - 1]);
           DiscardedItems.RemoveAt(response - 1);
       }
   }


   public bool RemoveItemsFromPack(Characters cat)
   {
       if (NumberOfItemsInPack() == 0)
       {
           Console.WriteLine("There are no items in your pack.");
           Console.WriteLine("Please 'enter' to continue");
           Console.ReadLine();
           return false;
       }


       ListContentsOfPack();
       Console.WriteLine("Press '6' if you've changed your mind and don't want to remove anything");


       Console.WriteLine("\nPlease enter the number of the item you would like to use or remove or press '6'.");
       var numToRemove = int.Parse(UserChoice(6));




       if (numToRemove == 6)
       {
           Console.WriteLine("You have chosen not to remove anything at this time. Nothing new has been added" +
                             "to the pack");
           return false;
       }


       var item = Pack[numToRemove - 1];
       if (item != "empty")
       {
           if (item.Contains("glass vial"))
           {
               Console.WriteLine("You have chosen to drink an elixir. It has restored your health by 10");
               cat.Health += 10;
               Pack[numToRemove - 1] = "empty";
           }
           else
           {
               if (item.Contains("shield"))
                   cat.HasShield = false;
               Console.WriteLine(
                   $"You have removed {item} from your pack. It can now be found in your discard stash.");
               if (item.Contains("gold"))
                   RemoveMoneyFromWallet(item);
               if (item.Contains("sheet"))
                   RemoveSheets(item);
               DiscardedItems.Add(item); // adds removed item to discarded list
               Pack[numToRemove - 1] = "empty"; //erases that item by replacing with "empty"
           }
       }
       else
       {
           Console.WriteLine("There is nothing in this spot so nothing has been removed.");
       }


       Console.WriteLine("Please 'enter' to continue");
       Console.ReadLine();
       return true;
   }


   public void RemoveMoneyFromWallet(string item)
   {
       int money = int.Parse(item.Substring(0, 2));
       Wallet -= money;
   }


   public string AddMoney(string item)
   {
       ListOfAllItemsPickedUp
           .Add(item);


       int money = int.Parse(item.Substring(0, 2));
       Wallet += money;


       if (Wallet < 10)
           item = "0" + Wallet + " gold coins";
       else
           item = Wallet + " gold coins";
       return item;
   }


   public string AddSheets(string sheet)
   {
       ListOfAllItemsPickedUp
           .Add(sheet);


       int numOfSheets = int.Parse(sheet.Substring(0, 1));
       NumberOfSheets += numOfSheets;


       sheet = NumberOfSheets + " sets of sheets";
       return sheet;
   }


   public void RemoveSheets(string sheet)
   {
       int numOfSheets = int.Parse(sheet.Substring(0, 1));
       NumberOfSheets -= numOfSheets;
   }


   public void AddItemToPack(Characters cat, string item)
   {
       bool goldAlreadyInPack = false;
       bool sheetsAlreadyInPack = false;
       foreach (string thing in Pack)
       {
           if (thing.Contains("gold"))
               goldAlreadyInPack = true;
           if (thing.Contains("sheet"))
               sheetsAlreadyInPack = true;
       }


       if ((goldAlreadyInPack && item.Contains("gold")) || (sheetsAlreadyInPack && item.Contains("sheet")))
       {
           Console.Write(""); // @fix there must be a better way to the program to do nothing
       }
       else if (NumberOfItemsInPack() == 5)
       {
           Console.WriteLine("Your pack is too burdened to add any more items. You must remove" +
                             $" something to make space for {item}.");
           Console.WriteLine("Please press '1' to remove items and '2' to make no changes to your pack.");
           if (UserChoice() == "1")
           {
               bool somethingWasRemoved = RemoveItemsFromPack(cat);
               if (!somethingWasRemoved)
                   return;
           }
           else
               return;
       }


       if (item == emptySpot)
       {
           Console.WriteLine("Nothing remains in this spot. Please make an alternate selection");
           Console.WriteLine("Press 'enter' to continue");
           Console.ReadLine();
           return;
       }


       if (item.Contains("coins"))
           item = AddMoney(item);
       if (item.Contains("sheets"))
           item = AddSheets(item);


       if (goldAlreadyInPack && item.Contains("gold"))
       {
           for (int i = 0; i < Pack.Length; i++) // then add it to an empty space in the pack
           {
               if (Pack[i].Contains("gold") && item.Contains("gold"))
               {
                   Pack[i] = item;
                   break;
               }
           }
       }
       else if (sheetsAlreadyInPack && item.Contains("sheet"))
       {
           for (int i = 0; i < Pack.Length; i++) // then add it to an empty space in the pack
           {
               if (Pack[i].Contains("sheet") && item.Contains("sheet"))
               {
                   Pack[i] = item;
                   break;
               }
           }
       }
       else
       {
           for (int i = 0; i < Pack.Length; i++)
           {
               if (Pack[i] == "empty")
               {
                   Pack[i] = item;
                   break;
               }
           }
       }


       Console.WriteLine($"You pack now contains {item}");
       ListOfAllItemsPickedUp
           .Add(item); //and add the item to the list of all items that have been picked up
       Console.WriteLine("Press 'enter' to continue");
       Console.ReadLine();
   }


   public string[] Options = new string[3];
   public string[] Descriptions = new string[3];




   public void AssignItemsBasedOnLocation(string location, Characters guardDog = null)
   {
       switch (location)
       {
           case "closet":
               Options[0] = "2 sets of faded bed sheets";
               Descriptions[0] = "Several folded bed sheets, their fabric yellowed but sturdy.";
               Options[1] = "the broom and dust pan";
               Descriptions[1] = "A broom and dustpan that lean against the far wall, unused for " +
                                 "what seems like years.";
               Options[2] = "manacles";
               Descriptions[2] = "A set of manacles, their chains coiled and rusted, almost blending into " +
                                 "the shadowy corner.";
               break;
           case "nightstand":
               Options[0] = "10 scattered gold coins";
               Descriptions[0] =
                   "Ten gold coins, scattered in the drawer, their surfaces dull with age but still carrying a " +
                   "reassuring weight.";
               Options[1] = "a pair of glasses";
               Descriptions[1] = "A pair of glasses, their lenses smudged with dust, the frames bent slightly " +
                                 "out of shape.";
               Options[2] = "a book of prayers";
               Descriptions[2] = "A book of prayers, its leather cover cracked with age, the pages thin and delicate.";
               break;
           case "bookshelf":
               Options[0] = "the dagger";
               Descriptions[0] =
                   "A dagger, its handle wrapped in worn leather, the blade dull but still sharp enough to be dangerous.";
               Options[1] = "the rusted set of tools";
               Descriptions[1] = "A small, rusted set of tools—a few thin rods of metal, a hook, and something " +
                                 "resembling a flattened key. They seem out of place, their purpose unclear at " +
                                 "first, though their delicate shapes suggest they might fit into something " +
                                 "small and stubborn.";
               Options[2] = "the cat figurine";
               Descriptions[2] = "A wooden figurine, carved in the shape of a cat. It’s crude but detailed enough " +
                                 "to capture the curve of a tail and the prickle of carved fur along its back. " +
                                 "The eyes, once painted, have long since faded, leaving behind empty impressions in the wood.";
               break;
           case "hearth":
               Options[0] = "the fire poker";
               Descriptions[0] = "A fire poker, its iron worn smooth from years of use, still sturdy " +
                                 "enough to be a weapon or a tool.";
               Options[1] = "the large stone";
               Descriptions[1] = "A large, loose stone, sitting slightly askew among the others. Heavier than " +
                                 "it looks, it would be perfect for smashing something stubborn.";
               Options[2] = "the shield";
               Descriptions[2] = "A shield, nearly invisible at first, hidden beneath layers of dust and cobwebs. " +
                                 "Its metal is dulled, its emblem barely discernible, but it remains solid—built " +
                                 "to withstand blows.";
               break;
           case "guard one":
               Options[0] = "the ring of keys";
               Descriptions[0] = "a ring of keys, but what do they open?";
               if (guardDog.Weapon == "paws") // if dog fought with paws
               {
                   Options[1] = "a dog whistle";
                   Descriptions[1] = "a dog whistle, worn around the neck";
               }
               else
               {
                   Options[1] = guardDog.Weapon;
                   Descriptions[1] = guardDog.Weapon;
               }


               if (guardDog.HasShield)
               {
                   Options[2] = "the crude shield"; // this will be a problem between guard 1, 2, and 3!
                   Descriptions[2] = "a crude but sturdy shield";
               }
               else
               {
                   Options[2] = "10 dull gold coins in a pouch";
                   Descriptions[2] = "a pouch with several dull gold coins";
               }


               break;
           case "guard two":
               Options[0] = "10 shiny gold coins"; // this will be a problem between guard 1, 2, and 3!
               Descriptions[0] = "a pouch with several shiny gold coins";
               if (guardDog.Weapon == "paws")
               {
                   Options[1] = "a set of worry beads"; // @fix maybe change this?
                   Descriptions[1] = "a set of worry beads";
               }
               else if (ListOfAllItemsPickedUp.Contains(guardDog.Weapon)) // if you already obtained this weapon
               {
                   Options[1] = "a set of worry beads";
                   Descriptions[1] = "a set of worry beads";
               }
               else
               {
                   Options[1] = guardDog.Weapon;
                   Descriptions[1] = guardDog.Weapon;
               }


               if (guardDog.HasShield)
               {
                   Options[2] = "a worn shield"; // this will be a problem between guard 1, 2, and 3!
                   Descriptions[2] = "a battered, worn shield";
               }
               else
               {
                   Options[2] = "an old dog whistle"; // this will be a problem between guard 1, 2, and 3!
                   Descriptions[2] = "an old dog whistle";
               }


               break;
           case "guard three":
               Options[0] = "20 dull gold coins"; // this will be a problem between guard 1, 2, and 3!
               Descriptions[0] = "several dull gold coins in the guard's pocket";
               Options[1] = "the loaf of bread";
               Descriptions[1] = "a crusty, hearty loaf of bread";
               Options[2] = "the elixir in a glass vial";
               Descriptions[2] = "an elixir that you're sure will help heal your injuries";
               break;
           case "third floor room 2":
               Options[0] = "the long dagger";//@add in the descriptions so I can white them out if they are taken
               Options[1] = "13 gold coins";
               Options[2] = "1 set of bedsheets";
               break;
           case "third floor room 3":
               Options[0] = "the glass vial";
               Options[1] = "12 gold coins";
               Options[2] = "the collar";
               break;
           case "second floor room 1":
               Options[0] = "the dog statue";
               Options[1] = "an elixir in a glass vial";
               Options[2] = "the battered shield";
               break;
           case "second floor room 3":
               Options[0] = "4 sets of sheets";
               Options[1] = "13 shiny gold coins";
               Options[2] = "the mysterious elixir in a glass vial";
               break;
           case "second floor room 4":
               Options[0] = "the 20' length of rope";
               Options[1] = "a shimmering elixir in a glass vial";
               Options[2] = "the short sword";
               break;
       }
   }


   public void TakeItems(Characters cat, string location, Characters guardDog = null)
   {
       AssignItemsBasedOnLocation(location, guardDog);


       do
       {
           for (int i = 0; i < Options.Length; i++) // mark items that have already been picked up
           {
               if (ListOfAllItemsPickedUp.Contains(Options[i]))
                   Options[i] = emptySpot;
           }


           Console.WriteLine(
               "\nPlease choose which items you would like to add to your pack. Please enter the number " +
               "for one item then press enter:");


           for (int i = 0; i < Options.Length; i++)
               Console.WriteLine($"  {i + 1} - {Options[i]}");




           Console.WriteLine($"\n Or press '4' to leave the {location}. " +
                             $"Items that you have removed from your inventory can be found in the discard " +
                             $"stash in the main room.");




           switch (UserChoice(4))
           {
               case "1":
                   AddItemToPack(cat, Options[0]);
                   break;
               case "2":
                   AddItemToPack(cat, Options[1]);
                   break;
               case "3":
                   AddItemToPack(cat, Options[2]);
                   break;
               case "4":
                   return;
           }
       } while (NumberOfItemsInPack() <= 5);
   }
}

