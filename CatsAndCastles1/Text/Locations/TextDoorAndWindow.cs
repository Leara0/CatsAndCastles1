namespace CatsAndCastles1.Text.Locations;

public class TextDoorAndWindow
{
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
        "The door is unlocked - inviting you to pass through. What lies beyond " +
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
        "You don't have any items in your inventory that can help you with the lock.\n\nYou are unable to open the door.";

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
        "the door and strikes you squarely on the head.";

    public const string StoneEndOfDamage = " damage (D6 +1). ";

    public const string DetBluntObjectDamage =
        "\n\nTo determine the damage the stone inflicts roll a D6 (damage will be 1D6+1)";


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
        "the door and strikes you squarely on the head.";

    public const string ShieldBreaks =
        "Lady luck did not favor you. The force of the impact reverberates through the " +
        "room, and in that critical moment, the shield can't take it — the blow " +
        "shatters it into splinters.\n\nThis shield has been removed from your inventory.";


    public const string UsePickOnDoor = "You carefully examine the rusty set of tools. With steady paws, " +
                                        "you select a small pick and a thin rod, using them to work the lock. The old lock " +
                                        "resists at first, but with a soft click, it finally gives way. " +
                                        "With a sigh of relief, you open the door slowly, careful not to make a sound.";

    public const string UseKeysOnDoor =
        "You stand before the door, ring of keys in paw. With a mix of hope and careful precision, " +
        "you select a few keys and try them one by one. At last, a slender key seems to fit perfectly. " +
        "You slide it into the lock, turning it slowly as you listen to the tumblers shift. A series " +
        "of soft clicks fills the silence, and with a gentle creak, the door swings open — revealing what lies beyond.";

    public const string ApproachDoor =
        "You approach the wooden door, its frame dark and imposing against the stone wall. " +
        "Your eyes are drawn to the thick, old lock hanging from the latch. " +
        "The lock looks sturdy, its cold metal catching the dim light. It's a formidable obstacle, " +
        "preventing you from venturing through, but you feel you must find a way. ";

}