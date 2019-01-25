using DesignPatternsGangOfFour.Structural.Common;

namespace DesignPatternsGangOfFour.Structural.Bridge
{
    public class Window
    {
        private IWindowImp imp;
        private View contents; // the window's contents

        public Window(View contents)
        {
            this.imp = null;
            this.contents = contents;
        }

        // requests handled by window
        public virtual void DrawContents()
        {
            // some default implementation
        }
        public virtual void Open()
        {
            // some default implementation
        }
        public virtual void Close()
        {
            // some default implementation
        }
        public virtual void Iconify()
        {
            // some default implementation
        }
        public virtual void DeIconify()
        {
            // some default implementation
        }

        // requests forwarded to implementation
        public virtual void SetOrigin(Point at)
        {
            this.imp.ImpSetOrigin(at);
        }
        public virtual void SetExtent(Point extent)
        {
            this.imp.ImpSetExtent(extent);
        }
        public virtual void Raise()
        {
            this.imp.ImpTop();
        }
        public virtual void Lower()
        {
            this.imp.ImpBottom();
        }
        public virtual void DrawLine(Point point1, Point point2)
        {
            // some default implementation by delegating to imp
        }
        public virtual void DrawRect(Point point1, Point point2)
        {
            IWindowImp imp = this.GetWindowImpl();

            imp.DeviceRect(new Coord(point1.X), new Coord(point1.Y), new Coord(point2.X), new Coord(point2.Y));
        }
        public virtual void DrawPolygon(Point[] points, int n)
        {
            // some default implementation by delegating to imp
        }
        public virtual void DrawText(string text, Point point)
        {
            // some default implementation by delegating to imp
        }

        protected IWindowImp GetWindowImpl()
        {
            if (imp == null)
            {
                // Its GetWindowImp operation
                // gets the right instance from an abstract factory(see Abstract Factory)
                // that effectively encapsulates all window system specifics.

                //imp = WindowSystemFactory.Instance.MakeWindowImp();
            }

            return imp;
        }
        protected View GetView()
        {
            // some default implementation
            return new View();
        }
    }
}