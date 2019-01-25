namespace HeadFirstDesignPatterns.Factory.FactoryMethod
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza() 
            : base("NY Style Sauce and Cheese Pizza", "Thin Crust Dough", "Marinara Sauce")
        {
            this.Toppings.Add("Grated Reggiano Cheese");
        }
    }
}