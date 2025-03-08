namespace CatsAndCastles1;

public class LocationText
{
    
    
    public const string CatBorder1 =    
        "\n\n   -   -   -   -   -   -   -   -   =^.^=   -   -   -   -   -   -   -   -   -   -   \n";

    public const string CatBorder2 =
        "\n\n   <   <   <   <   <   <   <   <   =^.^=   >   >   >   >   >   >   >   >   >   \n";

    public const string CatBorder3 =
        "\n   >   >   >   >   >   >   >   >   =^.^=   <   <   <   <   <   <   <   <   <   \n";

    public const string IntroCutScene = "Greetings, adventurer. The night has been long and unkind, and your " +
                                        "memories of it are little more than a haze. " +
                                        "\n\nYou wake, dazed and disoriented, your senses slow to return as you " +
                                        "instinctively groom your soft coat. A quick glance reveals your trusty pack — a " +
                                        "container meant to carry up to five treasures. Yet as you inspect it, your heart sinks: " +
                                        "it is empty.";

    public const string StartInRoom = "The air is damp and heavy, thick with the scent of old stone and something " +
                                      "faintly metallic. A chill clings to your fur, creeping in from the cold " +
                                      "stone floor beneath you. The dim light from a single flickering torch casts long, " +
                                      "wavering shadows across the chamber, making the jagged cracks in the walls " +
                                      "seem to shift and writhe. " +
                                      "\n\nThe hairs along your spine bristle. Something about this place feels wrong, " +
                                      "as though unseen eyes watch from the darkness, waiting. " +
                                      "\n\nYou must escape but are unsure where to begin." +
                                      "\n\nPress 'enter' to continue." +
                                      "\n\n   >   >   >   >   >   >   >   >   =^.^=   <   <   <   <   <   <   <   <   <   \n";

    public const string SubsequentWakeUp = "You wake, dazed and disoriented, your senses slow to return. ";

    public const string FirstRoomChoices =
        "Your eyes scan the room, taking in the details of your surroundings. " +
        "\n\nA few places stand out, each offering a chance to learn more: \n";

    public const string ExitDoor = "A heavy wooden door, its iron hinges rusted with age.";
    public const string ClosetDoor = "A second smaller wooden door, it looks as if it has seen little use.";
    public const string WindowOption = "A window, just high enough to reach with a careful leap.";
    public const string NightStandOption = "The nightstand, small but perhaps hiding something useful.";
    public const string BookshelfOption = "The bookshelf, mostly bare, its empty shelves coated in dust.";
    public const string HearthOption = "A large stone hearth, cold and imposing.";
    public const string PackOption = "Your pack. You can inspect the contents and discard ones you no longer want.";
     

    public const string DiscardRevisitOption = "Item/s you’ve chosen to discard — perhaps too hastily."; 
        

    

    public const string DiscardPileMultiItems = "8 - A heap of items you’ve chosen to discard—perhaps too hastily. " +
                                                "If you've changed your mind, you can return to the pile and reclaim items..";

    public const string WhereToExplore = "\n\nWhere would you like to explore?" +
                                         "\n\nPlease press the number corresponding with your choice." +
                                         "\n\n   <   <   <   <   <   <   <   <   =^.^=   >   >   >   >   >   >   >   >   >   \n";

    public const string UseOrRemoveFirstItem = "Would you like to use or remove any items?" +
                                               "\nPlease press '1' to remove an item and '2' to continue exploring the room";

    public const string UseOrRemoveMoreItems = "Would you like to use or remove another item?" +
                                               "\n Press '1' to remove another item and '2' to continue exploring the room";

    public const string TakeItemsOrLeaveRoom =
        "Please press '1' if you'd like to take some items with you and '2' if you'd like to " +
        "leave all the items untouched.";

    public const string ExploreNightStand = "Your eyes land on the nightstand — a small, unassuming piece of " +
                                            "furniture beside the cushion where you first woke up. Its surface " +
                                            "is scratched, its single drawer slightly ajar, as if someone once " +
                                            "meant to close it but never quite did.";

    public const string PrepToListItems = "\nYou find the following item/s that might be helpful:\n";

    public const string ChoiceToTakeItemsNightStand =
        "\nThe drawer holds no more secrets, only the question of whether " +
        "any of these things might be useful to you." +
        "\n\nWould you like to take anything?";

