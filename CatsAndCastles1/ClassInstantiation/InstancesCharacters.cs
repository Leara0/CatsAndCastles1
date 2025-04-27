using CatsAndCastles1.Characters;
using CatsAndCastles1.Lists;
using CatsAndCastles1.Lists.ItemsAtLocations;

namespace CatsAndCastles1.ClassInstantiation;

public class InstancesCharacters
{
    public Hero Cat { get; } = new Hero(60, 60);
    public BadGuy GuardDog1 { get; }
    public BadGuy GuardDog2 { get; }
    public BadGuy Warden { get; }


    public InstancesCharacters()
    {
        GuardDog1 = new BadGuy
        (
            ListGuardSpecificText.Guard1Wording,
            BadGuy.GuardType.Guard
        );
        GuardDog1.Health = GuardDog1.SetHealth(25, 35);
        GuardDog1.MaxHealth = GuardDog1.Health;

        GuardDog2 = new BadGuy
        (
            ListGuardSpecificText.Guard2Wording,
            BadGuy.GuardType.Guard
        );
        GuardDog2.Health = GuardDog2.SetHealth(25, 35);
        GuardDog2.MaxHealth = GuardDog2.Health;

        Warden = new BadGuy
        (
            ListGuardSpecificText.WardenWording,
            BadGuy.GuardType.Warden
        );
        Warden.Health = Warden.SetHealth(60, 75);
        Warden.MaxHealth = Warden.Health;
        
        Cat.Location = Hero.Place.MainRoom;
    }
}