namespace CatsAndCastles1.Lists.ItemsAtLocations;

public class ListItemCreator
{
    public List<string> ListAlteredItems (List<string> originalList, string itemToAdd, int positionToAddAt)
    {
        originalList.Insert(positionToAddAt, itemToAdd);

        return originalList;
    }
}