    public const string ExploreCloset =
        "You move toward the small door on the opposite wall, its wood worn and cracked. " +
        "It creaks loudly as you push it open, revealing a narrow, dim space. " +
        "Upon stepping inside, you realize this is a closet. The air is stale, thick with dust.";
    
    public const string ExploreBookshelf = "You approach the bookshelf, your paws silent against the cold floor. " +
                                           "It stands tall against the wall, its once-polished wood " +
                                           "now dull and splintered. Most of the shelves are bare, coated in dust thick enough " +
                                           "to leave tracks.";

    
    public const string ExploreHearth = "Your gaze drifts to the hearth—large and cold, its once-grand stonework now " +
                                        "stained with time.";
    public const string ChoiceToTakeItems =
        "Each item has its own allure, yet you know that adding too much to your pack could slow you down. " +
        "You also have the option to leave this location without taking anything, knowing you can always return " +
        "later if desired... ";

    public const string WhatDoYouWantToTake = "Which items would you like to take with you?";

    public const string NothingLeft =
        "You've scoured every nook and cranny of this area. Every hidden corner has been " +
        "examined, and every item of value has been claimed. There's nothing left here — this " +
        "location has been completely cleared.";

    public const string HowToPickAnItem = "Please use the \u001b[35mup\u001b[0m and \u001b[35mdown\u001b[0m arrow key to " +
                                     "navigate and press 'enter' to select.";
    
    public const string RemoveNothing = "do not remove any items";
    public const string PickUpNothing = "leave all the items as they are";
    public const string LeaveLocation = "leave this location";
    public const string EmptyStash = "There are no items in your discard stash.";
    public const string EmptyInventory = "There are no items in your inventory.";

    public const string PickUpFromStash = "You study your discard stash, taking in all the items you've left behind. " +
                                          "Some might still be useful on your journey.";

    public const string ThinkAboutInventory =
        "You take a moment to review the contents " +
        "of your pack, weighing the value of each item. Some may no longer serve your journey " +
        "as well as others, and space is precious since you can only carry 5 items.";

    public const string InsufficientFunds = "You don't have enough funds for this transaction";
        
    
    public const string ChoiceToTakeItemsBookshelf =
        "\nThe air here is still, as though these objects have been waiting undisturbed for a " +
        "long time.\n\nWould you like to take anything with you?";

    

    public const string ExploreWindow =
        "\n\n   -   -   -   -   -   -   -   -   =^.^=   -   -   -   -   -   -   -   -   -   -   \n" +
        "\n\nYou move toward the window, and as you draw closer, the suffocating weight of " +
        "the castle's gloom seems to ease—if only slightly. Springing forward you leap " +
        "onto the sill and peer outside. Below, the ground looms a daunting thirty or more feet " +
        "down, bathed in the pale glow of the moon. A fall from this height would be dangerous, " +
        "but not impossible." +
        "\n\nYour muscles tense as you consider your options. \n\nYou could take the leap, " +
        "relying on your feline agility and luck to land safely. Or you could check your " +
        "inventory for other options to assist you in climbing down. " +
        "The eerie stillness of the castle gnaws at your nerves, urging you to act quickly." +
        "\nPress '1' to check your inventory and '2' to leap down and '3' to continue exploring the room";

    public const string HowToProceedWithSheetsAndRope =
        "You check your inventory, searching for anything that might help. " +
        "You find a length of rope and several bed sheets that could be tied " +
        "together into a makeshift rope. " +
        "\n\nHow would you like to proceed?" +
        "\n'1' - Use the sheets." +
        "\n'2' - Use the rope." +
        "\n'3' - Jump directly down from the window ledge." +
        "\n'4' - Use the rope.";

    public const string MakeAChoiceWithSheets = "You find a pile of old sheets in your inventory. " +
                                                "You realize they could be tied together to make a rope to assist you in climbing down." +
                                                $"\n\nPress '1' to use the sheets to assist you, " +
                                                $"'2' to choose to leap down and '3' to continue exploring other areas " +
                                                "in the room.";

