using CatsAndCastles1.Text.Inventory;
using CatsAndCastles1.Text.Locations;

namespace CatsAndCastles1.Lists;

public static class ListOptionsAtLocations
{
    public static readonly List<string> MainRoomChoices =
    [
        TextMainRoom.ExitDoor,
        TextMainRoom.ClosetDoor,
        TextMainRoom.WindowOption,
        TextMainRoom.NightStandOption,
        TextMainRoom.BookshelfOption,
        TextMainRoom.HearthOption,
        TextWorkInventory.DiscardRevisitOption
    ];

    public static readonly List<string> ThirdFloorChoices =
    [
        Text3F.ReturnToMainRoomOption,
        Text3F.StudyF3D2Option,
        Text3F.BedroomF3D3Option,
        Text3F.ClosetF3D4Option,
       Text3F.HeadDownStairsOption
    ];

    public static readonly List<string> SecondFloorChoices =
    [
        Text2F.MeetingRoomF2D1Option,
        Text2F.GuardQuartersF2D2Option,
        Text2F.ClosetF2R3Option,
        Text2F.LibraryF2R4Option,
        Text2F.HeadUpStairsOption,
        Text3F.HeadDownStairsOption,
    ];

    public static readonly List<string> FirstFloorChoices =
    [
        Text1F.HeadTowardsOutsideDoorOption,
        Text1F.ExploreTheRoomOption,
        Text2F.HeadUpStairsOption,
    ];
}