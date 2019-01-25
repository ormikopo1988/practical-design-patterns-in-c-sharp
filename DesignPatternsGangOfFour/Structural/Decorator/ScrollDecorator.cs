namespace DesignPatternsGangOfFour.Structural.Decorator
{

    public class ScrollDecorator : Decorator
    {
        public ScrollDecorator(VisualComponent component)
            : base(component)
        {
        }

        public override void Draw()
        {
            base.Draw();
            AddScrolling();
        }

        private void AddScrolling()
        {
            // some implementation for adding scrolling capabilities
        }
    }
}