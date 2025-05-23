using CatsAndCastles1.Characters;
using CatsAndCastles1.DisplayingText;
using CatsAndCastles1.Text;
using CatsAndCastles1.Text.Locations;

namespace CatsAndCastles1.UserInteractions;

public class UILockedRooms
{
    public int GetChoiceForLockedRoom(List<string> listOfItems)
    {
        int choiceNumber = UserInteractiveMenu.GiveChoices(listOfItems, TextGeneral.LeaveLockedDoor);
        return choiceNumber;
    }

    public bool UseStoneOnDoor(Character cat)
    {
        Screen.Print(TextDoorAndWindow.UseStoneOnDoor);
        UserInput.DramaticPause();
        int roll = Screen.DiceRoller(20);
        Screen.Print(TextGeneral.YourRoll + roll + "\n");
        if (roll > 16)
        {
            Screen.Print(TextDoorAndWindow.StoneOrShieldWorked);
            return true;
        }

        Screen.Print(TextDoorAndWindow.StoneDidntWork + TextDoorAndWindow.DetBluntObjectDamage);
        UserInput.DramaticPause();
        roll = Screen.DiceRoller(6) + 1;
        cat.Health -= roll;
        Screen.Print(TextGeneral.Damage + roll + "\n");
        Screen.Print(string.Format(TextGeneral.YourHealth,cat.Health, cat.MaxHealth));
        return false;
    }

    public bool UseShieldOnDoor(Character cat, string item, Inventory inventory)
    {
        Screen.Print(TextDoorAndWindow.UseShieldOnDoor);
        UserInput.DramaticPause();
        int roll = Screen.DiceRoller(20);
        Screen.Print(TextGeneral.YourRoll + roll + "\n");
        if (roll > 16)
        {
            Screen.Print(TextDoorAndWindow.StoneOrShieldWorked);
            return true;
        }

        if (roll < 6)
        {
            Screen.Print(TextDoorAndWindow.ShieldBreaks);
            inventory.Pack.Remove(item);
            cat.HasShield = false;
            return false;
        }


        Screen.Print(TextDoorAndWindow.ShieldDidntWork + TextDoorAndWindow.DetBluntObjectDamage);
        UserInput.DramaticPause();
        roll = Screen.DiceRoller(6) + 1;
        cat.Health -= roll;
        Screen.Print(TextGeneral.Damage + roll + "\n");
        Screen.Print(string.Format(TextGeneral.YourHealth, cat.Health, cat.MaxHealth));
        return false;
    }
}