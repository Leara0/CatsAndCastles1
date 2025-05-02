using CatsAndCastles1.Characters;
using CatsAndCastles1.Lists;

namespace CatsAndCastles1.ClassInstantiation;

public class InstancesCharacters
{
    public Hero Cat { get; } = new Hero(135, 35);
    public BadGuy GuardDog1 { get; }
    public BadGuy GuardDog2 { get; }
    public BadGuy Warden { get; }


    public InstancesCharacters()
    {
        GuardDog1 = new BadGuy
        (
            ListGuardSpecificText.Guard1Wording,
            BadGuy.GuardType.Guard1
        );
        GuardDog1.Health = GuardDog1.SetHealth(15, 20);
        GuardDog1.MaxHealth = GuardDog1.Health;

        GuardDog2 = new BadGuy
        (
            ListGuardSpecificText.Guard2Wording,
            BadGuy.GuardType.Guard2
        );
        GuardDog2.Health = GuardDog2.SetHealth(15, 20);
        GuardDog2.MaxHealth = GuardDog2.Health;

        Warden = new BadGuy
        (
            ListGuardSpecificText.WardenWording,
            BadGuy.GuardType.Warden
        );
        Warden.Health = Warden.SetHealth(45,55);
        Warden.MaxHealth = Warden.Health;
        
        Cat.Location = Hero.Place.MainRoom;
    }
}