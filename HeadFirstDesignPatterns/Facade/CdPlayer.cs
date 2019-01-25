using System;

namespace HeadFirstDesignPatterns.Facade
{
    public class CdPlayer
    {
        private Amplifier amplifier;

        public CdPlayer(Amplifier amplifier)
        {
            this.amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("CdPlayer on.");
        }

        public void Off()
        {
            Console.WriteLine("CdPlayer off.");
        }

        public void Eject()
        {
            Console.WriteLine("CdPlayer eject.");
        }

        public void Pause()
        {
            Console.WriteLine("CdPlayer paused.");
        }

        public void Play()
        {
            Console.WriteLine("CdPlayer play.");
        }
        
        public void Stop()
        {
            Console.WriteLine("CdPlayer stopped.");
        }
    }
}