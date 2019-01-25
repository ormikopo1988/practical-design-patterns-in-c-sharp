using System;

namespace HeadFirstDesignPatterns.TemplateMethod
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
        
        public override void AddContiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool CustomerWantsCondiments()
        {
            string answer = getUserInput();

            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string getUserInput()
        {
            string answer = null;

            Console.WriteLine("Would you like milk and sugar with your coffee (y / n) ?");

            answer = Console.ReadLine();

            if (answer == null)
            {
                return "no";
            }

            return answer;
        }
    }
}