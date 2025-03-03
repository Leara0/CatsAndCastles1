namespace CatsAndCastles1;

public class MainRoom(Characters cat, BackPack backPack)
{
    private readonly UserInput _userInput = new UserInput();
    Random rnd = new Random();


    public void RunMainRoom()
    {
        //readonly LocationText LocationText;
        Console.Clear();
        Console.WriteLine(LocationText.CatBorder1);
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
        Console.WriteLine(LocationText.SubsequentWakeUp);
        StartInRoom();
    }

    public void StartInRoom()
    {
        Console.WriteLine(LocationText.StartInRoom);
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
            Console.WriteLine(LocationText.CatBorder1);
            Console.WriteLine(LocationText.FirstRoomChoices);
            if (backPack.DiscardedItems.Count == 1)
            {
                Console.WriteLine(LocationText.DiscardPile1Item);
            }


            if (backPack.DiscardedItems.Count > 1)
            {
                Console.WriteLine(LocationText.DiscardPileMultiItems);
            }

            Console.WriteLine(LocationText.WhereToExplore);

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
            Console.WriteLine(LocationText.TakeItemsOrLeaveRoom);


            if (_userInput.UserChoice() == "1")
                backPack.TakeItems(cat, location);
            ReturnToMainPartOfRoom(location);
        }

        void ExploreNightStand()
        {
            Console.WriteLine(LocationText.ExploreNightStand);
            ListItemsInLocation("nightstand");
            Console.WriteLine(LocationText.ChoiceToTakeItemsNightStand);
            DecisionTime("nightstand");
        }

        void ExploreCloset()
        {
            Console.WriteLine(LocationText.ExploreCloset);
            ListItemsInLocation("closet");
            Console.WriteLine(LocationText.ChoiceToTakeItems);//changed this;
            DecisionTime("closet");
        }

        void ExploreBookshelf()
        {
            Console.WriteLine(LocationText.ExploreBookshelf);
            ListItemsInLocation("bookshelf");
            Console.WriteLine(LocationText.ChoiceToTakeItemsBookshelf);
            DecisionTime("bookshelf");
        }

        void ExploreHearth()
        {
            Console.WriteLine(LocationText.ExploreHearth);
            ListItemsInLocation("hearth");
            Console.WriteLine(LocationText.WouldYouLikeToTakeAnything);
            DecisionTime("hearth");
        }


        void ExploreWindow()
        {
            Console.Clear();
            Console.WriteLine(LocationText.ExploreWindow);
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
                        Console.WriteLine(LocationText.HowToProceedWithSheetsAndRope);
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
                            Console.WriteLine(LocationText.MakeAChoiceWithSheets);
                        if (hasRope)
                            Console.WriteLine(LocationText.MakeAChoiceWithRope);

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
                        Console.WriteLine(LocationText.MakeChoiceNoSheetsOrRope);
                        Console.WriteLine(LocationText.CatBorder1);
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
            Console.WriteLine(LocationText.CatBorder1);
            Console.WriteLine(LocationText.LeapDown);
            cat.Location = Characters.Place.PassedOut;
        }


        void UseSheets(string item = "sheets")
        {
            Console.WriteLine(LocationText.CatBorder1);
            if (item == "sheets")
                Console.WriteLine(LocationText.UseSheets);
            else if (item == "rope")
                Console.WriteLine(LocationText.UseRope);
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
                            Console.WriteLine(LocationText.ClimbDownSheets);
                        else
                            Console.WriteLine(LocationText.ClimbDownRope);
                        cat.Location = Characters.Place.OutsideCastle;
                    }
                    else
                    {
                        Console.WriteLine(LocationText.ClimbDownToLeap);
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
            Console.WriteLine(LocationText.CatBorder1 + "\n" + LocationText.ExploreDoor);
            Console.WriteLine("");
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
                //listing what you find
                Console.WriteLine(LocationText.AtDoorCheckInventoryHavePickAndSS);
                if (hasStone)
                    Console.WriteLine(LocationText.AtDoorAlsoHaveStone);
                if (hasShield)
                    Console.WriteLine(LocationText.AtDoorAlsoHaveShield);

                //setting up options
                Console.WriteLine(LocationText.OptionsAtDoorHavePickAndSS);

                if (hasStone && hasShield)
                {
                    Console.WriteLine(LocationText.OptionsAtDoorHaveStoneAndShield);
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
                                UseStone();
                            else
                                UseShield();
                        else if (hasShield)
                            UseShield();
                        else
                            UseStone();
                        break;
                }
            }


