using CatsAndCastles1.Characters;
using CatsAndCastles1.ClassInstantiation;
using CatsAndCastles1.GameTreeSwitchBoards;
using CatsAndCastles1.Text.Inventory;
using CatsAndCastles1.UserInteractions;

// ReSharper disable InconsistentNaming
// Using consistent acronyms like SF/TF/FF for location groupings.

namespace CatsAndCastles1;

public class MainStory
{
    public void RunGame()
    {
        #region instantiating Classes

        var instancesMainRoom = new InstancesMainRoom();
        var instancesThirdFloor = new InstancesThirdFloor();
        var instancesSecondFloor = new InstancesSecondFloor();
        var instancesFirstFloor = new InstancesFirstFloor();
        var instancesCharacters = new InstancesCharacters();
        // ReSharper restore InconsistentNaming

        var inventory = new Inventory();
        {
            inventory.Pack = new List<string>(); // creates a new pack 
            inventory.DiscardedItems = new List<string>(); // discard record
        }

        #endregion

        IntroFluff introFluff = new IntroFluff();
        introFluff.IntroCutScene();
        instancesMainRoom.MainRoom.PrintIntro();
        
        //@TODO get rid of this to make game not skip ahead
        inventory.AddGoldToPurse("50");
        inventory.Pack.Add(TextInventoryItems.Dagger);
        inventory.Pack.Add(TextInventoryItems.Shield);
        inventory.Pack.Add(TextInventoryItems.LockPickSet);
        inventory.Pack.Add(TextInventoryItems.RingOfKeys);
        inventory.Pack.Add(TextInventoryItems.ShortSword);
        instancesMainRoom.MainDoor.ChangeDoorLockStatus(true);
        
        

        do
        {
            switch (instancesCharacters.Cat.Location)
            {
                case Hero.Place.MainRoom:
                    SwitchTreeMainRoomGame.MainRoomSwitchboard(inventory, instancesCharacters.Cat, instancesMainRoom);
                    break;
                case Hero.Place.ThirdFloor:
                    SwitchTreeThirdFloor.ThirdFloorSwitchboard(inventory, instancesCharacters.Cat, instancesCharacters.GuardDog1,
                        instancesThirdFloor);
                    break;
                case Hero.Place.SecondFloor:
                    SwitchTreeSecondFloor.SecondFloorSwitchboard(inventory, instancesCharacters.Cat, instancesCharacters.GuardDog2,
                        instancesSecondFloor);
                    break;
                case Hero.Place.FirstFloor:
                    Screen.Print(
                        "Congrats on making it to the first floor. It's not built yet so you get to start over!");
                    UserInput.DramaticPauseClrScreen();
                    instancesCharacters.Cat.Location = Hero.Place.MainRoom;
                    break;
                case Hero.Place.OutsideCastle:
                    break;
                case Hero.Place.PassedOut:
                    break;
                case Hero.Place.Dead:
                    //code that ties things up
                    Environment.Exit(0);
                    break;
            }
        } while (true); //@TODO Change this!! Or maybe not and just end game with Environment.Exit(0);
    }
}