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
    }
    public Place Location { get; set; }
    // I'll use this to tell where the player is (passed out, third floor, second floor, first floor, outside castle)
    public int Lives { get; set; } = 3;
  public bool ReturningTo1F { get; set; }
    public bool FirstCombatTriggered { get; set; }
    
    
    
    public Hero(int health, int maxHealth)
    {
        Health = health;
        MaxHealth = maxHealth;
    }
    
}