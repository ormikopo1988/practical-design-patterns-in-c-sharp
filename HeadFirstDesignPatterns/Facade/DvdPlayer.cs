using System;

namespace HeadFirstDesignPatterns.Facade
{
    public class DvdPlayer
    {
        private Amplifier amplifier;

        public DvdPlayer(Amplifier amplifier)
        {
            this.amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("DvdPlayer on.");
        }

        public void Off()
        {
            Console.WriteLine("DvdPlayer off.");
        }

        public void Eject()
        {
            Console.WriteLine("DvdPlayer eject.");
        }

        public void Pause()
        {
            Console.WriteLine("DvdPlayer paused.");
        }

        public void Play(string movie)
        {
            Console.WriteLine($"DvdPlayer play movie '{movie}'.");
        }

        public void SetSurroundAudio()
        {
            Console.WriteLine("DvdPlayer set surround audio.");
        }

        public void SetTwoChannelAudio()
        {
            Console.WriteLine("DvdPlayer set two channel audio.");
        }

        public void Stop()
        {
            Console.WriteLine("DvdPlayer stopped.");
        }
    }
}