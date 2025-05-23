using CatsAndCastles1.Lists;
using CatsAndCastles1.Lists.ListItemsAtLocations;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.Text.Locations;

namespace CatsAndCastles1.ClassInstantiation;

public class Instances3F
{
    public Location ThirdFloor { get; set; } = new Location
    (
        Text3F.ThirdFloorEntrance,
        Text3F.ThirdFloorTreeHeading,
        ListOptionsAtLocations.ThirdFloorChoices
    );
    public LocationsLocked StudyF3D2 { get; }= new LocationsLocked
    (
        TextDoorAndWindow.ApproachDoor,
        Text3F.ExploreStudyF3D2,
        ListLockPickingTools.UnHelpfulLockPick,
        ListItem3F.StudyF3D2Items,
        ListItem3F.StudyF3D2Description
    );
    public LocationsLocked BedroomF3D3 { get; }= new LocationsLocked
    (
        TextDoorAndWindow.ApproachDoor,
        Text3F.ExploreBedroomF3D3,
        ListLockPickingTools.UnHelpfulKeys,
        ListItem3F.BedroomF3D3Items,
        ListItem3F.BedroomF3D3Description
    );
    
    public LocationsLocked ClosetF3D4 { get; }= new LocationsLocked
    (
        TextDoorAndWindow.ApproachDoor,
        Text3F.ExploreClosetF3D4,
        ListLockPickingTools.UnHelpfulNothing,
        ListItem3F.ClosetF3D4Items,
        ListItem3F.ClosetF3D4Description
    );

    public LocationsItems Guard1Corpse { get; } = new LocationsItems
    (TextGuard.DeadBodyIntro,
        ListItemGuard.Guard1Items,
        ListItemGuard.Guard1Description
    );

    public Instances3F()
    {
        BedroomF3D3.ChangeDoorLockStatus(true);
    }

}