namespace DesignPatternsGangOfFour.Behavioral.Observer
{
    public class Client
    {
        public void CreateDigitalClockWithTimer()
        {
            // Whenever the timer ticks, the clock will be updated and will redisplay
            // itself appropriately.
            ClockTimer timer = new ClockTimer();
            DigitalClock digitalClock = new DigitalClock(timer);
        }
    }
}