namespace CatsAndCastles1;

public class GameTree()
{
    public void MainRoomSwitchboard(Inventory inventory, Characters cat)
    {
        ListsForLocations lists = new ListsForLocations();
        UserInteractionsBackpack userInteractionsBackpack = new UserInteractionsBackpack();

        //how to weave in fluff intro scenes about the earlier cut scenes?
        
        //Setup the locations @TODO add the rest
        BaseLocation mainRoom = new BaseLocation(LocationText.FirstRoomChoices, lists.MainRoomChoices);
        DerivedItemsLocation closet = new DerivedItemsLocation
            (LocationText.ExploreCloset, lists.ClosetItems, lists.ClosetDescription);
        DerivedItemsLocation nightStand = new DerivedItemsLocation
            (LocationText.ExploreNightStand, lists.NightStandItems, lists.NightStandDescription);
        DerivedItemsLocation bookshelf = new DerivedItemsLocation
            (LocationText.ExploreBookshelf, lists.BookshelfItems, lists.BookshelfDescription);
        DerivedItemsLocation hearth = new DerivedItemsLocation
            (LocationText.ExploreHearth, lists.HearthItems, lists.HearthDescription);

        do
        {
            switch (mainRoom.RoomMethod())
            {
                case 0: // this is the only exit!!!
                    //exit.LocationMethod(backpackMethods
                    break;
                case 1: //closet
                    closet.LocationMethod(inventory);
                    break;
                case 2: //window
                    break;
                case 3: //nightstand
                    nightStand.LocationMethod(inventory);
                    break;
                case 4: //bookshelf
                    bookshelf.LocationMethod(inventory);
                    break;
                case 5: //Hearth
                    hearth.LocationMethod(inventory);
                    break;
                case 6: //inventory
                    userInteractionsBackpack.RemoveItemFromInventory(inventory);
                    break;
                case 7: //check discard
                    userInteractionsBackpack.AddItemToInventoryFromDiscard(inventory);
                    break;
            }
        } while (cat.Location == Characters.Place.MainRoom);



    }
}