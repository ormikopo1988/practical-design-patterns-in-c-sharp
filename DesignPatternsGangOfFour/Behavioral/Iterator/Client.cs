namespace DesignPatternsGangOfFour.Behavioral.Iterator
{
    public class Client
    {
        public void PrintOperations()
        {
            List<Item> items = new List<Item>(50);

            // . . .

            ListIterator<Item> forward = new ListIterator<Item>(items);
            ReverseListIterator<Item> backward = new ReverseListIterator<Item>(items);

            PrintItems(forward);
            PrintItems(backward);
        }

        public void PrintItems(IIterator<Item> iterator)
        {
            for (iterator.First(); !iterator.IsDone(); iterator.Next())
            {
                iterator.CurrentItem().Print();
            }
        }
    }
}