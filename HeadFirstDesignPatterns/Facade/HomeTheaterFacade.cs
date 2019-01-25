using System;

namespace HeadFirstDesignPatterns.Facade
{
    public class HomeTheaterFacade
    {
        private Amplifier amplifier;
        private CdPlayer cdPlayer;
        private DvdPlayer dvdPlayer;
        private PopcornPopper popcornPopper;
        private Projector projector;
        private Screen screen;
        private TheaterLights theaterLights;
        private Tuner tuner;

        public HomeTheaterFacade(
            Amplifier amplifier,
            CdPlayer cdPlayer,
            DvdPlayer dvdPlayer,
            PopcornPopper popcornPopper,
            Projector projector,
            Screen screen,
            TheaterLights theaterLights,
            Tuner tuner
        )
        {
            this.amplifier = amplifier;
            this.cdPlayer = cdPlayer;
            this.dvdPlayer = dvdPlayer;
            this.popcornPopper = popcornPopper;
            this.projector = projector;
            this.screen = screen;
            this.theaterLights = theaterLights;
            this.tuner = tuner;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");

            this.popcornPopper.On();
            this.popcornPopper.Pop();

            this.theaterLights.Dim(10);

            this.screen.Down();

            this.projector.On();
            this.projector.WideScreenMode();

            this.amplifier.On();
            this.amplifier.SetDvd(this.dvdPlayer);
            this.amplifier.SetSurroundSound();
            this.amplifier.SetVolume(5);

            this.dvdPlayer.On();
            this.dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");

            this.popcornPopper.Off();

            this.theaterLights.On();

            this.screen.Up();

            this.projector.Off();

            this.amplifier.Off();

            this.dvdPlayer.Stop();
            this.dvdPlayer.Eject();
            this.dvdPlayer.Off();
        }

        public void ListenToCd()
        {
            // Some logic like the WatchMovie and EndMovie methods
        }

        public void EndCd()
        {
            // Some logic like the WatchMovie and EndMovie methods
        }

        public void ListenToRadio()
        {
            // Some logic like the WatchMovie and EndMovie methods
        }

        public void EndRadio()
        {
            // Some logic like the WatchMovie and EndMovie methods
        }
    }
}