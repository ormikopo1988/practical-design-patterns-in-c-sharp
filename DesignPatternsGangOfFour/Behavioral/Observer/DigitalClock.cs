namespace DesignPatternsGangOfFour.Behavioral.Observer
{
    public class DigitalClock : Widget, IObserver
    {
        ClockTimer subject;

        public DigitalClock(ClockTimer subject)
        {
            this.subject = subject;

            this.subject.Attach(this);
        }

        // finalizer
        ~DigitalClock()
        {
            this.subject.Detach(this);
        }

        // Implements IObserver operation
        public void Update(Subject theChangedSubject)
        {
            if (theChangedSubject == this.subject)
            {
                this.Draw();
            }
        }

        // overrides Widget operation;
        // defines how to draw the digital clock
        public override void Draw()
        {
            // get the new values from the subject

            int hour = this.subject.GetHour();
            int minute = this.subject.GetMinute();
            
            // etc.
            // draw the digital clock
        }
    }
}