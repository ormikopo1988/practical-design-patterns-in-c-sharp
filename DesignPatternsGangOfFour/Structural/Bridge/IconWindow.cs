using DesignPatternsGangOfFour.Structural.Common;

namespace DesignPatternsGangOfFour.Structural.Bridge
{
    public class IconWindow : Window
    {
        private readonly string bitmapName;

        public IconWindow(View contents, string bitmapName) 
            : base(contents)
        {
            this.bitmapName = bitmapName;
        }

        public override void DrawContents()
        {
            IWindowImp imp = this.GetWindowImpl();

            if (imp != null)
            {
                imp.DeviceBitmap(bitmapName, new Coord(0.0), new Coord(0.0));
            }
        }
    }
}