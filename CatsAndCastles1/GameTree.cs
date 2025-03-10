namespace CatsAndCastles1;

public class GameTree()
{
    //how to weave in fluff intro scenes about the earlier cut scenes?
    public void MainRoomSwitchboard(Inventory inventory, Characters cat, BaseLocation mainRoom,
        DerivedItemsLocation closet,
        DerivedItemsLocation nightstand, DerivedItemsLocation bookshelf, DerivedItemsLocation hearth, DerivedLockedLocations mainDoor)
    {
        Console.Clear();
        cat.Location = Characters.Place.MainRoom;
        cat.EndGame = false;
        UserInteractionsBackpack userInteractionsBackpack = new UserInteractionsBackpack();

        do
        {
            switch (mainRoom.RoomMethod()) //this is a call on the BaseLocation class
            {
                case 0: // this is the only exit!!!
                    DoorsSwitchboard(inventory, cat, mainDoor);
                    //exit.LocationMethod(backpackMethods
                    //if mainDoor.DoorIsOpen
                    //cat.Location == Characters.Place.ThirdFloor
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

    public void DoorsSwitchboard(Inventory inventory, Characters cat, DerivedLockedLocations place)
    {
        if (!place.DoorisOpen())
        {
            place.ApproachLockedDoor();
            bool catEscaped = false;
            do
            { 
                string item = place.InteractWithLockedDoor(inventory);

                if (item == "leave")
                    return;
                switch (item)
                {
                    case ""://this case is if you pick a tool that doesn't work in this location
                        break;
                    case TextItemDescription.LockPickSet:
                        Console.WriteLine(TextLocation.UsePickOnDoor);
                        catEscaped = true;
                        break;
                    case TextItemDescription.RingOfKeys:
                        Console.WriteLine(TextLocation.UseKeysOnDoor);
                        catEscaped = true;
                        break;
                    case TextItemDescription.LargeStone:
                        if(place.AttemptStoneOnDoor(cat))
                           catEscaped = true;
                        break;
                    case TextItemDescription.BatteredShield:
                    case TextItemDescription.Shield:
                    case TextItemDescription.CrudeShield:
                        if(place.AttemptShieldOnDoor(item, inventory))
                            catEscaped = true;
                        break;
                }
            } while (!catEscaped);
            place.ChangeDoorLockStatus(true); 
            cat.Location = Characters.Place.MainRoom;
        }
        else
        {
            place.ApproachOpenDoor();
        }
        /* intro about these are the items you find in your pack that might be helpful
         * string item = (place.GetObjectChoice(inventory))
         * if (place.ItemsThatWontHelp.Contains(item)
         * give a message about that this item won't work on this door but will likely work on other doors
         * switch(item)
         * case "" - they chose to leave this location so return?? - check if this is right
         * case ringOfKeys - words abou door opens
         * case lockpick - words about door opens
         * case stone - do stone method
         * case shield - do shield method
         * do until location changes to floor 3 (if they choose to stop
         * do a call on the door that should play the intro then do the interactivemenu and return the item choice
         */
    }
}