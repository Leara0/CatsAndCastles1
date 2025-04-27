using CatsAndCastles1.Lists.ItemsAtLocations;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.Text.GuardEncounter;

namespace CatsAndCastles1.ClassInstantiation;

public class Instances1F
{
    public LocationsItems wardenCorpse { get; }= new LocationsItems//not sure I need this??
    (
        TextGuard.DeadBodyIntro,//@TODO change for warden?
        ListItemGuard.WardenItems,
        ListItemGuard.WardenDescription
    );
}