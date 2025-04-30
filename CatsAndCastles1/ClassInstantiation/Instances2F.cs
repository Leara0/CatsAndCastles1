using CatsAndCastles1.Lists;
using CatsAndCastles1.Lists.ListItemsAtLocations;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.Text.Locations;

namespace CatsAndCastles1.ClassInstantiation;

public class Instances2F
{
    public Location SecondFloor { get; } = new 
    (
        Text2F.SecondFloorEntrance,
        Text2F.SecondFloorTreeHeading,
        ListOptionsAtLocations.SecondFloorChoices
    );

    public LocationsLocked MeetingRoomF2D1 { get; } = new 
    (
        TextDoorAndWindow.ApproachDoor, Text2F.ExploreMeetingRoomF2R1,
        ListLockPickingTools.UnHelpfulLockPick,
        ListItems2F.MeetingRoomF2R1Items,
        ListItems2F.MeetingRoomF2R1Description
    );

    public LocationsLocked GuardQuartersF2D2 { get; } = new 
    (
        TextDoorAndWindow.ApproachDoor,
        Text2F.ExploreGuardRoomF2R2,
        ListLockPickingTools.UnHelpfulNothing,
        ListItems2F.GuardRoomF2R2Items,
        ListItems2F.GuardRoomF2R2Description
    );

    public LocationsLocked ClosetF2R3 { get; } = new 
    (
        TextDoorAndWindow.ApproachDoor,
        Text2F.ExploreClosetF2R3,
        ListLockPickingTools.UnHelpfulNothing,
        ListItems2F.ClosetF2R3Items,
        ListItems2F.ClosetF2R3Description
    );

    public LocationsLocked LibraryF2R4 { get; } = new 
    (
        TextDoorAndWindow.ApproachDoor,
        Text2F.ExploreLibraryF2R4,
        ListLockPickingTools.UnHelpfulLockPick,
        ListItems2F.LibraryF2R4Items,
        ListItems2F.LibraryF2R4Description
    );
    public LocationsItems Guard2Corpse { get; } = new 
    (TextGuard.DeadBodyIntro,
        ListItemGuard.Guard2Items,
        ListItemGuard.Guard2Description
    );

    public Instances2F()
    {
        GuardQuartersF2D2.ChangeDoorLockStatus(true);
    }
}