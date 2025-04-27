using CatsAndCastles1.Characters;
using CatsAndCastles1.LocationClasses;
using CatsAndCastles1.UserInteractions;

namespace CatsAndCastles1.GameTreeSwitchBoards;


public class SwitchTree1F
{
    public void FirstFloorSwitchBoard(Hero cat, BadGuy warden)
    {
        warden.Flee = BadGuy.Outcome.Default;
        warden.Bribe = BadGuy.Outcome.Default;
    }
}