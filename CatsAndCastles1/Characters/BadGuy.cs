namespace CatsAndCastles1.Characters;

public class BadGuy : Character
{
    public List<string> SpecificWording { get; set; }
    
    public enum Outcome
    {
        Success,
        Failure,
        Default
    }

    public Outcome Bribe { get; set; } = Outcome.Default;
    public Outcome Flee { get; set; } = Outcome.Default;
    

    public enum GuardType
    {
        Guard1,
        Guard2,
        Warden
    }

    public GuardType Type { get; set; }

    public BadGuy(List<string> encounterSpecificWording, GuardType guardType)
    {
        SpecificWording = encounterSpecificWording;
        Type = guardType;
    }
}