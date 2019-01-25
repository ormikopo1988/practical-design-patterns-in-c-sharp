using System;

namespace HeadFirstDesignPatterns.Facade
{
    public class Amplifier
    {
        private Tuner tuner;
        private DvdPlayer dvdPlayer;
        private CdPlayer cdPlayer;
        
        public void On()
        {
            Console.WriteLine("Amplifier on.");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier off.");
        }

        public void SetStereoSound()
        {
            Console.WriteLine("Amplifier set stereo sound.");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier set surround sound.");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Amplifier set volume to {volume}.");
        }

        public void SetCd(CdPlayer cdPlayer)
        {
            this.cdPlayer = cdPlayer;
        }

        public void SetDvd(DvdPlayer dvdPlayer)
        {
            this.dvdPlayer = dvdPlayer;
        }

        public void SetTuner(Tuner tuner)
        {
            this.tuner = tuner;
        }
    }
}