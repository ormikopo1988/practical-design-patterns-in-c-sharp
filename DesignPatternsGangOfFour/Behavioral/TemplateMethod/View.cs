namespace DesignPatternsGangOfFour.Behavioral.TemplateMethod
{
    public abstract class View
    {
        public void Display()
        {
            SetFocus();
            DoDisplay();
            ResetFocus();
        }

        public virtual void SetFocus()
        {
            // Some concrete implementation
        }

        public virtual void ResetFocus()
        {
            // Some concrete implementation
        }

        public abstract void DoDisplay();
    }
}