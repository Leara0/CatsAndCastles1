namespace CatsAndCastles1.Characters;

public class BadGuy : Character
{
    public List<string> SpecificWording { get; set; }
    public List<string> GuardItems { get; set; }
    public List<string> GuardItemDescriptions { get; set; }
    public bool AttemptedBribeFailed { get; set; }
    public bool SuccessfullyBribed { get; set; }
    public bool CaughtCat { get; set; }

    public enum GuardType
    {
        Guard,
        Warden
    }

    public GuardType Type { get; set; }

    public BadGuy(List<string> encounterSpecificWording, List<string> itemsGuardHas,
        List<string> descriptionOfGuardItems, GuardType guardType)
    {
        SpecificWording = encounterSpecificWording;
        GuardItems = itemsGuardHas;
        GuardItemDescriptions = descriptionOfGuardItems;
        Type = guardType;
    }
}