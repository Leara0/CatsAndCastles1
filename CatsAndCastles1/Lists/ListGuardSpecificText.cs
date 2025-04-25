using CatsAndCastles1.Text;
using CatsAndCastles1.Text.GuardEncounter;

namespace CatsAndCastles1.Lists;

public static class ListGuardSpecificText
{
    public static readonly List<string> Guard1Wording =
    [
        TextGuard.NoticeGuard1,
        TextGuard.SetUpOptionsGuards,
        TextGuard.BeginRunAwayGuard1AndWarden,
        TextGuard.RunAwayGuard1
    ];

    public static readonly List<string> Guard2Wording =
    [
        TextGuard.NoticeGuard2,
        TextGuard.SetUpOptionsGuards,
        TextGuard.BeginRunAwayGuard2,
        TextGuard.RunAwayGuard2
    ];

    public static readonly List<string> WardenWording =
    [
        TextGuard.NoticeWarden,
        TextGuard.SetUpOptionsWarden,
        TextGuard.BeginRunAwayGuard1AndWarden,
        TextGuard.RunAwayWarden
    ];

    public static List<string> CreateBribeOptionsList(Inventory inventory)
    {
        var bribeOptions = new List<string>();
        bribeOptions.Add(TextGuard.CombatOption);
        
        string bribeOption = TextGuard.BribeOption + inventory.CheckPurseInventory() + TextGuard.GoldCoins;
        bribeOptions.Add(bribeOption);
        bribeOptions.Add(TextGuard.RunawayOption);
        
        return bribeOptions;
    }
}