namespace CatsAndCastles1.OldPartsOfTheGame;


public class Weapons
{
    public int[] WeaponChoice(string weapon)
    {
        int modifier = 0;
        int die = 0;
        switch (weapon) //@add consider adding more - maybe book of prayers has negative mod?
        {
            case "the broom and dust pan":
            case "the cat figurine":
                modifier = 1;
                die = 4;
                break;
            case "manacles":
                modifier = 2;
                die = 6;
                break;
            case "the dagger":
                modifier = 2;
                die = 8;
                break;
            case "the long dagger":
                modifier = 3;
                die = 8;
                break;
            case "a club":
            case "a bone":
            case "the fire poker":
                modifier = 2;
                die = 6;
                break;
            case "the large stone":
            case "the shield":
            case "the battered shield":
                modifier = 1;
                die = 6;
                break;
            case "empty":
                modifier = 0;
                die = 0;
                break;
            case "paws":
                modifier = 0;
                die = 4;
                break;
            case "the short sword":
                modifier = 1;
                die = 10;
                break;
        }


        return [die, modifier];
    }


    public int DefenseChoice(string defense)
    {
        switch (defense)
        {
            case "the shield":
            case "the crude shield":
            case "the worn shield":
            case "the sturdy shield":
                return 2;
            default:
                return 0;
        }
    }
}