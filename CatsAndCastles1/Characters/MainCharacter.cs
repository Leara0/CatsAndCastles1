namespace CatsAndCastles1;

public class MainCharacter:Character
{
    public enum Place
    {
        MainRoom,
        OutsideCastle,
        PassedOut,
        ThirdFloor,
        SecondFloor,
        FirstFloor,
        Dead
    }
    public Place Location { get; set; }
    // I'll use this to tell where the player is (passed out, third floor, second floor, first floor, outside castle)
    public int Lives { get; set; } = 4;
    public bool Caught { get; set; }
    public bool EndGame { get; set; }
    public bool LeftFirstFloor { get; set; }
    
    public bool LostToGuard { get; set; }
    
}