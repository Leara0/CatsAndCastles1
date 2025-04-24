using CatsAndCastles1.Lists;
using CatsAndCastles1.Lists.ItemsAtLocations;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.Text.Locations;

namespace CatsAndCastles1.ClassInstantiation;

public class InstancesMainRoom
{
    public Location MainRoom { get; }
    public ItemsLocation Closet { get; }
    public ItemsLocation Nightstand { get; }
    public ItemsLocation Bookshelf { get; }
    public ItemsLocation Hearth { get; }
    public LockedLocations MainDoor { get; }
    public WindowLocation Window { get; }
    
    
    Location mainRoom = new Location
    (
        TextMainRoom.StartInRoom,
        TextMainRoom.FirstRoomChoices,
        OptionsAtLocationsList.MainRoomChoices
    );

    ItemsLocation closet = new ItemsLocation
    (
        TextMainRoom.ExploreCloset,
        ListItemsMainRoom.ClosetItems,
        ListItemsMainRoom.ClosetDescription
    );

    ItemsLocation nightstand = new ItemsLocation
    (
        TextMainRoom.ExploreNightStand,
        ListItemsMainRoom.NightStandItems,
        ListItemsMainRoom.NightStandDescription
    );

    ItemsLocation bookshelf = new ItemsLocation
    (
        TextMainRoom.ExploreBookshelf,
        ListItemsMainRoom.BookshelfItems,
        ListItemsMainRoom.BookshelfDescription
    );

    ItemsLocation hearth = new ItemsLocation
    (
        TextMainRoom.ExploreHearth,
        ListItemsMainRoom.HearthItems,
        ListItemsMainRoom.HearthDescription
    );

    LockedLocations mainDoor =
        new LockedLocations
        (
            TextDoorAndWindow.ApproachDoor,
            LockPickingToolsList.UnHelpfulKeys
        );

    WindowLocation window = new WindowLocation
    (
        TextDoorAndWindow.ExploreWindow,
        LockPickingToolsList.AllPossibleOptions,
        LockPickingToolsList.WindowNeedsRope
    );
}