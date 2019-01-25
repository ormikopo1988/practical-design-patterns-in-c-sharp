using System;

namespace HeadFirstDesignPatterns.TemplateMethod
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();

            if(CustomerWantsCondiments())
            {
                AddContiments();
            }
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        // This is a hook - Subclasses may or may not wish to override this one and step into the algorithm.
        // For now just no or default implementation in the base class
        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        public abstract void Brew();
        public abstract void AddContiments();
    }
}