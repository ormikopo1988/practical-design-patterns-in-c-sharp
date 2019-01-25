namespace DesignPatternsGangOfFour.Structural.Decorator
{
    public abstract class Decorator : VisualComponent
    {
        private readonly VisualComponent component;

        public Decorator(VisualComponent component)
        {
            this.component = component;
        }

        public override void Draw()
        {
            this.component.Draw();
        }

        public override void Resize()
        {
            this.component.Resize();
        }
    }
}