namespace CatsAndCastles1;

public class GameTree()
{
    //how to weave in fluff intro scenes about the earlier cut scenes?
    private readonly UserInput _userInput = new UserInput();

    public void MainRoomSwitchboard(Inventory inventory, Characters cat, BaseLocation mainRoom,
        DerivedItemsLocation closet,
        DerivedItemsLocation nightstand, DerivedItemsLocation bookshelf, DerivedItemsLocation hearth,
        DerivedLockedLocations mainDoor, DerivedWindowLocation window)
    {
        Console.Clear();
        cat.Location = Characters.Place.MainRoom;
        cat.EndGame = false;
        UserInteractionsBackpack userInteractionsBackpack = new UserInteractionsBackpack();
        mainRoom.PrintIntro();

        do
        {
            int item = mainRoom.RoomMethod();
            Console.Clear();
            switch (item) //this is a call on the BaseLocation class
            {
                case 0: // this is the only exit!!!
                    DoorsSwitchboard(inventory, cat, mainDoor);
                    if (mainDoor.DoorIsOpen())
                        cat.Location = Characters.Place.ThirdFloor;
                    break;
                case 1: //closet
                    closet.LocationMethod(inventory);
                    break;
                case 2: //window
                    WindowSwitchboard(inventory, cat, window);
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
        if (!place.DoorIsOpen())
        {
            place.ApproachLockedDoor();
            bool catEscaped = false;
            do
            {
                string item = place.InteractWithLockedDoor(inventory);

                Console.Clear();
                if (item == "leave")
                    return;
                switch (item)
                {
                    case "": //this case is if you pick a tool that doesn't work in this location
                        break;
                    case Text.LockPickSet:
                        Console.WriteLine(Text.UsePickOnDoor);
                        catEscaped = true;
                        break;
                    case Text.RingOfKeys:
                        Console.WriteLine(Text.UseKeysOnDoor);
                        catEscaped = true;
                        break;
                    case Text.LargeStone:
                        if (place.AttemptStoneOnDoor(cat))
                            catEscaped = true;
                        break;
                    case Text.BatteredShield:
                    case Text.Shield:
                    case Text.CrudeShield:
                        if (place.AttemptShieldOnDoor(cat, item, inventory))
                            catEscaped = true;
                        break;
                }

                _userInput.DramaticPauseClrScreen();
            } while (!catEscaped);

            place.ChangeDoorLockStatus(true);
        }
        else
        {
            place.ApproachOpenDoor();
        }
    }

    public void WindowSwitchboard(Inventory inventory, Characters cat, DerivedWindowLocation place)
    {
        place.ApproachLockedDoor();
        string item = place.InteractWithlockedWindow(inventory);

        Console.Clear();
        if (item == "leave")
            return;
        switch (item)
        {
            case Text.Rope:
                place.ClimbDownWithRope();
                cat.Location = Characters.Place.OutsideCastle;
                break;
            case "jump down":
                place.JumpDown();
                cat.Location = Characters.Place.Dead;
                break;
        }

        _userInput.DramaticPauseClrScreen();
    }
}