    public const string MakeAChoiceWithRope = "You find a 20 foot length of rope in your inventory. " +
                                              "You realize they could be tied together to make a rope to assist you in climbing down." +
                                              $"\n\nPress '1' to use the rope to assist you, " +
                                              $"'2' to choose to leap down and '3' to continue exploring other areas " +
                                              "in the room.";

    public const string MakeChoiceNoSheetsOrRope =
        "You take a deep breath and leap into the night, trusting your agility. For a brief " +
        "moment, you feel weightless—until you land with a jarring thud. The ground is " +
        "unforgiving, your 4 legs give way beneath you and your head smacks against the hard earth.";

    public const string LeapDown =
        "You take a deep breath and leap into the night, trusting your agility. For a brief " +
        "moment, you feel weightless—until you land with a jarring thud. The ground is " +
        "unforgiving, your 4 legs give way beneath you and your head smacks against the hard earth.";

    public const string UseSheets = "You reach into your pack and withdraw the worn but sturdy sheets. Working " +
                                    "quickly, you tie them together, each knot pulled tight between your claws. You find a solid " +
                                    "anchor — an iron ring embedded in the wall — and tie the sheets securely around it. " +
                                    "With a final, cautious tug, you toss the bundle out the window.";

    public const string UseRope = "You reach into your pack and withdraw the thick rope. You find a solid " +
                                  "anchor — an iron ring embedded in the wall — and tie the rope securely around it. " +
                                  "With a final, cautious tug, you toss the rope out the window.";

    public const string ClimbDownSheets = "You grip the knotted sheets tightly and ease yourself out the window, " +
                                          "claws scraping against the stone as you begin your descent. The fabric " +
                                          "creaks under your weight, but it holds as you inch lower, the cool night " +
                                          "air brushes against your fur." +
                                          "\n\n You reach the end of the rope and leap down. At last, your feet touch " +
                                          "the ground. ";

    public const string ClimbDownRope = "You grip the stiff rope tightly and ease yourself out the window, " +
                                        "claws scraping against the stone as you begin your descent. The rope " +
                                        "creaks under your weight, but it holds as you inch lower, the cool night " +
                                        "air brushes against your fur." +
                                        "\n\n You reach the end of the rope and leap down. At last, your feet touch " +
                                        "the ground. ";

    public const string ClimbDownToLeap = "You grip the knotted sheets tightly and ease yourself out the window, " +
                                          "claws scraping against the stone as you begin your descent. The fabric creaks " +
                                          "under your weight, but it holds as you inch lower, the cool night air brushing " +
                                          "against your fur.\n\nYou reach the end of your rope.";

    public const string ExploreDoor =
        "You approach the heavy wooden door, its frame dark and imposing against the stone wall." +
        "Your eyes are drawn to the thick, old lock hanging from the latch. " +
        "The lock looks sturdy, its cold metal catching the dim light. It's a formidable obstacle, " +
        "preventing you from escaping, but you know you must find a way out. " +
        "Would you like to search your inventory for tools or items that might aid in unlocking the door " +
        "or continue exploring the room?" +
        "\n\nPlease press '1' to search your inventory and '2' to return to exploring the room";

    public const string AtDoorCheckInventoryHavePickAndSS =
        "You pause and take a moment to look through your inventory, searching for " +
        "something that might help. Your paws sift through the items you’ve collected so " +
        "far, and you find two items that might be useful:" +
        "\n- A rusted set of tools—small, delicate rods and a hook that might be able to " +
        "fit into the lock, though they look far from reliable.";

    public const string AtDoorAlsoHaveStone =
        "- A heavy smooth rock, solid and weighty in your grasp. While not the most " +
        "subtle choice, it might be capable of smashing the lock off with a few good strikes.";

    public const string AtDoorAlsoHaveShield = "- A shield, its metal surface scratched and worn, but still sturdy. " +
                                               "It could be used to bash the lock off with brute force.";

    public const string OptionsAtDoorHavePickAndSS = "\nThe options sit before you. You can:" +
                                                     "\n'1' - Keep exploring the room, hoping for another way out or more supplies " +
                                                     "that might help. " +
                                                     "\n'2' - Attempt to pick the lock with the rusted tools.";

    public const string OptionsAtDoorHaveStoneAndShield = "'3' - Use the rock to smash the lock off." +
                                                          "\n'4' - Use the shield to smash the lock off.";

