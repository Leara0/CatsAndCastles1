using CatsAndCastles1.Lists;
using CatsAndCastles1.Lists.ListItemsAtLocations;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.Text.GuardEncounter;
using CatsAndCastles1.Text.Locations;

namespace CatsAndCastles1.ClassInstantiation;

public class Instances1F
{
    public Location FirstFloor { get; } = new 
    (
        Text1F.LookAround1F,
        Text1F.ChooseNextAction,
        ListOptionsAtLocations.FirstFloorChoices
    );
    public LocationsItems WardenCorpse { get; }= new 
    (
        TextGuard.DeadWardenBodyIntro,
        ListItemGuard.WardenItems,
        ListItemGuard.WardenDescription
    );

    public LocationsItems Room1F { get; } = new 
    (
        Text1F.ExploreRoom,
        ListItems1F.Room1FItems,
        ListItems1F.Room1FDescription
        
    );
}