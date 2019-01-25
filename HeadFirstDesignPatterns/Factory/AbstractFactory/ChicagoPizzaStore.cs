namespace HeadFirstDesignPatterns.Factory.AbstractFactory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory)
                {
                    Name = "Chicago Style Cheese Pizza"
                };
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory)
                {
                    Name = "Chicago Style Clam Pizza"
                };
            }

            return pizza;
        }
    }
}