namespace DesignPatternsGangOfFour.Behavioral.Observer
{
    public class ClockTimer : Subject
    {
        public int GetHour()
        {
            // Some Implementation
            return 10;
        }

        public int GetMinute()
        {
            // Some Implementation
            return 10;
        }

        public int GetSecond()
        {
            // Some Implementation
            return 10;
        }

        public void Tick()
        {
            // update internal time-keeping state
            // . . .

            this.Notify();
        }
    }
}