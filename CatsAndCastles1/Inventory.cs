using System.Net.Mime;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1;

public class Inventory //I got rid of the chance to use sheets to climb down. Now its just the rope options
{
    private readonly UserInput _userInput = new UserInput();

    private int _purse = 0;

    #region Properties

    public List<string> Pack { get; set; }
    public List<string> DiscardedItems { get; set; }
    public List<string> ModifiedWeaponPack { get; set; }

    #endregion


    public int AddGoldToPurse(string item)
    {
        var amount = int.Parse(item.Substring(0, 2));
        _purse += amount;
        return _purse;
    }

    public int SpendGold(int amount)
    {
        if (_purse >= amount)
        {
            _purse -= amount;
            return _purse;
        }
        return -1;
    }

    public int  CheckPurseInventory()
    {
        return _purse;
    }
}