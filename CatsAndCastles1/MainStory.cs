using CatsAndCastles1.Characters;
using CatsAndCastles1.ClassInstantiation;
using CatsAndCastles1.EndOfGame.PassOutOrDie;
using CatsAndCastles1.EndOfGame.WinGame;
using CatsAndCastles1.GameTreeSwitchBoards;
using CatsAndCastles1.Text.Inventory;

// ReSharper disable InconsistentNaming
// Using consistent acronyms like SF/TF/FF for location groupings.

namespace CatsAndCastles1;

public class MainStory
{
    //@TODO still:
    //check window and rope
    public void RunGame()
    {
        #region instantiating Classes

        var instancesMainRoom = new InstancesMainR();
        var instances3F = new Instances3F();
        var instances2F = new Instances2F();
        var instances1F = new Instances1F();
        var instancesCharacters = new InstancesCharacters();

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
        inventory.Pack.Add(TextInventoryItems.HardCheese);
        inventory.Pack.Add(TextInventoryItems.Shield);
        inventory.Pack.Add(TextInventoryItems.RustedLanternDesc);
        inventory.Pack.Add(TextInventoryItems.RingOfKeys);
        inventory.Pack.Add(TextInventoryItems.ShortSword);
        instancesMainRoom.MainDoor.ChangeDoorLockStatus(true);
        instancesCharacters.GuardDog1.Health = 0;
        instancesCharacters.GuardDog2.Health = 0;
        instancesCharacters.Warden.Health = 0;
        instancesCharacters.Cat.Health = 5;
        
        do
        {
            switch (instancesCharacters.Cat.Location)
            {
                case Hero.Place.MainRoom:
                    SwitchTreeMainR.MainRoomSwitchboard(inventory, instancesCharacters.Cat, instancesMainRoom);
                    break;
                case Hero.Place.ThirdFloor:
                    SwitchTree3F.ThirdFloorSwitchboard(inventory, instancesCharacters.Cat, instancesCharacters.GuardDog1,
                        instances3F);
                    break;
                case Hero.Place.SecondFloor:
                    SwitchTree2F.SecondFloorSwitchboard(inventory, instancesCharacters.Cat, instancesCharacters.GuardDog2,
                        instances2F);
                    break;
                case Hero.Place.FirstFloor:
                    SwitchTree1F.FirstFloorSwitchBoard(inventory, instancesCharacters.Cat,
                        instancesCharacters.Warden,
                        instances1F);
                    break;
                case Hero.Place.OutsideCastle:
                    WinGameCutScene.WinCutScene(inventory);
                    Environment.Exit(0);
                    break;
                case Hero.Place.PassedOut:
                    PassOut.LooseALife(instancesCharacters.Cat);
                    break;
                case Hero.Place.Escaped://@TODO Get rid?
                   
                    break;
            }
        } while (true); //@TODO Change this!! Or maybe not and just end game with Environment.Exit(0);
    }
}