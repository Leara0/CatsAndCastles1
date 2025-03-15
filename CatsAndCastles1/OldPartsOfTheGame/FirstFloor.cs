namespace CatsAndCastles1;


public class FirstFloor
{
    private readonly UserInput _userInput = new UserInput();
    private readonly Fight fight = new Fight();
   public void FirstFloorStory(MainCharacter cat, BackPack backPack, Character warden)
   {
       cat.SuccessfulBribed = false;
       Console.WriteLine("You descend the stairs, each step measured, each breath steady.");
       if(warden.IsDead)
           Console.WriteLine("\nAs you reach the main floor, a vast room opens up before you. It's purpose is unclear " +
                             "but you don't feel drawn to investigate.");
       if (!warden.IsDead)
       {
           Console.WriteLine("As you reach the main floor, " +
                             "the atmosphere shifts—heavy, charged, dangerous. The room before you is vast, its purpose " +
                             "unclear, but there is no time to dwell on the details." +
                             "\n\nBecause you are not alone.");
           fight.GuardDogEncounter(cat, backPack, warden, 2);
       }


       // stuff here to wrap things up is you get past him
       if (warden.IsDead || cat.SuccessfulBribed)
       {
           if (warden.IsDead && !cat.LeftFirstFloor)
               Console.WriteLine(
                   "\nThe battle was brutal. The Warden was relentless. You dodged, clawed, bit, and fought " +
                   "with everything you had." +
                   "\n\nNow, the Warden lies motionless, its massive form still, its armor dented and " +
                   "bloodied. You stand victorious. Your body aches, your breath comes ragged, " +
                   "but you are alive." +
                   "\n\nAnd then — you see it.\n");
           Console.WriteLine("\nBeyond the Warden’s form, a door stands ajar. A whisper of wind drifts in, " +
                             "carrying scents of grass, damp earth, and freedom. The world beyond is still out of " +
                             "reach, but not for long. You stand at the threshold of the open door, the outside world " +
                             "beckoning you with its cool night air and the scent of freedom just beyond. But the " +
                             "castle calls to you too — its dim halls, its hidden rooms full of untold secrets. " +
                             "Perhaps there’s more you could find, something that could aid you in your journey " +
                             "into the unknown. You hesitate for a moment, torn between leaving the castle behind and " +
                             "venturing deeper into it.");
           Console.WriteLine("\nPress '1' to leave the castle or '2' to return back up the stairs and continue " +
                             "exploring the castle");
           if (cat.SuccessfulBribed)
               Console.WriteLine("Bear in mind, if you leave this floor the guard will expect another bribe or a " +
                                 "fight");
           if (_userInput.UserChoice() == "1")
           {
               Console.WriteLine("\nYou stagger forward, each step pulling you away from the gloom of the castle, " +
                                 "away from the danger, away from death itself. One final push, and are free.");
               cat.Location = MainCharacter.Place.OutsideCastle;
           }
           else
           {
               cat.LeftFirstFloor = true;
               Console.WriteLine("Instead of stepping through to freedom, you turn away from the threshold and begin " +
                                 "to ascend the stairs." +
                                 "\n\nWith each measured step upward, the castle’s secrets and hidden supplies s" +
                                 "eem to whisper in the silence. Your decision isn’t made out of fear, but of " +
                                 "resolve — there’s more to be gathered, more to be learned before you face the " +
                                 "unknown outside. As you reach the landing, you wonder what other tools or clues " +
                                 "might lie waiting in the higher levels of this ancient fortress.");
               cat.Location = MainCharacter.Place.SecondFloor;
               Console.WriteLine("Press 'enter' to continue");
               Console.ReadLine();
               Console.Clear();
           }
       }
       else if (cat.Location == MainCharacter.Place.SecondFloor)
           return;
       else
       {
           cat.LostToGuard = true;
           cat.Location = MainCharacter.Place.PassedOut;
       }
   }
}

