using CatsAndCastles1.Lists;
using CatsAndCastles1.Lists.ItemsAtLocations;
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
        ListItemsMainRoom.ClosetItems,
        ListItemsMainRoom.ClosetDescription
    );

    public LocationsItems Nightstand { get; } = new LocationsItems
    (
        TextMainRoom.ExploreNightStand,
        ListItemsMainRoom.NightStandItems,
        ListItemsMainRoom.NightStandDescription
    );
    public LocationsItems Bookshelf { get; } = new LocationsItems
    (
        TextMainRoom.ExploreBookshelf,
        ListItemsMainRoom.BookshelfItems,
        ListItemsMainRoom.BookshelfDescription
    );
    public LocationsItems Hearth { get; } =new LocationsItems
    (
        TextMainRoom.ExploreHearth,
        ListItemsMainRoom.HearthItems,
        ListItemsMainRoom.HearthDescription
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