    public const string AtDoorCheckInventoryHaveSS =
        "You pause and take a moment to look through your inventory, searching for " +
        "something that might help. Your paws sift through the items you’ve collected so " +
        "far, and you find two items that might be useful:" +
        "\n- A heavy smooth rock, solid and weighty in your grasp. While not the most" +
        "\nsubtle choice, it might be capable of smashing the lock off with a few good strikes." +
        "\n- A shield, its metal surface scratched and worn, but still sturdy. " +
        "It could be used to bash the lock off with brute force." +
        "\n\nThe options sit before you. You can:" +
        "\n'1' - Use the rock to bash the lock off." +
        "\n'2' - Use the shield to smash the lock off. " +
        "\n'3' - Keep exploring the room, hoping for another way out or more supplies that might help";

    public const string AtDoorCheckInventoryHavePick =
        "You dig through your pack, your paws brushing over familiar items until you " +
        "feel something that might help. You pull out the rusted set of tools—small, " +
        "delicate rods of metal, a hook, and a flattened key-like piece. " +
        "Though worn and aged, they seem like they might fit together in some way. " +
        "\nWould you like to attempt to use them to pick the lock or would you like" +
        "to continue searching the room for other items that might help?" +
        "\n\nPlease press '1' to try to pick the lock with the rusted tools and " +
        "'2' to return to exploring the room";

    public const string AtDoorCheckInventoryHaveShield =
        "You dig through your pack, feeling the weight of each item, until your paw " +
        "brushes against something solid. You pull out the shield. " +
        "It feels solid in your grip, it might just be powerful enough to break the " +
        "lock off the door." +
        "\nThe lock seems secure, and the shield might be your only chance at forcing your way " +
        "through." +
        "\n\nPlease press '1' to try to use the shield to break the lock and " +
        "'2' to return to exploring the room";

    public const string AtDoorCheckInventoryHaveStone =
        "You dig through your pack, feeling the weight of each item, until your paw " +
        "brushes against something solid. You pull out a large stone, its surface smooth and " +
        "worn. It feels heavy in your grip, it might just be powerful enough to break the " +
        "lock off the door." +
        "\nThe lock seems secure, and the stone might be your only chance at forcing your way " +
        "through." +
        "\n\nPlease press '1' to try to use the large stone to break the lock and " +
        "'2' to return to exploring the room";

    public const string AtDoorCheckInventoryFindNothing =
        "You don't have any items in your inventory that can help you with the lock." +
        "\n\nYou are unable to open the door.";

    public const string UseStoneOnDoor = "You decide to try your luck with the stone. With a grunt, you lift it, " +
                                         "its weight heavy in your hands. You aim it carefully at the lock and swing with all " +
                                         "your might." +
                                         "\n\nRoll a D20 for luck to see if you can smash the lock off the door" +
                                         "\n\nYou need to roll higher than a 16 to be successful";

    public const string StoneOrShieldWorked =
        "You are victorious! The impact echoes as the metal shatters under your strike. The door creaks " +
        "open — your resourcefulness has paid off, and the path ahead is now clear";

    public const string UseShieldOnDoor =
        "You decide to try your luck with the battered shield. With a grunt, you lift it, " +
        "its weight heavy in your hands. You aim it carefully at the lock and swing with all " +
        "your might." +
        "\n\nRoll a D20 for luck to see if you can smash the lock off the door or if the door will destroy your shield" +
        "\n\nYou need to roll higher than a 16 to successfully break the lock." +
        "\nYou need to roll higher than a 5 to avoid ruining your shield.";

    public const string ShieldBrakes = "Lady luck did not favor you. The force of the impact reverberates through the " +
                                       "room, and in that critical moment, the shield can't take it — the blow " +
                                       "shatters it into splinters.";
    

    public const string UsePickOnDoor = "You carefully examine the rusty set of tools. With steady hands, " +
                                        "you select a small pick and a thin rod, using them to work the lock. The old lock " +
                                        "resists at first, but with a soft click, it finally gives way. " +
                                        "With a sigh of relief, you open the door slowly, careful not to make a sound.";
    
    
    
    
    
    public const string EmptySpot = "a faint outline marking the spot where something once rested";

    public const string NothingHere = "Nothing remains in this spot. Please make an alternate selection.";
    


}