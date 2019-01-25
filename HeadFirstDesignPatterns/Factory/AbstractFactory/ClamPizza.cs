using System;

namespace HeadFirstDesignPatterns.Factory.AbstractFactory
{
    public class ClamPizza : Pizza
    {
        private IPizzaIngredientFactory ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + this.Name);

            this.Dough = ingredientFactory.CreateDough();
            this.Sauce = ingredientFactory.CreateSauce();
            this.Cheese = ingredientFactory.CreateCheese();
            this.Clam = ingredientFactory.CreateClam();
        }
    }
}