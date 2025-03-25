namespace CatsAndCastles1.Characters;

public class Character
{
    public int Health { get; set; }
    public string Weapon { get; set; } = "";
    public bool SuccessfulBribed { get; set; }
    public bool HasShield { get; set; }
    public bool IsDead { get; set; }

    public int SetHealth(int bottom, int top)
    {
        var rnd = new Random();
        return rnd.Next(bottom, top + 1);
    }
}