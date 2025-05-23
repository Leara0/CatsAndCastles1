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
        UIInventory uiInventory = new UIInventory();

        do
        {
            int number = instanceMR.MainRoom.DecideWhereToExplore();
            var whereToExplore = "";
            if (number == ListOptionsAtLocations.MainRoomChoices.Count)
                whereToExplore = TextWorkInventory.PackOption;
            else
                whereToExplore = ListOptionsAtLocations.MainRoomChoices[number];
            Console.Clear();
            switch (whereToExplore) //this is a call on the BaseLocation class
            {
                case TextMainRoom.ExitDoor: // this is the only exit!!!

                    SwitchTreeLockedDoor.DoorsSwitchboard(inventory, cat, instanceMR.MainDoor);
                    if (instanceMR.MainDoor.DoorIsOpen())
                        cat.Location = Hero.Place.ThirdFloor;
                    break;
                case TextMainRoom.ClosetDoor:
                    instanceMR.Closet.VisitLocation(inventory);
                    break;
                case TextMainRoom.WindowOption:
                    SwitchTreeWindow.WindowSwitchboard(inventory, cat, instanceMR.LocationsWindow);
                    break;
                case TextMainRoom.NightStandOption:
                    instanceMR.Nightstand.VisitLocation(inventory);
                    break;
                case TextMainRoom.BookshelfOption:
                    instanceMR.Bookshelf.VisitLocation(inventory);
                    break;
                case TextMainRoom.HearthOption:
                    instanceMR.Hearth.VisitLocation(inventory);
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