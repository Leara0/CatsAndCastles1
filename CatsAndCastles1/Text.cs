namespace CatsAndCastles1;

public class Text
{
    #region Borders
    public const string CatBorder1 =
        "   -   -   -   -   -   -   -   -   =^.^=   -   -   -   -   -   -   -   -   -   -   \n";

    public const string CatBorder2 =
        "\n\n   <   <   <   <   <   <   <   <   =^.^=   >   >   >   >   >   >   >   >   >   \n";

    public const string CatBorder3 =
        "\n   >   >   >   >   >   >   >   >   =^.^=   <   <   <   <   <   <   <   <   <   \n";
    #endregion

    #region intro fluff

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
                                      "\n\n   >   >   >   >   >   >   >   >   =^.^=   <   <   <   <   <   <   <   <   <   \n";

    public const string SubsequentWakeUp = "You wake, dazed and disoriented, your senses slow to return. ";

    #endregion

    #region MainRoom texts

    public const string FirstRoomChoices =
        "Your eyes scan the room, taking in the details of your surroundings. " +
        "\n\nA few places stand out, each offering a chance to learn more: \n";

    public const string ExitDoor = "A heavy wooden door, its iron hinges rusted with age.";
    public const string ClosetDoor = "A second smaller wooden door, it looks as if it has seen little use.";
    public const string WindowOption = "A window, just high enough to reach with a careful leap.";
    public const string NightStandOption = "The nightstand, small but perhaps hiding something useful.";
    public const string BookshelfOption = "The bookshelf, mostly bare, its empty shelves coated in dust.";
    public const string HearthOption = "A large stone hearth, cold and imposing.";

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

    public const string ExploreNightStand = "Your eyes land on the nightstand — a small, unassuming piece of " +
                                            "furniture beside the cushion where you first woke up. Its surface " +
                                            "is scratched, its single drawer slightly ajar, as if someone once " +
                                            "meant to close it but never quite did.";

    #endregion

    #region inventory and discard textx

    public const string PackOption = "Your pack. You can inspect the contents and discard ones you no longer want.";

    public const string DiscardRevisitOption = "Item/s you’ve chosen to discard — perhaps too hastily.";

    public const string PrepToListItems = "\nYou find the following item/s that might be helpful:\n";

    public const string ChoiceToTakeItems =
        "Each item has its own allure, yet you know that adding too much to your pack could slow you down. " +
        "You also have the option to leave this location without taking anything, knowing you can always return " +
        "later if desired... ";

    public const string NothingLeft =
        "You've scoured every nook and cranny of this area. Every hidden corner has been " +
        "examined, and every item of value has been claimed. There's nothing left here — this " +
        "location has been completely cleared.";

    public const string EmptyStash = "There are no items in your discard stash.";
    public const string EmptyInventory = "There are no items in your inventory.";

    public const string PickUpFromStash = "You study your discard stash, taking in all the items you've left behind. " +
                                          "Some might still be useful on your journey.";

    public const string ThinkAboutInventory =
        "You take a moment to review the contents " +
        "of your pack, weighing the value of each item. Some may no longer serve your journey " +
        "as well as others, and space is precious since you can only carry 5 items.";

    public const string InsufficientFunds = "You don't have enough funds for this transaction";

    #endregion

    public const string HowToPickAnItem =
        "Please use the \u001b[35mup\u001b[0m and \u001b[35mdown\u001b[0m arrow key to " +
        "navigate and press 'enter' to select.";

    public const string RemoveNothing = "do not remove any items";
    public const string PickUpNothing = "leave all the items as they are";
    public const string LeaveLocation = "leave this location";
    public const string LeaveLockedDoor = "leave the door alone and explore other areas instead";

    #region Door and Window Text

