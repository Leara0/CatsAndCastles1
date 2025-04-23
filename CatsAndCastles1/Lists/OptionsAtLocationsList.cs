namespace CatsAndCastles1.Lists;

public static class OptionsAtLocationsList
{
    public static readonly List<string> MainRoomChoices =
    [
        Text.ExitDoor,
        Text.ClosetDoor,
        Text.WindowOption,
        Text.NightStandOption,
        Text.BookshelfOption,
        Text.HearthOption,
        Text.DiscardRevisitOption
    ];

    public static readonly List<string> ThirdFloorChoices =
    [
        Text.ReturnToMainRoomOption,
        Text.ThirdFloorDoor2Option,
        Text.ThirdFloorDoor3Option,
        Text.ThirdFloorDoor4Option,
        Text.HeadDownStairsOption
    ];

    public static readonly List<string> SecondFloorChoices =
    [
        Text.SecondFloorDoor1Option,
        Text.SecondFloorDoor2Option,
        Text.SecondFloorDoor3Option,
        Text.SecondFloorDoor4Option,
        Text.HeadUpStairsOption,
        Text.HeadDownStairsOption,
    ];
}