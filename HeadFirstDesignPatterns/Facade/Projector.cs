using System;

namespace HeadFirstDesignPatterns.Facade
{
    public class Projector
    {
        private DvdPlayer dvdPlayer;

        public Projector(DvdPlayer dvdPlayer)
        {
            this.dvdPlayer = dvdPlayer;
        }

        public void On()
        {
            Console.WriteLine("Projector on.");
        }

        public void Off()
        {
            Console.WriteLine("Projector off.");
        }

        public void TvMode()
        {
            Console.WriteLine("Projector TV mode.");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector wide screen mode.");
        }
    }
}