    public const string ExploreWindow =
        "   -   -   -   -   -   -   -   -   =^.^=   -   -   -   -   -   -   -   -   -   -   \n" +
        "\n\nYou move toward the window, and as you draw closer, the suffocating weight of " +
        "the castle's gloom seems to ease—if only slightly. Springing forward you leap " +
        "onto the sill and peer outside. Below, the ground looms a daunting thirty or more feet " +
        "down, bathed in the pale glow of the moon. A fall from this height would be dangerous, " +
        "but not impossible." +
        "\n\nYour muscles tense as you consider your options. \n\nYou could take the leap, " +
        "relying on your feline agility and luck to land safely. Or you could check your " +
        "inventory for other options to assist you in climbing down. If your inventory is lacking you " +
        "might need to search other parts of the castle for an item to assist you. " +
        "The eerie stillness of the castle gnaws at your nerves, urging you to act quickly.";


    public const string OpenDoor =
        "You approach the wooden door, its frame dark and imposing against the stone wall. " +
        "The door is unlocked - inviting you to pass through. The mystery of what lies beyond" +
        "is about to be revealed.";

    public const string LeapDown =
        "You take a deep breath and leap into the night, trusting your agility. For a brief " +
        "moment, you feel weightless—until you land with a jarring thud. The ground is " +
        "unforgiving, your 4 legs give way beneath you and your head smacks against the hard earth.";

    public const string ClimbDownRope = "You grip the stiff rope tightly and ease yourself out the window, " +
                                        "claws scraping against the stone as you begin your descent. The rope " +
                                        "creaks under your weight, but it holds as you inch lower, the cool night " +
                                        "air brushes against your fur." +
                                        "\n\n You reach the end of the rope and leap down. At last, your feet touch " +
                                        "the ground. ";

    public const string AtDoorCheckInventory =
        "You pause and take a moment to look through your inventory, searching for " +
        "something that might help. Your paws sift through the items you’ve collected so " +
        "far.\n";

    public const string AtWindowCheckInventory =
        "You pause and take a moment to look through your inventory, searching for " +
        "something that might help. Your paws sift through the items you’ve collected so " +
        "far. \n";

    public const string AtWindowCheckInventoryFindNothing =
        "You don't have any items in your inventory that can help you climb down the wall. You must decide between " +
        "jumping down and leaving the window to continue exploring other areas inside the castle.";

    public const string AtDoorCheckInventoryFindNothing =
        "You don't have any items in your inventory that can help you with the lock." +
        "\n\nYou are unable to open the door.";

    public const string WindowOptions = "You have the following options:";

    public const string LockPickWontWork = "With practiced precision, you pull out your set of tools — a collection " +
                                           "that has served you well already. Your claws work the tools inside the " +
                                           "lock’s mechanism, but no matter how carefully you manipulate them, " +
                                           "the lock remains stubbornly sealed.";

    public const string KeysWontWork =
        "You stand before the locked door, the ring of keys from the guard's body clutched firmly " +
        "in your paw. One by one, you try each key, inserting them into the lock with careful " +
        "precision. However, none of the keys seem to fit — the mechanism refuses to yield, and " +
        "the tumblers won't align.It appears the keys you gathered were meant for other locks " +
        "in the castle - this door remains locked.";

    public const string UseStoneOnDoor = "You decide to try your luck with the stone. With a grunt, you lift it, " +
                                         "its weight heavy in your hands. You aim it carefully at the lock and swing with all " +
                                         "your might." +
                                         "\n\nRoll a D20 for luck to see if you can smash the lock off the door" +
                                         "\n\nYou need to roll higher than a 16 to be successful\n";

    public const string StoneOrShieldWorked =
        "You are victorious! The impact echoes as the metal shatters under your strike. The door creaks " +
        "open — your resourcefulness has paid off, and the path ahead is now clear";

    public const string StoneDidntWork =
        "You heft a the heavy stone in your paw, determined to smash the stubborn lock with brute force. " +
        "With a fierce swing, you bring the stone down upon the door. But the lock proves resilient — it " +
        "deflects the stone with a sharp, unexpected bounce. In a split second, the stone ricochets off " +
        "the door and strikes you squarely on the head." +
        "\n\nThe stone does ";

    public const string StoneEndOfDamage = " damage (D6 +1). ";


