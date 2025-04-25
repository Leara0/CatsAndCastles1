using CatsAndCastles1.Characters;
using CatsAndCastles1.ClassInstantiation;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;

public static class SwitchTreeMainRoomGame
{
    
    public static void MainRoomSwitchboard(Inventory inventory, Hero cat, InstancesMainRoom instanceMR)
    {
        Console.Clear();
        cat.Location = Hero.Place.MainRoom;
        cat.EndGame = false;
        UIInventory uiInventory = new UIInventory();
        
        SwitchTreeWindow switchTreeWindow = new SwitchTreeWindow();
        SwitchTreeLockedDoor switchTreeLockedDoor = new SwitchTreeLockedDoor();

        do
        {
            int item = instanceMR.MainRoom.RoomMethod();
            Console.Clear();
            switch (item) //this is a call on the BaseLocation class
            {
                case 0: // this is the only exit!!!
                    
                    switchTreeLockedDoor.DoorsSwitchboard(inventory, cat, instanceMR.MainDoor);
                    if (instanceMR.MainDoor.DoorIsOpen())
                        cat.Location = Hero.Place.ThirdFloor;
                    break;
                case 1: //closet
                    instanceMR.Closet.LocationMethod(inventory);
                    break;
                case 2: //window
                    switchTreeWindow.WindowSwitchboard(inventory, cat, instanceMR.LocationsWindow);
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