using System;

namespace HeadFirstDesignPatterns.TemplateMethod
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
        
        public override void AddContiments()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}