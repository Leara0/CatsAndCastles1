namespace CatsAndCastles1;

public class MainRoom(Characters cat, BackPack backPack)
{
    private readonly UserInput _userInput = new UserInput();


    public void RunMainRoom()
    {
        //readonly Text text;
        Console.Clear();
        Console.WriteLine(Text.CatBorder1);
        Console.WriteLine($"Greetings, adventurer. The night has been long and unkind, and your " +
                          $"memories of it are little more than a haze. " +
                          $"\n\nYou wake, dazed and disoriented, your senses slow to return as you " +
                          $"instinctively groom your soft coat. You feel a collar around your neck " +
                          $"and notice a tag \"{cat.Name}\" attached. Hmmmm, that name seems faintly " +
                          $"familiar? Is it yours? A loved one's? The answer alludes you. You notice " +
                          $"you still have your pack that can hold 5 items, however, your spirits " +
                          $"drop as you realize it is empty. ");
        StartInRoom();
    }

    public void SubsequentWakeUp()
    {
        cat.Health = 60;
        Console.WriteLine(Text.SubsequentWakeUp);
        StartInRoom();
    }

    public void StartInRoom()
    {
        Console.WriteLine(Text.StartInRoom);
        Console.ReadLine();
        MainRoomMethod();
    }

    public void MainRoomMethod()
    {
        cat.Location = Characters.Place.MainRoom;
        cat.EndGame = false;
        FirstRoomChoices();

        void FirstRoomChoices()
        {
            //backPack.Pack[1] = "the rusted set of tools";
            Console.Clear();
            Console.WriteLine(Text.CatBorder1);
            Console.WriteLine(Text.FirstRoomChoices);
            if (backPack.DiscardedItems.Count == 1)
            {
                Console.WriteLine(Text.DiscardPile1Item);
            }


            if (backPack.DiscardedItems.Count > 1)
            {
                Console.WriteLine(Text.DiscardPileMultiItems);
            }

            Console.WriteLine(Text.WhereToExplore);

            switch (_userInput.UserChoice(8))
            {
                case "1":
                    ExploreDoor();
                    return;
                case "2":
                    ExploreCloset();
                    return;
                case "3":
                    ExploreWindow();
                    return;
                case "4":
                    ExploreNightStand();
                    return;
                case "5":
                    ExploreBookshelf();
                    return;
                case "6":
                    ExploreHearth();
                    return;
                case "7":
                    backPack.RemoveItemsFromPack(cat);

                    FirstRoomChoices();
                    return;
                case "8":
                    backPack.PickUpItemsFromDiscarded(cat);
                    FirstRoomChoices();
                    return;
            }
        }

        void ReturnToMainPartOfRoom(string fromLocation)
        {
            Console.WriteLine(
                $"You step away from the {fromLocation}{(fromLocation == "closet" ? "and shut the door behind you" : "")}.");
            FirstRoomChoices();
        }


        void ListItemsInLocation(string location)
        {
            backPack.AssignItemsBasedOnLocation(location);
            for (int i = 0; i < backPack.Options.Length; i++)
            {
                if (backPack.ListOfAllItemsPickedUp.Contains(backPack.Options[i]))
                    backPack.Descriptions[i] = backPack.emptySpot;
                Console.WriteLine($"- {backPack.Descriptions[i]}");
            }
        }

        void DecisionTime(string location)
        {
            Console.WriteLine(Text.TakeItemsOrLeaveRoom);


            if (_userInput.UserChoice() == "1")
                backPack.TakeItems(cat, location);
            ReturnToMainPartOfRoom(location);
        }

        void ExploreNightStand()
        {
            Console.WriteLine(Text.ExploreNightStand);
            ListItemsInLocation("nightstand");
            Console.WriteLine(Text.ChoiceToTakeItemsNightStand);
            DecisionTime("nightstand");
        }

        void ExploreCloset()
        {
            Console.WriteLine(Text.ExploreCloset);
            ListItemsInLocation("closet");
            Console.WriteLine(Text.ChoiceToTakeItemsCloset);
            DecisionTime("closet");
        }

        void ExploreBookshelf()
        {
            Console.WriteLine(Text.ExploreBookshelf);
            ListItemsInLocation("bookshelf");
            Console.WriteLine(Text.ChoiceToTakeItemsBookshelf);
            DecisionTime("bookshelf");
        }

        void ExploreHearth()
        {
            Console.WriteLine(Text.ExploreHearth);
            ListItemsInLocation("hearth");
            Console.WriteLine(Text.WouldYouLikeToTakeAnything);
            DecisionTime("hearth");
        }


        void ExploreWindow()
        {
            Console.Clear();
            Console.WriteLine(Text.ExploreWindow);
            switch (_userInput.UserChoice(3))
            {
                case "1":
                    bool hasSheets = false;
                    bool hasRope = false;
                    foreach (var item in backPack.Pack) //if you have sheets you can choose to use them
                    {
                        if (item.Contains("sheet"))
                            hasSheets = true;
                        if (item.Contains("rope"))
                            hasRope = true;
                    }


                    if (hasSheets && hasRope)
                    {
                        Console.WriteLine(Text.HowToProceedWithSheetsAndRope);
                        switch (_userInput.UserChoice(4))
                        {
                            case "1":
                                UseSheets();
                                return;
                            case "2":
                                UseSheets("rope");
                                return;
                            case "3":
                                JumpDown();
                                return;
                            case "4":
                                ReturnToMainPartOfRoom("window");
                                return;
                        }
                    }
                    else if (hasSheets || hasRope)
                    {
                        if (hasSheets)
                            Console.WriteLine(Text.MakeAChoiceWithSheets);
                        if (hasRope)
                            Console.WriteLine(Text.MakeAChoiceWithRope);

                        switch (_userInput.UserChoice(3))
                        {
                            case "1":
                                if (hasSheets)
                                    UseSheets();
                                if (hasRope)
                                    UseSheets("rope");
                                return;
                            case "2":
                                JumpDown();
                                return;
                            case "3":
                                ReturnToMainPartOfRoom("door");
                                return;
                        }
                    }
                    else
                    {
                        Console.WriteLine(Text.MakeChoiceNoSheetsOrRope);
                        Console.WriteLine(Text.CatBorder1);
                        if (_userInput.UserChoice() == "1")
                            JumpDown();
                        else
                            ReturnToMainPartOfRoom("door");
                    }


                    return;
                case "2":
                    JumpDown();
                    return;
                case "3":
                    ReturnToMainPartOfRoom("door");
                    return;
            }
        }


        void JumpDown()
        {
            Console.WriteLine(Text.CatBorder1);
            Console.WriteLine(Text.LeapDown);
            cat.Location = Characters.Place.PassedOut;
        }


        void UseSheets(string item = "sheets")
        {
            Console.WriteLine(Text.CatBorder1);
            if (item == "sheets")
                Console.WriteLine(Text.UseSheets);
            else if (item == "rope")
                Console.WriteLine(Text.UseRope);
            if (backPack.NumberOfSheets > 5 || item == "rope")
                Console.WriteLine(
                    $"Your {(item == "sheets" ? $"sheets reach {backPack.NumberOfSheets * 4}" : "rope reaches 20")} feet " +
                    $"down the wall you'll only need to survive a {(item == "sheets" ? 30 - backPack.NumberOfSheets * 4 : "10")} " +
                    "foot drop once you reach the end of the rope.");
            else
                Console.WriteLine($"Your stomach drops when you realize that the tied sheets only stretch " +
                                  $"{backPack.NumberOfSheets * 4} feet down the wall. You'll only need to survive a " +
                                  $"{30 - backPack.NumberOfSheets * 4} foot drop once you reach the end of the rope.");
            Console.WriteLine("You must choose:");
            Console.WriteLine("'1' - Climb down the rope and leap from the bottom." +
                              "\n'2' - Jump directly from the window ledge." +
                              $"\n'3' - Pull up the {item} and stash {(item == "sheets" ? "them" : "it")} " +
                              $"then continue exploring the room.");
            switch (_userInput.UserChoice(3))
            {
                case "1":
                    if (backPack.NumberOfSheets > 5 || item == "rope")
                    {
                        if (item == "sheets")
                            Console.WriteLine(Text.ClimbDownSheets);
                        else
                            Console.WriteLine(Text.ClimbDownRope);
                        cat.Location = Characters.Place.OutsideCastle;
                    }
                    else
                    {
                        Console.WriteLine(Text.ClimbDownToLeap);
                        JumpDown();
                    }

                    break;
                case "2":
                    JumpDown();
                    break;
                case "3":
                    ReturnToMainPartOfRoom("window");
                    break;
            }
        }


        void ExploreDoor() //@add revisit this
        {
            Console.WriteLine(
                "\n   -   -   -   -   -   -   -   -   =^.^=   -   -   -   -   -   -   -   -   -   -   \n");
            Console.WriteLine(
                "You approach the heavy wooden door, its frame dark and imposing against the stone wall." +
                "Your eyes are drawn to the thick, old lock hanging from the latch. " +
                "The lock looks sturdy, its cold metal catching the dim light. It's a formidable obstacle, " +
                "preventing you from escaping, but you know you must find a way out. " +
                "Would you like to search your inventory for tools or items that might aid in unlocking the door " +
                "or continue exploring the room?");
            Console.WriteLine("Please press '1' to search your inventory and '2' to return to exploring the room");
            if (_userInput.UserChoice() == "1")
                AttemptToUnlockDoor();
            else
                ReturnToMainPartOfRoom("door");
        }


        void AttemptToUnlockDoor() //@fix there must be a way to make the stone vs shield thing shorter
        {
            var hasLockPick = false;
            var hasStone = false;
            var hasShield = false;


            foreach (var item in backPack.Pack)
            {
                if (item == "the rusted set of tools")
                    hasLockPick = true;
                if (item == "the large stone")
                    hasStone = true;
                if (item == "the shield")
                    hasShield = true;
            }


            if (hasLockPick && (hasStone || hasShield))
            {
                Console.WriteLine("You pause and take a moment to look through your inventory, searching for " +
                                  "something that might help. Your paws sift through the items you’ve collected so " +
                                  "far, and you find two items that might be useful:" +
                                  "\n- A rusted set of tools—small, delicate rods and a hook that might be able to " +
                                  "fit into the lock, though they look far from reliable.");
                if (hasStone)
                    Console.WriteLine("- A heavy smooth rock, solid and weighty in your grasp. While not the most " +
                                      "subtle choice, it might be capable of smashing the lock off with a few good strikes.");
                if (hasShield)
                    Console.WriteLine("- A shield, its metal surface scratched and worn, but still sturdy. " +
                                      "It could be used to bash the lock off with brute force.");


                Console.WriteLine("\nThe options sit before you. You can:" +
                                  "\n'1' - Keep exploring the room, hoping for another way out or more supplies " +
                                  "that might help.");
                Console.WriteLine("'2' - Attempt to pick the lock with the rusted tools.");
                if (hasStone && hasShield)
                {
                    Console.WriteLine("'3' - Use the rock to smash the lock off.");
                    Console.WriteLine("'4' - Use the shield to smash the lock off.");
                }
                else if (hasStone)
                    Console.WriteLine("'3' - Use the rock to smash the lock off.");
                else if (hasShield)
                    Console.WriteLine("'3' - Use the shield to smash the lock off.");


                string response = _userInput.UserChoice(4);
                switch (response)
                {
                    case "1":
                        ReturnToMainPartOfRoom("door");
                        break;
                    case "2":
                        PickLock();
                        break;
                    default:
                        if (hasStone && hasShield)
                            if (response == "3")
                                HeavyObject("stone");
                            else
                                HeavyObject("shield");
                        else if (hasShield)
                            HeavyObject("shield");
                        else
                            HeavyObject("stone");
                        break;
                }
            }


            else if (hasStone && hasShield)
            {
                Console.WriteLine("You pause and take a moment to look through your inventory, searching for " +
                                  "something that might help. Your paws sift through the items you’ve collected so " +
                                  "far, and you find two items that might be useful:" +
                                  "\n- A heavy smooth rock, solid and weighty in your grasp. While not the most" +
                                  "\nsubtle choice, it might be capable of smashing the lock off with a few good strikes." +
                                  "\n- A shield, its metal surface scratched and worn, but still sturdy. " +
                                  "It could be used to bash the lock off with brute force.");


                Console.WriteLine("\nThe options sit before you. You can:" +
                                  "\n'1' - Use the rock to bash the lock off." +
                                  "\n'2' - Use the shield to smash the lock off. " +
                                  "\n'3' - Keep exploring the room, hoping for another way out or more supplies that might help");
                switch (_userInput.UserChoice(3))
                {
                    case "1":
                        HeavyObject("stone");
                        break;
                    case "2":
                        HeavyObject("shield");
                        break;
                    case "3":
                        ReturnToMainPartOfRoom("door");
                        break;
                }
            }


            else if (hasLockPick)
            {
                Console.WriteLine("You dig through your pack, your paws brushing over familiar items until you " +
                                  "feel something that might help. You pull out the rusted set of tools—small, " +
                                  "delicate rods of metal, a hook, and a flattened key-like piece. " +
                                  "Though worn and aged, they seem like they might fit together in some way. " +
                                  "\nWould you like to attempt to use them to pick the lock or would you like" +
                                  "to continue searching the room for other items that might help?"); //@fix this wording is awkward
                Console.WriteLine("\nPlease press '1' to try to pick the lock with the rusted tools and " +
                                  "'2' to return to exploring the room");
                Console.WriteLine(
                    "\n   -   -   -   -   -   -   -   -   =^.^=   -   -   -   -   -   -   -   -   -   -   \n");
                if (_userInput.UserChoice() == "1")
                    PickLock();
                else
                    ReturnToMainPartOfRoom("door");
            }


            else if (hasShield)
            {
                Console.WriteLine("You dig through your pack, feeling the weight of each item, until your paw " +
                                  "brushes against something solid. You pull out the shield. " +
                                  "It feels solid in your grip, it might just be powerful enough to break the " +
                                  "lock off the door." +
                                  "\nThe lock seems secure, and the shield might be your only chance at forcing your way " +
                                  "through.");
                Console.WriteLine("Please press '1' to try to use the shield to break the lock and " +
                                  "'2' to return to exploring the room");
                if (_userInput.UserChoice() == "1")
                    HeavyObject("shield");
                else
                    ReturnToMainPartOfRoom("door");
            }
            else if (hasStone)
            {
                Console.WriteLine("You dig through your pack, feeling the weight of each item, until your paw " +
                                  "brushes against something solid. You pull out a large stone, its surface smooth and " +
                                  "worn. It feels heavy in your grip, it might just be powerful enough to break the " +
                                  "lock off the door." +
                                  "\nThe lock seems secure, and the stone might be your only chance at forcing your way " +
                                  "through.");
                Console.WriteLine("Please press '1' to try to use the large stone to break the lock and " +
                                  "'2' to return to exploring the room");
                Console.WriteLine(
                    "\n   -   -   -   -   -   -   -   -   =^.^=   -   -   -   -   -   -   -   -   -   -   \n");
                if (_userInput.UserChoice() == "1")
                    HeavyObject("stone");
                else
                    ReturnToMainPartOfRoom("door");
            }
            else
            {
                Console.WriteLine("You don't have any items in your inventory that can help you with the lock.");
                Console.WriteLine("You must continue to explore the room.");
                Console.WriteLine("Press 'enter' to continue");
                Console.ReadLine();
                ReturnToMainPartOfRoom("door");
            }
        }


        void HeavyObject(string objectName)
        {
            Console.WriteLine(
                "\n   >   >   >   >   >   >   >   >   >   =^.^=   <   <   <   <   <   <   <   <   <   \n");
            Console.WriteLine($"You decide to try your luck with the heavy {objectName}. With a grunt, you lift the");
            Console.WriteLine($"{objectName}, its weight heavy in your hands. You aim it carefully at the lock and");
            Console.WriteLine(
                $"swing with all your might. The {objectName} slams into the lock with a loud crack, but the");
            Console.WriteLine(
                $"force causes it to bounce off the door, sending the {objectName} ricocheting back toward");
            Console.WriteLine("you.");
            Console.WriteLine($"Before you can react, the {objectName} strikes your head with a sharp blow.");
            cat.Location = Characters.Place.PassedOut;
        }


        void PickLock()
        {
            Console.WriteLine(
                "\n   >   >   >   >   >   >   >   >   >   =^.^=   <   <   <   <   <   <   <   <   <   \n");
            Console.WriteLine("You carefully examine the rusty set of tools. With steady hands,");
            Console.WriteLine("you select a small pick and a thin rod, using them to work the lock. The old lock");
            Console.WriteLine("resists at first, but with a soft click, it finally gives way.");
            Console.WriteLine("With a sigh of relief, you open the door slowly, careful not to make a sound.");
            Console.WriteLine("Press 'enter' to continue");
            Console.ReadLine();
            cat.Location = Characters.Place.ThirdFloor;
        }
    }
}