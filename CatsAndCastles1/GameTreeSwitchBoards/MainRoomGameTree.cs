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

    public void MainRoomSwitchboard(Inventory inventory, Hero cat, InstancesMainRoom instanceMR)
    {
        Console.Clear();
        cat.Location = Hero.Place.MainRoom;
        cat.EndGame = false;
        UIInventory uiInventory = new UIInventory();
        
        WindowTree windowTree = new WindowTree();
        LockedDoorTree lockedDoorTree = new LockedDoorTree();

        do
        {
            int item = instanceMR.MainRoom.RoomMethod();
            Console.Clear();
            switch (item) //this is a call on the BaseLocation class
            {
                case 0: // this is the only exit!!!
                    
                    lockedDoorTree.DoorsSwitchboard(inventory, cat, instanceMR.MainDoor);
                    if (instanceMR.MainDoor.DoorIsOpen())
                        cat.Location = Hero.Place.ThirdFloor;
                    break;
                case 1: //closet
                    instanceMR.Closet.LocationMethod(inventory);
                    break;
                case 2: //window
                    windowTree.WindowSwitchboard(inventory, cat, instanceMR.Window);
                    break;
                case 3: //nightstand
                    instanceMR.Nightstand.LocationMethod(inventory);
                    break;
                case 4: //bookshelf
                    instanceMR.Bookshelf.LocationMethod(inventory);
                    break;
                case 5: //Hearth
                    instanceMR.Hearth.LocationMethod(inventory);
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