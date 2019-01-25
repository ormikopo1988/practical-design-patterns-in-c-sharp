using System;

namespace HeadFirstDesignPatterns.Adapter
{
    public class DuckAdapter : ITurkey
    {
        private IDuck duck;
        private Random random;

        public DuckAdapter(IDuck duck)
        {
            this.duck = duck;
            this.random = new Random();
        }

        public void Fly()
        {
            if (random.Next(5) == 0)
            {
                duck.Fly();
            }
        }

        public void Gobble()
        {
            this.duck.Quack();
        }
    }
}