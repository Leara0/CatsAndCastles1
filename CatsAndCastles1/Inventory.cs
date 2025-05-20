namespace CatsAndCastles1;

public class Inventory //I got rid of the chance to use sheets to climb down. Now it's just the rope options
{
    private int _purse;
    #region Properties

    public List<string>? Pack { get; set; }
    public List<string>? DiscardedItems { get; set; }
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