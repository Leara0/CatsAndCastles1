using CatsAndCastles1.Text;
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
        TextWorkInventory.PackOption,
        TextWorkInventory.DiscardRevisitOption
    ];

    public static readonly List<string> ThirdFloorChoices =
    [
        TextThirdFloor.ReturnToMainRoomOption,
        TextThirdFloor.ThirdFloorDoor2Option,
        TextThirdFloor.ThirdFloorDoor3Option,
        TextThirdFloor.ThirdFloorDoor4Option,
        TextWorkInventory.PackOption,
        TextThirdFloor.HeadDownStairsOption
    ];

    public static readonly List<string> SecondFloorChoices =
    [
        TextSecondFloor.SecondFloorDoor1Option,
        TextSecondFloor.SecondFloorDoor2Option,
        TextSecondFloor.SecondFloorDoor3Option,
        TextSecondFloor.SecondFloorDoor4Option,
        TextWorkInventory.PackOption,
        TextSecondFloor.HeadUpStairsOption,
        TextThirdFloor.HeadDownStairsOption,
    ];

}