    public const string UseShieldOnDoor =
        "You decide to try your luck with the battered shield. With a grunt, you lift it, " +
        "its weight heavy in your hands. You aim it carefully at the lock and swing with all " +
        "your might." +
        "\n\nRoll a D20 for luck to see if you can smash the lock off the door or if the door will destroy your shield" +
        "\n\nYou need to roll higher than a 16 to successfully break the lock." +
        "\nYou need to roll higher than a 5 to avoid ruining your shield.";

    public const string ShieldDidntWork =
        "You heft a the heavy shield in your paw, determined to smash the stubborn lock with brute force. " +
        "With a fierce swing, you bring the shield down upon the door. But the lock proves resilient — it " +
        "deflects the shield with a sharp, unexpected bounce. In a split second, the shield ricochets off " +
        "the door and strikes you squarely on the head." +
        "\n\nThe shield does ";

    public const string ShieldBreaks =
        "Lady luck did not favor you. The force of the impact reverberates through the " +
        "room, and in that critical moment, the shield can't take it — the blow " +
        "shatters it into splinters.\n\nThis shield has been removed from your inventory.";


    public const string UsePickOnDoor = "You carefully examine the rusty set of tools. With steady hands, " +
                                        "you select a small pick and a thin rod, using them to work the lock. The old lock " +
                                        "resists at first, but with a soft click, it finally gives way. " +
                                        "With a sigh of relief, you open the door slowly, careful not to make a sound.";

    public const string UseKeysOnDoor =
        "You stand before the door, ring of keys in paw. With a mix of hope and careful precision, " +
        "you select a few keys and try them one by one. At last, a slender key seems to fit perfectly. " +
        "You slide it into the lock, turning it slowly as you listen to the tumblers shift. A series " +
        "of soft clicks fills the silence, and with a gentle creak, the door swings open — revealing what lies beyond.";

    public const string ApproachDoor =
        "You approach the wooden door, its frame dark and imposing against the stone wall." +
        "Your eyes are drawn to the thick, old lock hanging from the latch. " +
        "The lock looks sturdy, its cold metal catching the dim light. It's a formidable obstacle, " +
        "preventing you from venturing through, but you feel you must find a way. ";

    #endregion

    public const string YourRoll = "You rolled: ";

    public const string YourHealth = "Your current health is ";
    public const string OutOfTotalHealth = " out of ";

    #region Third Floor

    public const string ThirdFloorEntrance =
        "You slip into a dimly lit hallway. It's short and narrow, with three doors to your right, " +
        "one slightly ajar. The stairway to your left leads downward, offering a potential escape — but " +
        "the air is thick with uncertainty.";

    public const string ThirdFloorTreeHeading = "Do you approach one of the other doors to uncover what lies " +
                                                "beyond? Do you descend the stairs, venturing deeper into the castle? " +
                                                "Or do you return to the room you first escaped from?";

    public const string ReturnToMainRoomOption =
        "Return to the room from whence you came. You now see the door is marked 1";

    public const string ThirdFloorDoor2Option = "Approach the large worn door, marked with the number 2.";
    public const string ThirdFloorDoor3Option = "Approach the door that is standing ajar, marked with a 3.";
    public const string ThirdFloorDoor4Option = "Approach the room at the end of the hallway, marked with a faded 4.";
    public const string HeadDownStairsOption = "Head down the spiral staircase.";

    public const string ReEnterMainRoom =
        "You turn back toward the door you first escaped from, the worn wood familiar " +
        "beneath your paws. Pushing it open, you step inside once more. The room is " +
        "just as you left it — dim, old, and eerily silent.";

    //which doors are locked????
    public const string ExploreStudyF3D2 = 
        "You quietly step into the room and find that a large wooden desk dominates the space, its surface covered in " +
        "scattered papers, ink stains, and an open book with faded writing. A single chair has been pushed back as if " +
        "someone left in a hurry. A half-burned candle sits in a brass holder, melted wax pooled beneath it.";

    public const string ExploreBedroomF3D3 = //second bedroom
        "You pad inside, your steps light against the floor. A thin layer of dust coats everything, undisturbed for " +
        "quite some time. The bed is unmade, its blankets " +
        "tangled and stiff with age. A cracked mirror hangs on the wall, reflecting the dim light of the hallway.";

