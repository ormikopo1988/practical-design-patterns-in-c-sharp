namespace DesignPatternsGangOfFour.Structural.Bridge
{
    public class ApplicationWindow : Window
    {
        public ApplicationWindow(View contents)
            : base(contents)
        {

        }

        public override void DrawContents()
        {
            GetView().DrawOn(this);
        }
    }
}