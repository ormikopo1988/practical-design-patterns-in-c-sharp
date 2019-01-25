namespace HeadFirstDesignPatterns.Strategy
{
    public class NoQuack : IQuackBehavior
    {
        public void Quack()
        {
            // Silence...
        }
    }
}