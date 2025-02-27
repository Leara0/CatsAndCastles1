namespace CatsAndCastles1;


public class Fight
{
    private readonly UserInput _userInput = new UserInput();
   public void GuardDogEncounter(Characters cat, BackPack backPack, Characters guardDog, int guardNumber)
   {
       cat.LostToGuard = false;
       Weapons weapon = new Weapons();
       Random rnd = new Random();


       string[,] floorSpecificWording =
       {
           {
               "\nA guard stands watch, its back turned, ears twitching slightly but otherwise oblivious " +
               "to your presence. Its armor is slightly dented, its stance relaxed — this guard isn’t " +
               "expecting trouble.\n\nYou realize that investigating the other doors would be risky with the " +
               "guard dog so close. You’ll likely need to deal with it before you can safely explore the hallway. " +
               "The doors might hold supplies or riches — things that could help in your escape, " +
               "but first, you’ll have to decide how to handle the immediate threat." + //@fix clean up this wording
               "\n\nYou have only moments to decide:",


               "With careful steps, you back toward the stairway.",


               "Your paws barely make a sound as you bound down the steps, spiraling deeper " +
               "into the castle. No bark, no pounding footsteps behind you. You weren't seen." +
               "\n\nAs you near the bottom of the steps, the silence is reassuring. " +
               "The guard remains upstairs, unaware of your escape."
           },
           {
               "You make your way to door 4 — this one barely ajar. You pause, ears twitching, and " +
               "peer inside. \n\nA guard stands within, unaware of your presence. His posture is relaxed, " +
               "his focus elsewhere. He hasn't noticed you... yet. Beyond him you notice items that might be" +
               "useful in your escape",


               "With careful steps, you back away from the door. ",


               "You place each paw with practiced silence. " +
               "The door remains as you found it — barely open, the guard none the wiser." +
               "\n\nBack in the hall, you take a steadying breath. You’ve avoided a fight, " +
               "but where will you go next? "
           },
           {
               "\nAhead stands a massive dog, larger than any you’ve seen, clad in dark, battered armor . Its fur " +
               "is matted and its ears are torn from past battles." +
               "\n\nThis isn’t some simple guard. This is the Warden. His hulking form blocks your only obvious " +
               "route out. The Warden's eyes don't move as you approach. You know you only have seconds, " +
               "before he’ll notice you.",


               "With careful steps, you back toward the stairway.",


               "You are careful to keep to the shadows. " +
               "The warden remains fixated on the open door, oblivious to your retreat. You begin your ascent back " +
               "up the stairs, each step measured and silent beneath your paws." +
               "\n\nAs you near the landing, you pause and listen. There's no sign that the warden has " +
               "noticed your departure. The silence around you confirms that, for now, you're safe."
           }
       };
       GuardDog();


       void GuardDog()
       {
           cat.Caught = false;
           Console.WriteLine(floorSpecificWording[guardNumber, 0]);


           if (guardNumber == 2) // if warden
               Console.WriteLine(
                   "You have a choice: - Engage the massive warden in combat, risking it all to fight (or bribe) your " +
                   "way through to the exit. Or sneak back up the stairs to continue exploring the castle " +
                   "for another way to escape. " +
                   "\n\nPress '1' to engage in combat." +
                   $"\nPress '2' to attempt to bribe the guard - you have {backPack.Wallet} gold coins" +
                   "\nPress '3' to carefully attempt to slip away.");
           else
           {
               Console.WriteLine($"\nYou have a choice: do you engage the guard or do you flee");
               Console.WriteLine(
                   "\nPress '1' to engage the guard, risking a fight but possibly gaining valuable loot." +
                   "\nPress '2' to attempt to bribe the guard, trusting your coin to buy you time to explore while" +
                   $"you explore this floor.- you have {backPack.Wallet} gold coins" +
                   "\nPress '3' to carefully step away, leaving him undisturbed and continuing your exploration " +
                   "elsewhere");
           }


           switch (_userInput.UserChoice(3))
           {
               case "1":
                   Combat();
                   break;
               case "2":
                   AttemptBribe();
                   break;
               case "3":
                   Console.WriteLine(floorSpecificWording[guardNumber, 1]);
                   var roll = rnd.Next(1, 21);
                   Console.WriteLine(
                       $"\nRoll a D20 for luck. You must get higher than {(guardNumber == 1 ? "5" : "10")} " +
                       $"to successfully sneak away");
                   _userInput.DramaticPause();
                   Console.WriteLine($"You roll a {roll}.\n");


                   if ((guardNumber == 1 && roll > 5) ||
                       (guardNumber != 1 && roll > 10))
                   {
                       Console.WriteLine(floorSpecificWording[guardNumber, 2]);
                       _userInput.DramaticPause();
                       Console.Clear();
                       if (guardNumber != 1)
                           cat.Location = Characters.Place.SecondFloor;
                   }
                   else
                   {
                       Console.WriteLine(
                           "The moment you move, the dog’s ears twitch. A low growl rumbles behind you. " +
                           $"Then—barking. You've been caught and the quick {(guardNumber == 2 ? "warden" : "guard")} " +
                           $"now has the advantage of attacking first.");
                       cat.Caught = true;
                       Combat();
                   }


                   break;
           }
       }




       void AttemptBribe()
       {
           var hasGold = false;


           Console.WriteLine(
               "The dog's ears flick, and then it turns. Eyes lock onto yours — wide at first, then narrowing. " +
               "For a heartbeat, the two of you simply stare.");


           foreach (string item in backPack.Pack)
               if (item.Contains("gold"))
                   hasGold = true;


           if (hasGold)
           {
               cat.SuccessfulBribed = Bribe();
               if (!cat.SuccessfulBribed)
                   Combat();
           }
           else
           {
               Console.WriteLine("You consider attempting to bribe the guard but then remember you have no coins. " +
                                 "You prepare to engage in combat with the guard dog\n");
               Combat();
           }
       }


       bool Bribe()
           //@add maybe make it so that if you are unsuccessful at a bribe attempt the dog fights harder (+1 damage?)
       {
           var bribeGuard = rnd.Next(20, 35);
           var bribeWarden = rnd.Next(50, 60);
           var bribable = rnd.Next(1, 21);


           Console.WriteLine(
               "\nYou clear your throat just enough to get its attention. The dog’s ears perk up, and it " +
               "spins around, baring its teeth in surprise. For a moment, it just stares at you, " +
               "blinking, as if trying to process why you are standing here instead of locked away." +
               "\n\nBefore it can react, you flick your tail and speak. \"Let’s not make this difficult. " +
               "What if we just pretend you never saw me?\"");


           Console.WriteLine(
               $"\nRoll a D20. You must roll higher than {(guardNumber == 2 ? "17" : "5")} for the " +
               $"guard to be open to taking a bribe.");
           _userInput.DramaticPause();
           
           Console.WriteLine($"You roll a {bribable}");
           if ((guardNumber != 2 && bribable > 5) || (guardNumber == 2 && bribable > 17))
           {
               // if the dog is open to being bribed
               Console.WriteLine(
                   "\n\nThe dog narrows its eyes, sniffing the air as it considers your words. Then, with a " +
                   $"slow smirk, it tilts its head. \"Hah. That depends. Let's say my memory’s not great... " +
                   $"for {(guardNumber == 2 ? bribeWarden : bribeGuard)} gold coins I might be able to forget " +
                   $"you're presence entirely\".");
               if ((guardNumber != 2 && backPack.Wallet >= bribeGuard) ||
                   (guardNumber == 2 && backPack.Wallet >= bribeWarden)) //if you have the funds
               {
                   Console.WriteLine(
                       "\nYou glance down at your pack, pawing through its contents. The familiar weight of " +
                       $"gold presses against your claws — {backPack.Wallet} coins. You have what the " +
                       $"dog is asking for." +
                       $"\n\nPress '1' to pay the guard and '2' to choose to fight instead.");
                   if (_userInput.UserChoice() == "1")
                   {
                       Console.WriteLine("\nWithout hesitation, you drop the gold coins into the waiting paw." +
                                         "\n\nIt eyes the payment, then smirks. \"Pleasure doing business with you.\"" +
                                         "\n\nThe coins vanish into its pouch, and the guard steps aside. \"Go on, then. " +
                                         "You are invisible to me until you leave this floor.\"");
                       if (guardNumber == 2)
                           backPack.Wallet -= bribeWarden;
                       else
                           backPack.Wallet -= bribeGuard;


                       return true;
                   }


                   return false; //return false if player doesn't want to pay the bribe
               }


               Console.WriteLine("\nYou glance down at your pack, pawing through its contents. Your claws scrape " +
                                 "against the coins at the bottom, but as you count them, your stomach sinks. " +
                                 $"{backPack.Wallet} gold coins - not enough. \n\nYou look up, meeting its gaze. " +
                                 "It already knows." +
                                 $"\n\nThe {(guardNumber == 2 ? "warden" : "guard")} steps forward, teeth bared, " +
                                 $"hackles raised. \"Guess we’re doing this " +
                                 "the hard way.\"" +
                                 "\n\nYou have no choice now — you must fight.");
               _userInput.DramaticPause();
               return false;
           }


           Console.WriteLine("The dog’s jaw drops. Then, with a sudden growl, it bares its teeth." +
                             "\n\n\"You think I can be bought?\" it snaps, stepping forward, claws scraping against " +
                             "the stone floor. \"That’s insulting! I have a duty, and I take it seriously!\"" +
                             "\n\nIt appears this guard cannot be bribed. A fight is coming. "); //@fix repetitive use of the word 'bought'
           return false;
       }




       void Combat()
       {
           var guardMaxHealth = guardDog.Health;
           string[] weaponAndShield = ChooseWeapon();
           cat.Weapon = weaponAndShield[0];
           if (weaponAndShield[1] == "1")
               cat.HasShield = true;
           else
               cat.HasShield = false;


           guardDog.Weapon = ChooseGuardDogWeapon();
           if (rnd.Next(1, 11) > 8)
               guardDog.HasShield = true;
           else
               guardDog.HasShield = false;
           // cat and guardDog have Health and Weapons


           Console.WriteLine(
               "All your choices and luck have lead to this moment - there is no turning back." +
               "\n\nThe guard dog snarls, its stance low and ready to strike. It's just you " +
               "and the beast, locked in a battle for survival." +
               "\n\nThe air is thick with tension. The dog's muscles bunch, its eyes locked onto you. " +
               "The fight is about to begin." +
               $"\n\nThe {(guardNumber == 2 ? "warden" : "guard")}'s health is {guardDog.Health}. " +
               $"\nYour health is {cat.Health}.");


           WeaponsReminder(cat, "cat");
           WeaponsReminder(guardDog, "guardDog");
           _userInput.DramaticPause();


           int attack;
           if (cat.Caught)
           {
               attack = Attack(guardDog);
               cat.Health -= attack;
               Console.Write($"\nThe guard dog attacks first doing {attack} damage. ");
               if (cat.HasShield)
               {
                   Console.Write("Your shield deflects 1 damage");
                   cat.Health++;
               }


               Console.WriteLine($"\nYour remaining health is {(Math.Max(cat.Health, 0))} out of 60");




               if (cat.Health > 0)
               {
                   Console.WriteLine(Text.CatBorder1);
                   _userInput.DramaticPause();
                   
                   
               }
           }


           do
           {
               attack = Attack(cat);
               guardDog.Health -= attack;
               Console.Write($"\nYou attack doing {attack} damage. ");
               if (guardDog.HasShield)
               {
                   Console.Write("Their shield deflects 1 damage.");
                   guardDog.Health++;
               }


               Console.WriteLine($"\nThe {(guardNumber == 2 ? "warden" : "guard")}'s remaining health is " +
                                 $"{Math.Max(guardDog.Health, 0)} out of {guardMaxHealth}");
               if (guardDog.Health <= 0)
               {
                   Console.WriteLine("\nYou are victorious in the fight against the guard");
                   guardDog.Location = Characters.Place.Dead;
                   LootBody();
                   return;
               }


               attack = Attack(guardDog);
               cat.Health -= attack;
               Console.Write($"\nThe guard dog attacks you doing {attack} damage. ");
               if (cat.HasShield)
               {
                   Console.Write("Your shield deflects 1 damage");
                   cat.Health++;
               }


               Console.WriteLine($"\nYour remaining health is {(cat.Health >= 0 ? cat.Health : "0")} out of 60");
               if (cat.Health > 0)
               {
                   Console.WriteLine(Text.CatBorder1);
                   _userInput.DramaticPause();
                   
               }
           } while (cat.Health > 0);


           if (cat.Health <= 0)
           {
               Console.WriteLine("\nThe guard has been victorious in this fight\n");
               cat.Location = Characters.Place.PassedOut;
           }
       }




       void LootBody()
       {
           Console.WriteLine("\nYou stand over the fallen guard, the echoes of battle slowly fading. His motionless " +
                             "body lies before you, and you notice several items that might aid you on your journey:");
           string guardLocation = "";
           switch (guardNumber)
           {
               case 0:
                   guardLocation = "guard one";
                   break;
               case 1:
                   guardLocation = "guard two";
                   break;
               case 2:
                   guardLocation = "guard three";
                   break;
           }


           backPack.AssignItemsBasedOnLocation(guardLocation, guardDog);
           for (int i = 0; i < backPack.Options.Length; i++)
           {
               if (backPack.ListOfAllItemsPickedUp.Contains(backPack.Options[i]))
                   backPack.Descriptions[i] = backPack.emptySpot;
               Console.WriteLine($"- {backPack.Descriptions[i]}");
           }


           Console.WriteLine("You have a choice: loot the body now and gather any supplies that might be useful, " +
                             "or leave the guard's remains undisturbed for the moment. Remember, if you choose not to " +
                             "take anything right now, you can always return later to search his body again.. " +
                             "\n\nPress '1' to loot and '2' to move on. ");
           if (_userInput.UserChoice() == "1")
           {
               backPack.TakeItems(cat, guardLocation, guardDog);
           }


           Console.WriteLine("You leave the corpse.");
       }


       int Attack(Characters attacker)
       {
           int[] weaponStats = weapon.WeaponChoice(attacker.Weapon);
           return rnd.Next(1, weaponStats[0] + 1) + weaponStats[1];
       }


       void WeaponsReminder(Characters attacker, string animalType)
       {
           int[] weaponStats = weapon.WeaponChoice(attacker.Weapon);
           Console.WriteLine(
               $"\n{(animalType == "cat" ? "You" : "The guard dog")} will be fighting with {attacker.Weapon} - D{weaponStats[0]} +{weaponStats[1]}");
           Console.WriteLine(
               $"{(animalType == "cat" ? "You" : "The guard dog")} will{(attacker.HasShield ? "" : " not")} be using a shield {(attacker.HasShield ? "(+1 protection)" : "")}");
       }




       string ChooseGuardDogWeapon()
       {
           var dogWeapon = rnd.Next(1, 5);
           switch (dogWeapon)
           {
               case 1:
                   return "manacles";
               case 2:
                   return "a club";
               case 3:
                   return "a bone";
               default:
                   return "paws";
           }
       }




       string[] ChooseWeapon()
       {
           Console.WriteLine("You quickly check your inventory, assessing what you have and what might help you in " +
                             "battle?\n");
           if (backPack.NumberOfItemsInPack() == 0)
           {
               Console.WriteLine("Your pack is empty. Your only choice is to fight with your paws: D4 +0");
               return ["paws", ""];
           }


           for (int i = 0; i < backPack.Pack.Length; i++) // shows inventory with weapons modifiers
           {
               //if (backPack.Pack[i] == "") // i'm pretty sure this code is obsolete
               //    backPack.Pack[i] = "empty";
               int[] weaponStats = weapon.WeaponChoice(backPack.Pack[i]);
               Console.WriteLine($"{i + 1} - {backPack.Pack[i]}: D{weaponStats[0]} +{weaponStats[1]}");
           }


           Console.WriteLine(
               "\nChoose your weapon wisely. Enter the number of the item you wish to wield in this fight.");


           int response = int.Parse(_userInput.UserChoice(backPack.Pack.Length));
           string choice = backPack.Pack[response - 1];


           if (backPack.Pack[response - 1] == "empty")
           {
               Console.WriteLine("You chose nothing. You will now fight with your paws: D4 +0");
               choice = "paws";
           }


           if (weapon.WeaponChoice(choice)[0] == 0)
           {
               Console.WriteLine(
                   $"Your paws are more deadly than {choice}. You wisely choose to fight with your paws: D4 +0");
               choice = "paws";
           }
           else
               Console.WriteLine($"You have chosen to fight with {choice}.");


           var hasShield = "";
           bool shieldInPack = false;
           foreach (var item in backPack.Pack)
           {
               if (weapon.DefenseChoice(item) == 2)
                   shieldInPack = true;
           }


           if (shieldInPack)
           {
               Console.WriteLine("\nYour pack holds a shield — it would offer +1 protection in this fight, but its " +
                                 "weight might slow you down, making you less agile. Do you want to use it in this fight?");
               Console.WriteLine("\nPlease press '1' if you'd like to use the shield and '2' to fight without it");
               if (_userInput.UserChoice() == "1")
                   hasShield = "1";
           }




           return [choice, hasShield];
       }
   }
}

