using System.Net.Mime;

namespace CatsAndCastles1;

public class BackpackMethods //I got rid of the chance to use sheets to climb down. Now its just the rope options
{
    private readonly UserInput _userInput = new UserInput();

    public string emptySpot = "a faint outline marking the spot where something once rested";
    private int _purse = 0;


    #region Properties

    public List<string> Pack { get; set; }
    public List<string> DiscardedItems { get; set; }

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
        else
            return -1;
    }
}