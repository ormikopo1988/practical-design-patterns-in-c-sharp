using System;

namespace HeadFirstDesignPatterns.Command
{
    public class Stereo
    {
        private string stereoPlace;

        public Stereo(string stereoPlace)
        {
            this.stereoPlace = stereoPlace;
        }

        public void On()
        {
            Console.WriteLine($"Stereo in {this.stereoPlace} on.");
        }

        public void Off()
        {
            Console.WriteLine($"Stereo in {this.stereoPlace} off.");
        }

        public void SetCD()
        {
            Console.WriteLine($"Stereo in {this.stereoPlace} cd set.");
        }

        public void SetDVD()
        {
            Console.WriteLine($"Stereo in {this.stereoPlace} dvd set.");
        }

        public void SetRadio()
        {
            Console.WriteLine($"Stereo in {this.stereoPlace} radio set.");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Stereo in {this.stereoPlace} volume set to " + volume + ".");
        }
    }
}