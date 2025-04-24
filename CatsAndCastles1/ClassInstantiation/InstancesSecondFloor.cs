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
        OptionsAtLocationsList.SecondFloorChoices
    );

    public ItemsLocation Guard2Body { get; }  = new ItemsLocation
    (
        TextGuard.DeadBodyIntro,
        ListItemGuard.Guard2Items,
        ListItemGuard.Guard2Description
    );

    public LockedLocations MeetingRoomF2D1 { get; } = new LockedLocations
    (
        TextDoorAndWindow.ApproachDoor, TextSecondFloor.ExploreMeetingRoomF2R1,
        LockPickingToolsList.UnHelpfulLockPick,
        ListItemsSecondFloor.MeetingRoomF2R1Items,
        ListItemsSecondFloor.MeetingRoomF2R1Description
    );

    public LockedLocations GuardQuartersF2D2 { get; } = new LockedLocations
    (
        TextDoorAndWindow.ApproachDoor,
        TextSecondFloor.ExploreGuardRoomF2R2,
        LockPickingToolsList.UnHelpfulNothing,
        ListItemsSecondFloor.GuardRoomF2R2Items,
        ListItemsSecondFloor.GuardRoomF2R2Description
    );

    public LockedLocations ClosetF2R3 { get; } = new LockedLocations
    (
        TextDoorAndWindow.ApproachDoor,
        TextSecondFloor.ExploreClosetF2R3,
        LockPickingToolsList.UnHelpfulNothing,
        ListItemsSecondFloor.ClosetF2R3Items,
        ListItemsSecondFloor.ClosetF2R3Description
    );

    public LockedLocations LibraryF2R4 { get; } = new LockedLocations
    (
        TextDoorAndWindow.ApproachDoor,
        TextSecondFloor.ExploreLibraryF2R4,
        LockPickingToolsList.UnHelpfulLockPick,
        ListItemsSecondFloor.LibraryF2R4Items,
        ListItemsSecondFloor.LibraryF2R4Description
    );

    public InstancesSecondFloor()
    {
        GuardQuartersF2D2.ChangeDoorLockStatus(true);
    }
}