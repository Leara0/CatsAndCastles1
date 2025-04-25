using CatsAndCastles1.Lists;

namespace CatsAndCastles1.UserInteractions;

public class UIGuard
{
    // this will be a method to get the user's choice for what action to do
    //I'm using this method so the bribe option includes the amount of gold in your purse
    public static int GetActionChoice(Inventory inventory)
    {
        var listOfOptions = ListGuardSpecificText.CreateBribeOptionsList(inventory);
        int choice = UserInteractiveMenu.GiveChoices(listOfOptions);
        return choice;
    }
    /*string ChooseGuardDogWeapon()
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
           Screen.Print("You quickly check your inventory, assessing what you have and what might help you in " +
                             "battle?\n");
           if (backPack.NumberOfItemsInPack() == 0)
           {
               Screen.Print("Your pack is empty. Your only choice is to fight with your paws: D4 +0");
               return ["paws", ""];
           }


           for (int i = 0; i < backPack.Pack.Length; i++) // shows inventory with weapons modifiers
           {
               //if (backPack.Pack[i] == "") // i'm pretty sure this code is obsolete
               //    backPack.Pack[i] = "empty";
               int[] weaponStats = weapon.WeaponChoice(backPack.Pack[i]);
               Screen.Print($"{i + 1} - {backPack.Pack[i]}: D{weaponStats[0]} +{weaponStats[1]}");
           }


           Screen.Print(
               "\nChoose your weapon wisely. Enter the number of the item you wish to wield in this fight.");


           int response = int.Parse(_userInput.UserChoice(backPack.Pack.Length));
           string choice = backPack.Pack[response - 1];


           if (backPack.Pack[response - 1] == "empty")
           {
               Screen.Print("You chose nothing. You will now fight with your paws: D4 +0");
               choice = "paws";
           }


           if (weapon.WeaponChoice(choice)[0] == 0)
           {
               Screen.Print(
                   $"Your paws are more deadly than {choice}. You wisely choose to fight with your paws: D4 +0");
               choice = "paws";
           }
           else
               Screen.Print($"You have chosen to fight with {choice}.");


           var hasShield = "";
           bool shieldInPack = false;
           foreach (var item in backPack.Pack)
           {
               if (weapon.DefenseChoice(item) == 2)
                   shieldInPack = true;
           }


           if (shieldInPack)
           {
               Screen.Print("\nYour pack holds a shield — it would offer +1 protection in this fight, but its " +
                                 "weight might slow you down, making you less agile. Do you want to use it in this fight?");
               Screen.Print("\nPlease press '1' if you'd like to use the shield and '2' to fight without it");
               if (_userInput.UserChoice() == "1")
                   hasShield = "1";
           }




           return [choice, hasShield];
       }
    
    
    */
}