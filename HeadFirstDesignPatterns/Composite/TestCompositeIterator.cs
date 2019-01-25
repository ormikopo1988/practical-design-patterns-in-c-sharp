namespace HeadFirstDesignPatterns.Composite
{
    public class TestCompositeIterator
    {
        public static void Start(MenuComponent component)
        {
            var componentIterator = component.CreateIterator();

            CompositeIterator iterator = new CompositeIterator(componentIterator);

            while (iterator.MoveNext())
            {
                MenuComponent innerComponent = iterator.Current as MenuComponent;
            }
        }
    }
}