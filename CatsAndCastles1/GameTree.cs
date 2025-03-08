namespace CatsAndCastles1;

public class GameTree()
{
    public void MainRoomSwitchboard(Inventory inventory, Characters cat, DerivedItemsLocation closet, 
        DerivedItemsLocation nightstand, DerivedItemsLocation bookshelf, DerivedItemsLocation hearth)
    {
        cat.Location = Characters.Place.MainRoom;
        cat.EndGame = false;
        ListsForLocations lists = new ListsForLocations();
        UserInteractionsBackpack userInteractionsBackpack = new UserInteractionsBackpack();

        //how to weave in fluff intro scenes about the earlier cut scenes?
        BaseLocation mainRoom = new BaseLocation(LocationText.FirstRoomChoices, lists.MainRoomChoices);
        
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
                    nightstand.LocationMethod(inventory);
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