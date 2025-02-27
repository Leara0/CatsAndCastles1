namespace CatsAndCastles1;

public static class Text
{
    public const string CatBorder1 =
        "\n\n   -   -   -   -   -   -   -   -   =^.^=   -   -   -   -   -   -   -   -   -   -   \n";

    public const string CatBorder2 =
        "\n\n   <   <   <   <   <   <   <   <   =^.^=   >   >   >   >   >   >   >   >   >   \n";

    public const string CatBorder3 =
        "\n   >   >   >   >   >   >   >   >   =^.^=   <   <   <   <   <   <   <   <   <   \n";

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
        "\nYour eyes scan the room, taking in the details of your surroundings. " +
        "\n\nA few places stand out, each offering a chance to learn more: " +
        "\n\n1 - A heavy wooden door, its iron hinges rusted with age." +
        "\n2 - A second smaller wooden door, it looks as if it has seen little use." +
        "\n3 - A window, just high enough to reach with a careful leap." +
        "\n4 - The nightstand, small but perhaps hiding something useful." +
        "\n5 - The bookshelf, mostly bare, its empty shelves coated in dust." +
        "\n6 - A large stone hearth, cold and imposing" +
        "\n7 - Your pack. You can inspect the contents and discard ones you no longer want";

    public const string DiscardPile1Item = "8 - An item you’ve chosen to discard — perhaps too hastily. " +
                                           "If you've changed your mind, you can return to the pile and reclaim it..";

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

    public const string ExploreNightStand = "Your eyes land on the nightstand—a small, unassuming piece of " +
                                            "furniture beside the cushion where you first woke up. Its surface " +
                                            "is scratched, its single drawer slightly ajar, as if someone once " +
                                            "meant to close it but never quite did." +
                                            "\n\nInside, you find:";

    public const string ChoiceToTakeItemsNightStand =
        "\nThe drawer holds no more secrets, only the question of whether " +
        "any of these things might be useful to you." +
        "\n\nWould you like to take anything?";

    public const string ExploreCloset =
        "You move toward the small door on the opposite wall, its wood worn and cracked. " +
        "It creaks loudly as you push it open, revealing a narrow, dim space." +
        "Upon stepping inside, you realize this is a closet. The air is stale, thick with dust." +
        "\n\nThe shelves are cluttered with the following items:";

    public const string ChoiceToTakeItemsCloset =
        "\nThis space hasn't been used in a long time—and whatever it was used for " +
        "doesn't seem welcoming. \n\nWould you like to take anything?";

    public const string ExploreBookshelf = "You approach the bookshelf, your paws silent against the cold floor. " +
                                           "It stands tall against the wall, its once-polished wood " +
                                           "now dull and splintered. Most of the shelves are bare, coated in dust thick enough " +
                                           "to leave tracks." +
                                           "\n\nScanning the empty spaces, your eyes catch a few forgotten objects:";

    public const string ChoiceToTakeItemsBookshelf =
        "\nThe air here is still, as though these objects have been waiting undisturbed for a " +
        "long time.\n\nWould you like to take anything with you?";

    public const string ExploreHearth = "Your gaze drifts to the hearth—large and cold, its once-grand stonework now " +
                                        "stained with time. \n\nAs you step closer, your paws stir the dust, revealing " +
                                        "forgotten things among the ashes and shadows:";

    public const string WouldYouLikeToTakeAnything = "Would you like to take anything?";

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

    public const string ClimbDownRope ="You grip the stiff rope tightly and ease yourself out the window, " +
                                       "claws scraping against the stone as you begin your descent. The rope " +
                                       "creaks under your weight, but it holds as you inch lower, the cool night " +
                                       "air brushes against your fur." +
                                       "\n\n You reach the end of the rope and leap down. At last, your feet touch " +
                                       "the ground. ";

    public const string ClimbDownToLeap = "You grip the knotted sheets tightly and ease yourself out the window, " +
                                          "claws scraping against the stone as you begin your descent. The fabric creaks " +
                                          "under your weight, but it holds as you inch lower, the cool night air brushing " +
                                          "against your fur.\n\nYou reach the end of your rope.";
}