            else if (hasStone && hasShield)
            {
                Console.WriteLine(LocationText.AtDoorCheckInventoryHaveSS);
                switch (_userInput.UserChoice(3))
                {
                    case "1":
                        UseStone();
                        break;
                    case "2":
                        UseShield();
                        break;
                    case "3":
                        ReturnToMainPartOfRoom("door");
                        break;
                }
            }


            else if (hasLockPick)
            {
                Console.WriteLine(LocationText.AtDoorCheckInventoryHavePick + "\n" + LocationText.CatBorder1);
                if (_userInput.UserChoice() == "1")
                    PickLock();
                else
                    ReturnToMainPartOfRoom("door");
            }


            else if (hasShield)
            {
                Console.WriteLine(LocationText.AtDoorCheckInventoryHaveShield + "\n" + LocationText.CatBorder1);
                if (_userInput.UserChoice() == "1")
                    UseShield();
                else
                    ReturnToMainPartOfRoom("door");
            }
            else if (hasStone)
            {
                Console.WriteLine(LocationText.AtDoorCheckInventoryHaveStone + "\n" + LocationText.CatBorder1);
                if (_userInput.UserChoice() == "1")
                    UseStone();
                else
                    ReturnToMainPartOfRoom("door");
            }
            else
            {
                Console.WriteLine(LocationText.AtDoorCheckInventoryFindNothing);
                _userInput.DramaticPause();
                ReturnToMainPartOfRoom("door");
            }
        }

        /* here's the flow:
        - stone is similiar but no pass out, only damage OR it works
        - shield can break OR work
        */
        void UseStone()
        {
            Console.WriteLine(LocationText.CatBorder3 + "\n" + LocationText.UseStoneOnDoor);
            _userInput.DramaticPauseClrScreen();
            int roll = rnd.Next(1, 21);
            Console.WriteLine($"You rolled a {roll}");
            if (roll > 16)
            {
                Console.WriteLine(LocationText.StoneOrShieldWorked);
                _userInput.DramaticPause();
                cat.Location = Characters.Place.ThirdFloor;
            }
            else
            {
                roll = rnd.Next(1, 7) + 1;
                Console.WriteLine($"The stone bounces off the door and ricochets back towards you doing " +
                                  $"{roll} (D6+1) damage");
                cat.Health -= roll;
                Console.WriteLine($"Your health is now {cat.Health} out of 60");
                _userInput.DramaticPauseClrScreen();
                ReturnToMainPartOfRoom("door");
            }
        }

        void UseShield()
        {
            Console.WriteLine(LocationText.CatBorder3 + "\n" + LocationText.UseShieldOnDoor);
            _userInput.DramaticPause();
            int roll = rnd.Next(1, 21);
            Console.WriteLine($"You rolled a {roll}");
            if (roll > 25)
            {
                Console.WriteLine(LocationText.StoneOrShieldWorked);
                _userInput.DramaticPause();
                cat.Location = Characters.Place.ThirdFloor;
            }
            else if (roll > 24)
            {
                roll = rnd.Next(1, 7) + 1;
                Console.WriteLine($"The shield bounces off the door and ricochets back towards you doing " +
                                  $"{roll} (D6+1) damage");
                cat.Health -= roll;
                Console.WriteLine($"Your health is now {cat.Health} out of 60");
                _userInput.DramaticPauseClrScreen();
                ReturnToMainPartOfRoom("door");
            }
            else
            {
                Console.WriteLine(LocationText.ShieldBrakes);
                _userInput.DramaticPauseClrScreen();

                for (var i = 0; i < backPack.Pack.Length; i++)
                {
                    if (backPack.Pack[i].Contains("shield"))
                        backPack.Pack[i] = "empty";
                }
                ReturnToMainPartOfRoom("door");
            }
        }


        void PickLock()
        {
            Console.WriteLine(LocationText.UsePickOnDoor + "\n" + LocationText.CatBorder1);
            _userInput.DramaticPause();
            cat.Location = Characters.Place.ThirdFloor;
        }
    }
}