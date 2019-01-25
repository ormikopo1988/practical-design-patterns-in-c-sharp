namespace DesignPatternsGangOfFour.Structural.Decorator
{
    public class BorderDecorator : Decorator
    {
        private readonly int borderWidth;

        public BorderDecorator(VisualComponent component, int borderWidth) 
            : base(component)
        {
            this.borderWidth = borderWidth;
        }

        public override void Draw()
        {
            base.Draw();
            DrawBorder(this.borderWidth);
        }

        private void DrawBorder(int borderWidth)
        {
            // some implementation for drawing a border of width equal to borderWidth
        }
    }
}