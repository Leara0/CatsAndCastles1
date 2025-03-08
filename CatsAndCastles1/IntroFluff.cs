namespace CatsAndCastles1;

public class IntroFluff
{
    public void IntroCutScene(Characters cat)
    {
        //readonly LocationText LocationText;
        Console.Clear();
        Console.WriteLine(LocationText.CatBorder1);
        Console.WriteLine(LocationText.IntroCutScene);
        StartInRoom();
    }

    public void SubsequentWakeUp(Characters cat)
    {
        cat.Health = 60;
        Console.WriteLine(LocationText.SubsequentWakeUp);
        StartInRoom();
    }

    public void StartInRoom()
    {
        Console.WriteLine(LocationText.StartInRoom);
        Console.ReadLine();
        //MainRoomMethod();
    }
}