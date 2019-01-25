namespace HeadFirstDesignPatterns.Adapter
{
    public class TurkeyAdapter : IDuck
    {
        private ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                this.turkey.Fly();
            }
        }

        public void Quack()
        {
            this.turkey.Gobble();
        }
    }
}