namespace CatsAndCastles1.Characters;

public abstract class Character
{
    public int Health { get; set; }
    public string Weapon { get; set; } = "";
    public int WeaponDie { get; set; }
    public int WeaponMod { get; set; }
    public bool HasShield { get; set; }
  public int MaxHealth { get; set; }
    
    public int SetHealth(int bottom, int top)
    {
        var rnd = new Random();
        return rnd.Next(bottom, top + 1);
    }
}