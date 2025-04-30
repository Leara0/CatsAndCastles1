using CatsAndCastles1.Lists;
using CatsAndCastles1.Lists.ListItemsAtLocations;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.Text.Locations;

namespace CatsAndCastles1.ClassInstantiation;

public class InstancesMainR
{
    public Location MainRoom { get; } = new Location
    (
        TextMainRoom.StartInRoom,
        TextMainRoom.FirstRoomChoices,
        ListOptionsAtLocations.MainRoomChoices
    );
    public LocationsItems Closet { get; }= new LocationsItems
    (
        TextMainRoom.ExploreCloset,
        ListItemsMainR.ClosetItems,
        ListItemsMainR.ClosetDescription
    );

    public LocationsItems Nightstand { get; } = new LocationsItems
    (
        TextMainRoom.ExploreNightStand,
        ListItemsMainR.NightStandItems,
        ListItemsMainR.NightStandDescription
    );
    public LocationsItems Bookshelf { get; } = new LocationsItems
    (
        TextMainRoom.ExploreBookshelf,
        ListItemsMainR.BookshelfItems,
        ListItemsMainR.BookshelfDescription
    );
    public LocationsItems Hearth { get; } =new LocationsItems
    (
        TextMainRoom.ExploreHearth,
        ListItemsMainR.HearthItems,
        ListItemsMainR.HearthDescription
    );
    public LocationsLocked MainDoor { get; }=
        new LocationsLocked
        (
            TextDoorAndWindow.ApproachDoor,
            ListLockPickingTools.UnHelpfulKeys
        );
    public LocationsWindow LocationsWindow { get; } = new LocationsWindow
    (
        TextDoorAndWindow.ExploreWindow,
        ListLockPickingTools.AllPossibleOptions,
        ListLockPickingTools.WindowNeedsRope
    );
    
    }