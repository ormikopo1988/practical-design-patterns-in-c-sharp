using System;

namespace HeadFirstDesignPatterns.Facade
{
    public class Tuner
    {
        private Amplifier amplifier;

        public Tuner(Amplifier amplifier)
        {
            this.amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Tuner on.");
        }

        public void Off()
        {
            Console.WriteLine("Tuner off.");
        }

        public void SetAm()
        {
            Console.WriteLine("Tuner set am.");
        }

        public void SetFm()
        {
            Console.WriteLine("Tuner set fm.");
        }

        public void SetFrequency()
        {
            Console.WriteLine("Tuner set frequency.");
        }
    }
}