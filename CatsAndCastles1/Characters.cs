namespace CatsAndCastles1;


public class Characters
{
    private readonly UserInput _userInput = new UserInput();
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


    public int Health { get; set; }
    public string Name { get; set; } = "";
    public string Weapon { get; set; } = "";
    public int Lives { get; set; } = 4;


    public Place Location { get; set; }
    // I'll use this to tell where the player is (passed out, third floor, second floor, first floor, outside castle)
    public bool Caught { get; set; }
    public bool SuccessfulBribed { get; set; }
    public bool EndGame { get; set; }
    public bool HasShield { get; set; }


    public bool LostToGuard { get; set; }


    public int SetHealth(int bottom, int top)
    {
        var rnd = new Random();
        return rnd.Next(bottom, top + 1);
    }


    public bool LeftFirstFloor { get; set; }

    
}