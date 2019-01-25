using DesignPatternsGangOfFour.Structural.Common;
using System;

namespace DesignPatternsGangOfFour.Structural.Bridge
{
    public class XWindowImp : IWindowImp
    {
        // lots of X window system-specific state, including:
        //Display dpy;
        //Drawable winid; // window id
        //GC gc; // window graphic context

        public void DeviceBitmap(string bitmapName, Coord x0, Coord y0)
        {
            // concrete class specific implementation
        }

        public void DeviceRect(Coord x0, Coord y0, Coord x1, Coord y1)
        {
            int x = (int)Math.Round(Math.Min(x0.Value, x1.Value));
            int y = (int)Math.Round(Math.Min(y0.Value, y1.Value));
            int w = (int)Math.Round(Math.Abs(x0.Value - x1.Value));
            int h = (int)Math.Round(Math.Abs(y0.Value - y1.Value));

            //XDrawRectangle(_dpy, _winid, _gc, x, y, w, h);
        }

        public void DeviceText(string text, Coord x0, Coord y0)
        {
            // concrete class specific implementation
        }

        public void ImpBottom()
        {
            // concrete class specific implementation
        }

        public void ImpSetExtent(Point point)
        {
            // concrete class specific implementation
        }

        public void ImpSetOrigin(Point point)
        {
            // concrete class specific implementation
        }

        public void ImpTop()
        {
            // concrete class specific implementation
        }
    }
}