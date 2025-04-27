using CatsAndCastles1.Characters;
using CatsAndCastles1.ClassInstantiation;
using CatsAndCastles1.Lists;
using CatsAndCastles1.Text.Inventory;
using CatsAndCastles1.Text.Locations;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;

public static class SwitchTreeMainR
{
    
    public static void MainRoomSwitchboard(Inventory inventory, Hero cat, InstancesMainR instanceMR)
    {
        Console.Clear();
        cat.Location = Hero.Place.MainRoom;
        cat.EndGame = false;
        UIInventory uiInventory = new UIInventory();
      
        do
        {
            int number = instanceMR.MainRoom.RoomMethod();
            var whereToExplore = ListOptionsAtLocations.MainRoomChoices[number];
            Console.Clear();
            switch (whereToExplore) //this is a call on the BaseLocation class
            {
                case TextMainRoom.ExitDoor: // this is the only exit!!!
                    
                    SwitchTreeLockedDoor.DoorsSwitchboard(inventory, cat, instanceMR.MainDoor);
                    if (instanceMR.MainDoor.DoorIsOpen())
                        cat.Location = Hero.Place.ThirdFloor;
                    break;
                case TextMainRoom.ClosetDoor: 
                    instanceMR.Closet.LocationMethod(inventory);
                    break;
                case TextMainRoom.WindowOption: 
                    SwitchTreeWindow.WindowSwitchboard(inventory, cat, instanceMR.LocationsWindow);
                    break;
                case TextMainRoom.NightStandOption: 
                    instanceMR.Nightstand.LocationMethod(inventory);
                    break;
                case TextMainRoom.BookshelfOption: 
                    instanceMR.Bookshelf.LocationMethod(inventory);
                    break;
                case TextMainRoom.HearthOption: 
                    instanceMR.Hearth.LocationMethod(inventory);
                    break;
                case TextWorkInventory.DiscardRevisitOption: 
                    uiInventory.AddItemToInventoryFromDiscard(inventory);
                    break;
                case TextWorkInventory.PackOption: 
                    uiInventory.RemoveItemFromInventory(cat, inventory);
                    break;
            }
        } while (cat.Location == Hero.Place.MainRoom);
    }
}