    public const string ExploreClosetF3D4 = //storage closet
        "You slink through the entrance, moving with practiced stealth. Inside you find a cramped, musty space filled " +
        "with dust and cobwebs - likely a storage closet of some sort. Wooden shelves line the walls, though most of " +
        "them are empty or hold long-forgotten clutter.";

    public const string HeadDownStairs =
        "You feel you’ve explored enough for now. The stairway at the end of the hall " +
        "beckons, offering the chance to move closer to freedom. " +
        "\n\nWith a soft sigh, you make your way to the stairs, each step taking you " +
        "closer to your goal. This floor fades into the shadows behind you as you " +
        "descend, the stairwell opens up to new, uncertain territory.";

    #endregion

    public const string FinishExploringInHall = "Feeling finished with this room, you step back into the hallway.";

    #region SecondFloor
    public const string ExploreMeetingRoomF2R1 = //meeting room  
        "You creep into the room, ears perked for any sign of danger. You find a long wooden table dominates the center " +
        "of the room, its surface scarred with knife marks and old stains. " +
        "Chairs are haphazardly arranged, some knocked over. A single candle, long burned out, rests in an iron holder.";

    public const string ExploreGuardRoomF2R2 = //guard's quarters
        "The smell of sweat and old leather lingers in the air. As you look around the room you notice several crude " +
        "cots are pushed against the walls, and a nearly empty weapons rack stands in the corner.";

    public const string ExploreClosetF2R3 = //storage closet 
        "You slink into the darkness, muscles poised to react. You find a cramped space, though this one looks as if it " +
        "was ransacked recently. The shelves are in disarray, and the floor is littered with broken crates.";

    public const string ExploreLibraryF2R4 = //library
        "You step across the threshold, careful to stay unnoticed. The scent of old parchment and dried ink fills the air. " +
        "Towering bookshelves line the walls, many of them missing books or sagging under the weight of their forgotten knowledge.";
    #endregion

    public const string ExploreFirstFloor = "";


    #region Dealing With Guard

    public const string DealtWithGuard = "You have dealt with the guard and now must choose you're next move.";

    #endregion
    
    #region Inventory Items
    public const string TwoSheetsDesc =  "Several folded bed sheets, their fabric yellowed but sturdy.";
    public const string TwoSheets = "2 sets of sheets";
    public const string BroomAndDustPanDesc = "A broom and dustpan that lean against the far wall, unused for " +
                                          "what seems like years.";
    public const string BroomAndDustPan = "the broom and dustpan";
    public const string ManaclesDesc = "A set of manacles, their chains coiled and rusted, almost blending into " +
                                       "the shadowy corner.";

    public const string Manacles = "the set of manacles";
    public const string TenCoinsDesc = "Ten gold coins, their surfaces dull with age but still carrying a " +
                                       "reassuring weight.";

    public const string TenCoins = "10 gold coins";
    public const string GlassesDesc = "A pair of glasses, their lenses smudged with dust, the frames bent slightly " +
                                      "out of shape.";
    public const string Glasses = "a pair of glasses";
    public const string BookOfPrayersDesc = "A book of prayers, its leather cover cracked with age, the pages thin and delicate.";
    public const string BookOfPrayers = "a book of prayers";
    public const string DaggerDesc = "A dagger, its handle wrapped in worn leather, the blade dull but still sharp enough to be dangerous.";
    public const string Dagger = "the dagger";
    public const string LockPickSetDesc = "A small, rusted set of tools — a few thin rods of metal, a hook, and something " +
                                          "resembling a flattened key. They seem out of place, their purpose unclear at " +
                                          "first, though their delicate shapes suggest they might fit into something " +
                                          "small and stubborn.";

