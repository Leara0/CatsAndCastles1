using CatsAndCastles1.Lists;
using CatsAndCastles1.Lists.ItemsAtLocations;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.Text.Locations;

namespace CatsAndCastles1.ClassInstantiation;

public class InstancesMainRoom
{
    public Location MainRoom { get; } = new Location
    (
        TextMainRoom.StartInRoom,
        TextMainRoom.FirstRoomChoices,
        OptionsAtLocationsList.MainRoomChoices
    );
    public ItemsLocation Closet { get; }= new ItemsLocation
    (
        TextMainRoom.ExploreCloset,
        ListItemsMainRoom.ClosetItems,
        ListItemsMainRoom.ClosetDescription
    );

    public ItemsLocation Nightstand { get; } = new ItemsLocation
    (
        TextMainRoom.ExploreNightStand,
        ListItemsMainRoom.NightStandItems,
        ListItemsMainRoom.NightStandDescription
    );
    public ItemsLocation Bookshelf { get; } = new ItemsLocation
    (
        TextMainRoom.ExploreBookshelf,
        ListItemsMainRoom.BookshelfItems,
        ListItemsMainRoom.BookshelfDescription
    );
    public ItemsLocation Hearth { get; } =new ItemsLocation
    (
        TextMainRoom.ExploreHearth,
        ListItemsMainRoom.HearthItems,
        ListItemsMainRoom.HearthDescription
    );
    public LockedLocations MainDoor { get; }=
        new LockedLocations
        (
            TextDoorAndWindow.ApproachDoor,
            LockPickingToolsList.UnHelpfulKeys
        );
    public WindowLocation Window { get; } = new WindowLocation
    (
        TextDoorAndWindow.ExploreWindow,
        LockPickingToolsList.AllPossibleOptions,
        LockPickingToolsList.WindowNeedsRope
    );
    
    }