using CatsAndCastles1.Lists;
using CatsAndCastles1.Lists.ItemsAtLocations;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.Text.Locations;

namespace CatsAndCastles1.ClassInstantiation;

public class InstancesSecondFloor
{
    public Location SecondFloor { get; } = new Location
    (
        TextSecondFloor.SecondFloorEntrance,
        TextSecondFloor.SecondFloorTreeHeading,
        ListOptionsAtLocations.SecondFloorChoices
    );

    public LocationsItems Guard2Body { get; }  = new LocationsItems
    (
        TextGuard.DeadBodyIntro,
        ListItemGuard.Guard2Items,
        ListItemGuard.Guard2Description
    );

    public LocationsLocked MeetingRoomF2D1 { get; } = new LocationsLocked
    (
        TextDoorAndWindow.ApproachDoor, TextSecondFloor.ExploreMeetingRoomF2R1,
        ListLockPickingTools.UnHelpfulLockPick,
        ListItemsSecondFloor.MeetingRoomF2R1Items,
        ListItemsSecondFloor.MeetingRoomF2R1Description
    );

    public LocationsLocked GuardQuartersF2D2 { get; } = new LocationsLocked
    (
        TextDoorAndWindow.ApproachDoor,
        TextSecondFloor.ExploreGuardRoomF2R2,
        ListLockPickingTools.UnHelpfulNothing,
        ListItemsSecondFloor.GuardRoomF2R2Items,
        ListItemsSecondFloor.GuardRoomF2R2Description
    );

    public LocationsLocked ClosetF2R3 { get; } = new LocationsLocked
    (
        TextDoorAndWindow.ApproachDoor,
        TextSecondFloor.ExploreClosetF2R3,
        ListLockPickingTools.UnHelpfulNothing,
        ListItemsSecondFloor.ClosetF2R3Items,
        ListItemsSecondFloor.ClosetF2R3Description
    );

    public LocationsLocked LibraryF2R4 { get; } = new LocationsLocked
    (
        TextDoorAndWindow.ApproachDoor,
        TextSecondFloor.ExploreLibraryF2R4,
        ListLockPickingTools.UnHelpfulLockPick,
        ListItemsSecondFloor.LibraryF2R4Items,
        ListItemsSecondFloor.LibraryF2R4Description
    );

    public InstancesSecondFloor()
    {
        GuardQuartersF2D2.ChangeDoorLockStatus(true);
    }
}