    public const string LockPickSet = "the set of tools";
    public const string CatFigurineDesc = "A wooden figurine, carved in the shape of a cat. It’s crude but detailed enough " +
                                          "to capture the curve of a tail and the prickle of carved fur along its back. " +
                                          "The eyes, once painted, have long since faded, leaving behind empty impressions in the wood.";
    public const string CatFigurine = "the cat figurine";
    public const string FirePokerDesc = "A fire poker, its iron worn smooth from years of use, still sturdy " +
                                        "enough to be a weapon or a tool.";
    public const string FirePoker = "the fire poker";
    public const string LargeStoneDesc = "A large, loose stone, sitting slightly askew among the others. Heavier than " +
                                         "it looks, it would be perfect for smashing something stubborn.";
    public const string LargeStone = "the large stone";
    public const string BatteredShieldDesc = "A shield, nearly invisible at first, hidden beneath layers of dust and cobwebs. " +
                                             "Its wood is worn, its emblem barely discernible, but it remains solid—built " +
                                             "to withstand blows.";
    public const string BatteredShield = "the battered shield";
    public const string RingOfKeysDesc = "A ring carrying several small keys that might help you escape or uncover other " +
                                         "useful items along your journey.";

    public const string RingOfKeys = "the ring of keys";
    public const string CrudeShieldDesc ="a crude but sturdy shield";
    public const string CrudeShield = "the crude shield";
    public const string LongDaggerDesc = "A slender dagger with an extended blade, perfect for precise, stealthy strikes.";
    public const string LongDagger = "the long dagger";
    
    public const string GlassVialDesc = "A delicate vial filled with a glowing liquid that shifts between blue " +
                                        "and green hues—promising and restorative.";
    public const string GlassVial = "the glass vial";
    public const string TwelveCoinsDesc = "A set of coins with a rough, matte finish—evidence of long use.";//@TODO make money trackable again
    public const string TwelveCoins = "12 gold coins";
    public const string ThirteenCoinsDesc = "A handful of gold coins with intricate engravings that gleam invitingly.";
    public const string ThirteenCoins = "13 gold coins";
    public const string TwentyCoinsDesc = "A handful of coins with intricate designs, now dulled by time.";
    public const string TwentyCoins = "20 gold coins";
    public const string CatCollarDesc = "A simple, worn collar that once belonged to a feline; now, it's little more than a sentimental trinket.";
    public const string CatCollar = "the cat collar";
    public const string DogStatueDesc = "A small, carved statue of a dog—more ornamental than practical, serving as a quiet reminder of danger.";
    public const string DogStatue = "the dog statue";
    public const string ShieldDesc = "A battered shield marked by past battles; it may still offer vital protection.";
    public const string Shield = "the shield";
    public const string RopeDesc = "A sturdy length of rope that might aid you in climbing down from a window or navigating obstacles.";
    public const string Rope = "the rope";
    public const string ShortSwordDesc = "A compact, well-balanced blade, perfect for swift, decisive strikes.";
    public const string ShortSword = "the short-sword";
    public const string WorryBeadsDesc = " A string of polished beads that offer a calming, rhythmic clack when held.";
    public const string WorryBeads = "the worry beads";
    public const string DogWhistleDesc = "A simple metallic whistle that emits a faint, unimpressive sound, likely of little practical use.";
    public const string DogWhistle = "the dog whistle";
    public const string LoafOfBreadDesc = "A crusty, hearty loaf that, despite its age, smells inviting and promises nourishment.";
    public const string LoafOfBread = "the loaf of bread";
    public const string CatWantedPosterDesc = "A worn poster shows a rough sketch of a cat: \"WANTED – THEFT & MISCHIEF.\"";
    public const string CatWantedPoster = "the cat wanted poster";
    public const string RustedLanternDesc = "A rusted lantern with no oil.";
    public const string RustedLantern = "the rusted lantern";
    public const string DiceDesc = "A set of dice – one is chipped, the other is missing dots";
    public const string Dice = "the dice";
    public const string DustyBookDesc = "A dusty book, the title is faded, and the pages are brittle.";
    public const string DustyBook = "the dusty book";
    public const string CandleStubDesc = "A candle stub - melted wax clings to the base.";
    public const string CandleStub = "the candle stub";

    #endregion

}