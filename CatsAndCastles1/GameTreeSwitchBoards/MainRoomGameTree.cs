using CatsAndCastles1.Characters;
using CatsAndCastles1.ClassInstantiation;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;

public class MainRoomGameTree()
{
    //private readonly InstancesMainRoom _location;
    
    //how to weave in fluff intro scenes about the earlier cut scenes?
    private readonly UserInput _userInput = new UserInput();

    public void MainRoomSwitchboard(Inventory inventory, Hero cat, Location mainRoom,
        ItemsLocation closet,
        ItemsLocation nightstand, ItemsLocation bookshelf, ItemsLocation hearth,
        LockedLocations mainDoor, WindowLocation window)
    {
        Console.Clear();
        cat.Location = Hero.Place.MainRoom;
        cat.EndGame = false;
        UIInventory uiInventory = new UIInventory();
        
        WindowTree windowTree = new WindowTree();
        LockedDoorTree lockedDoorTree = new LockedDoorTree();

        do
        {
            int item = mainRoom.RoomMethod();
            Console.Clear();
            switch (item) //this is a call on the BaseLocation class
            {
                case 0: // this is the only exit!!!
                    mainDoor.ChangeDoorLockStatus(true); //@TODO remove this when doing game for real
                    lockedDoorTree.DoorsSwitchboard(inventory, cat, mainDoor);
                    if (mainDoor.DoorIsOpen())
                        cat.Location = Hero.Place.ThirdFloor;
                    break;
                case 1: //closet
                    closet.LocationMethod(inventory);
                    break;
                case 2: //window
                    windowTree.WindowSwitchboard(inventory, cat, window);
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
                case 6: //check discard
                    uiInventory.AddItemToInventoryFromDiscard(inventory);
                    break;
                case 7: //inventory
                    uiInventory.RemoveItemFromInventory(cat, inventory);
                    break;
            }
        } while (cat.Location == Hero.Place.MainRoom);
    }

    

    
}