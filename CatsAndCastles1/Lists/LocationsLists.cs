namespace CatsAndCastles1.Lists;

public class LocationsLists
{
    public List<string> MainRoomChoices = new List<string>()
    {
        Text.ExitDoor,
        Text.ClosetDoor,
        Text.WindowOption,
        Text.NightStandOption,
        Text.BookshelfOption,
        Text.HearthOption,
        Text.DiscardRevisitOption
    };

    public List<string> ThirdFloorChoices = new List<string>()
    {
        Text.ReturnToMainRoomOption,
        Text.ThirdFloorDoor2Option,
        Text.ThirdFloorDoor3Option,
        Text.ThirdFloorDoor4Option,
        Text.HeadDownStairsOption
    };

    public List<string> ClosetDescription = new List<string>()
    {
        Text.TwoSheetsDesc,
        Text.BroomAndDustPanDesc,
        Text.ManaclesDesc,
        //footer/pick ItemDescriptionText same for all locations
    };

    public List<string> ClosetItems = new List<string>()
    {
        Text.TwoSheets,
        Text.BroomAndDustPan,
        Text.Manacles,
    };

    public List<string> NightStandDescription = new List<string>()
    {
        Text.TenCoinsDesc,
        Text.GlassesDesc,
        Text.BookOfPrayersDesc
    };

    public List<string> NightStandItems = new List<string>()
    {
        Text.TenCoins,
        Text.Glasses,
        Text.BookOfPrayers
    };

    public List<string> BookshelfDescription = new List<string>()
    {
        Text.DaggerDesc,
        Text.LockPickSetDesc,
        Text.CatFigurineDesc
    };

    public List<string> BookshelfItems = new List<string>()
    {
        Text.Dagger,
        Text.LockPickSet,
        Text.CatFigurine
    };

    public List<string> HearthDescription = new List<string>()
    {
        Text.FirePokerDesc,
        Text.LargeStoneDesc,
        Text.BatteredShieldDesc
    };

    public List<string> HearthItems = new List<string>()
    {
        Text.FirePoker,
        Text.LargeStone,
        Text.BatteredShield
    };

    public List<string> StudyF3D2Description = new List<string>()
    {
        Text.CatWantedPosterDesc,
        Text.ThirteenCoinsDesc,
        Text.GlassesDesc,
    };

    public List<string> StudyF3D2Items = new List<string>()
    {
        Text.CatWantedPoster ,
        Text.ThirteenCoins,
        Text.Glasses,
    };

    public List<string> BedroomF3D3Description = new List<string>()
    {
        Text.GlassVialDesc,
        Text.TwelveCoinsDesc,
        Text.CatCollarDesc
    };

    public List<string> BedroomF3D3Items = new List<string>()
    {
        Text.GlassVial,
        Text.TwelveCoins,
        Text.CatCollar
    };

    public List<string> ClosetF3D4Description = new List<string>()
    {
        Text.BroomAndDustPanDesc,
        Text.GlassesDesc,
        Text.RustedLanternDesc
    };

    public List<string> ClosetF3D4Items = new List<string>()
    {
        Text.BroomAndDustPan,
        Text.GlassVial,
        Text.RustedLantern
    };

    public List<string> MeetingRoomF2R1Description = new List<string>()
    {
        Text.DogStatueDesc,
        Text.GlassVialDesc,
        Text.DiceDesc
    };

    public List<string> MeetingRoomF2R1Items = new List<string>()
    {
        Text.DogStatue,
        Text.GlassVial,
        Text.Dice
    };

    public List<string> GuardRoomF2R2Description = new List<string>()
    {
        Text.ThirteenCoinsDesc,
        Text.ShieldDesc,
        Text.ShortSwordDesc
    };

    public List<string> GuardRoomF2R2Items = new List<string>()
    {
        Text.ThirteenCoins,
        Text.Shield,
        Text.ShortSword
    };

    public List<string> ClosetF2R3Description = new List<string>()
    {
        Text.RopeDesc,
        Text.TwoSheetsDesc,
    };

    public List<string> ClosetF2R3Items = new List<string>()
    {
        Text.Rope,
        Text.TwoSheets
    };

    public List<string> LibraryF2R4Description = new List<string>()
    {
        Text.GlassVialDesc,
        Text.DustyBookDesc,
        Text.CandleStubDesc
    };

    public List<string> LibraryF2R4Items = new List<string>()
    {
        Text.GlassVial,
        Text.DustyBook,
        Text.CandleStub
    };

    public List<string> Guard1Description = new List<string>()
    {
        Text.RingOfKeysDesc,
        Text.DogWhistleDesc,
        Text.CrudeShieldDesc,
        Text.TwoSheetsDesc,
    };

    public List<string> Guard1Items = new List<string>()
    {
        Text.RingOfKeys,
        Text.DogWhistle,
        Text.CrudeShield,
        Text.TwoSheets,
    };

    public List<string> Guard2Description = new List<string>()
    {
        Text.TenCoinsDesc,
        Text.WorryBeadsDesc,
        Text.BatteredShieldDesc,
        Text.DogWhistleDesc
    };

    public List<string> Guard2Items = new List<string>()
    {
        Text.TenCoins,
        Text.WorryBeads,
        Text.BatteredShield,
        Text.DogWhistle,
    };

    public List<string> WardenDescription = new List<string>()
    {
        Text.TwentyCoinsDesc,
        Text.LoafOfBreadDesc,
        Text.GlassVialDesc
    };

    public List<string> WardenItems = new List<string>()
    {
        Text.TwentyCoins,
        Text.LoafOfBread,
        Text.GlassVial
    };
}