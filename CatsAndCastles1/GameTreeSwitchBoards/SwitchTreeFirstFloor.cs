using CatsAndCastles1.Characters;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;


public class SwitchTreeFirstFloor
{
    public void FirstFloorSwitchBoard(Hero cat, BadGuy warden)
    {
        warden.SuccessfullyBribed = false;
        cat.SuccessfulFlee = false;
    }
}