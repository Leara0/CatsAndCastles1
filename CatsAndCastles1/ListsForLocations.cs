namespace CatsAndCastles1;

public class ListsForLocations
{
    public List<string> MainRoomChoices = new List<string>()
    {
        TextLocation.ExitDoor,
        TextLocation.ClosetDoor,
        TextLocation.WindowOption,
        TextLocation.NightStandOption,
        TextLocation.BookshelfOption,
        TextLocation.HearthOption,
        TextLocation.PackOption, 
        };

    public List<string> ClosetDescription = new List<string>()
    {
        TextItemDescription.TwoSheetsDesc,
        TextItemDescription.BroomAndDustPanDesc,
        TextItemDescription.ManaclesDesc,
        //footer/pick ItemDescriptionText same for all locations
    };

    public List<string> ClosetItems = new List<string>()
    {
        TextItemDescription.TwoSheets,
        TextItemDescription.BroomAndDustPan,
        TextItemDescription.Manacles,
    };

    public List<string> NightStandDescription = new List<string>()
    {
        TextItemDescription.TenCoinsDesc,
        TextItemDescription.GlassesDesc,
        TextItemDescription.BookOfPrayersDesc
    };

    public List<string> NightStandItems = new List<string>()
    {
        TextItemDescription.TenCoins,
        TextItemDescription.Glasses,
        TextItemDescription.BookOfPrayers
    };

    public List<string> BookshelfDescription = new List<string>()
    {
        TextItemDescription.DaggerDesc,
        TextItemDescription.LockPickSetDesc,
        TextItemDescription.CatFigurineDesc
    };

    public List<string> BookshelfItems = new List<string>()
    {
        TextItemDescription.Dagger,
        TextItemDescription.LockPickSet,
        TextItemDescription.CatFigurine
    };

    public List<string> HearthDescription = new List<string>()
    {
        TextItemDescription.FirePokerDesc,
        TextItemDescription.LargeStoneDesc,
        TextItemDescription.BatteredShieldDesc
    };

    public List<string> HearthItems = new List<string>()
    {
        TextItemDescription.FirePoker,
        TextItemDescription.LargeStone,
        TextItemDescription.BatteredShield
    };

    public List<string> F3Room2Description = new List<string>()
    {
        TextItemDescription.LongDaggerDesc,
        TextItemDescription.ThirteenCoinsDesc,
    };

    public List<string> F3Room2Items = new List<string>()
    {
        TextItemDescription.LongDagger,
        TextItemDescription.ThirteenCoins,
    };

    public List<string> F3Room3Description = new List<string>()
    {
        TextItemDescription.GlassVialDesc,
        TextItemDescription.TwelveCoinsDesc,
        TextItemDescription.CatCollarDesc
    };

    public List<string> F3Room3Items = new List<string>()
    {
        TextItemDescription.GlassVial,
        TextItemDescription.TwelveCoins,
        TextItemDescription.CatCollar
    };

    public List<string> F3Room4Description = new List<string>()
    {
        TextItemDescription.TenCoinsDesc,
        TextItemDescription.DaggerDesc,
        TextItemDescription.CrudeShieldDesc
    };

    public List<string> F3Room4Items = new List<string>()
    {
        TextItemDescription.TenCoins,
        TextItemDescription.Dagger,
        TextItemDescription.CrudeShield
    };

    public List<string> F2Room1Description = new List<string>()
    {
        TextItemDescription.DogStatueDesc,
        TextItemDescription.GlassVialDesc,
        TextItemDescription.CrudeShieldDesc
    };

    public List<string> F2Room1Items = new List<string>()
    {
        TextItemDescription.DogStatue,
        TextItemDescription.GlassVial,
        TextItemDescription.CrudeShield
    };

    public List<string> F2Room2Description = new List<string>()
    {
        TextItemDescription.ThirteenCoinsDesc,
        TextItemDescription.GlassesDesc
    };

    public List<string> F2Room2Items = new List<string>()
    {
        TextItemDescription.ThirteenCoins,
        TextItemDescription.Glasses,
    };

    public List<string> F2Room3Description = new List<string>()
    {
        TextItemDescription.RopeDesc,
        TextItemDescription.GlassesDesc,
        TextItemDescription.ShortSwordDesc
    };

    public List<string> F2Room3Items = new List<string>()
    {
        TextItemDescription.Rope,
        TextItemDescription.Glasses,
        TextItemDescription.ShortSword
    };

    public List<string> F2Room4Description = new List<string>()
    {
        TextItemDescription.TwoSheetsDesc,
        TextItemDescription.GlassVialDesc,
        TextItemDescription.CrudeShieldDesc
    };

    public List<string> F2Room4Items = new List<string>()
    {
        TextItemDescription.TwoSheets,
        TextItemDescription.GlassVial,
        TextItemDescription.CrudeShield,
    };

    public List<string> Guard1Description = new List<string>()
    {
        TextItemDescription.RingOfKeysDesc,
        TextItemDescription.DogWhistleDesc,
        TextItemDescription.CrudeShieldDesc,
        TextItemDescription.TwoSheetsDesc,
    };

    public List<string> Guard1Items = new List<string>()
    {
        TextItemDescription.RingOfKeys,
        TextItemDescription.DogWhistle,
        TextItemDescription.CrudeShield,
        TextItemDescription.TwoSheets,
    };

    public List<string> Guard2Description = new List<string>()
    {
        TextItemDescription.TenCoinsDesc,
        TextItemDescription.WorryBeadsDesc,
        TextItemDescription.BatteredShieldDesc,
        TextItemDescription.DogWhistleDesc
    };

    public List<string> Guard2Items = new List<string>()
    {
        TextItemDescription.TenCoins,
        TextItemDescription.WorryBeads,
        TextItemDescription.BatteredShield,
        TextItemDescription.DogWhistle,
    };

    public List<string> WardenDescription = new List<string>()
    {
        TextItemDescription.TwentyCoinsDesc,
        TextItemDescription.LoafOfBreadDesc,
        TextItemDescription.GlassVialDesc
    };

    public List<string> WardenItems = new List<string>()
    {
        TextItemDescription.TwentyCoins,
        TextItemDescription.LoafOfBread,
        TextItemDescription.GlassVial
    };
}