using CatsAndCastles1.Lists;
using CatsAndCastles1.Lists.ItemsAtLocations;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.Text.Locations;

namespace CatsAndCastles1.ClassInstantiation;

public class InstancesThirdFloor
{
    public Location ThirdFloor { get; set; } = new Location
    (
        TextThirdFloor.ThirdFloorEntrance,
        TextThirdFloor.ThirdFloorTreeHeading,
        ListOptionsAtLocations.ThirdFloorChoices
    );
    public LocationsItems Guard1Body { get; }= new LocationsItems
    (
        TextGuard.DeadBodyIntro,
        ListItemGuard.Guard1Items,
        ListItemGuard.Guard1Description
    );
    public LocationsLocked StudyF3D2 { get; }= new LocationsLocked
    (
        TextDoorAndWindow.ApproachDoor,
        TextThirdFloor.ExploreStudyF3D2,
        ListLockPickingTools.UnHelpfulLockPick,
        ListItemThirdFloor.StudyF3D2Items,
        ListItemThirdFloor.StudyF3D2Description
    );
    public LocationsLocked BedroomF3D3 { get; }= new LocationsLocked
    (
        TextDoorAndWindow.ApproachDoor,
        TextThirdFloor.ExploreBedroomF3D3,
        ListLockPickingTools.UnHelpfulKeys,
        ListItemThirdFloor.BedroomF3D3Items,
        ListItemThirdFloor.BedroomF3D3Description
    );
    
    public LocationsLocked ClosetF3D4 { get; }= new LocationsLocked
    (
        TextDoorAndWindow.ApproachDoor,
        TextThirdFloor.ExploreClosetF3D4,
        ListLockPickingTools.UnHelpfulNothing,
        ListItemThirdFloor.ClosetF3D4Items,
        ListItemThirdFloor.ClosetF3D4Description
    );

    public InstancesThirdFloor()
    {
        BedroomF3D3.ChangeDoorLockStatus(true);
    }

}