using HeadFirstDesignPatterns.Facade;

namespace DesignPatternsConsoleClient.HeadFirstDesignPatterns.Facade
{
    public class HomeTheaterSimulator
    {
        public static void Start()
        {
            // instantiate components here
            Amplifier amp = new Amplifier();

            Tuner tuner = new Tuner(amp);
            DvdPlayer dvd = new DvdPlayer(amp);
            CdPlayer cd = new CdPlayer(amp);

            amp.SetCd(cd);
            amp.SetDvd(dvd);
            amp.SetTuner(tuner);
            
            Projector projector = new Projector(dvd);
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            PopcornPopper popper = new PopcornPopper();


            HomeTheaterFacade homeTheater = new HomeTheaterFacade(
                amp, cd, dvd, popper,
                projector, screen, lights, tuner
            );

            homeTheater.WatchMovie("Matrix Reloaded");
            homeTheater.EndMovie();
        }
    }
}