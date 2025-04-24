namespace CatsAndCastles1.Characters;

public class Hero:Character
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
    public bool Caught { get; set; }//@TODO get rid of this with the old part of the game
    public bool SuccessfulBribed { get; set; }
    public bool EndGame { get; set; }
    public bool LeftFirstFloor { get; set; }
    public bool LostToGuard { get; set; }

    public Hero(int health, int maxHealth)
    {
        Health = health;
        MaxHealth = maxHealth;
    }
    
}