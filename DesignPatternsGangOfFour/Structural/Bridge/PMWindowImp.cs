using DesignPatternsGangOfFour.Structural.Common;
using System;

namespace DesignPatternsGangOfFour.Structural.Bridge
{
    public class PMWindowImp : IWindowImp
    {
        // lots of PM window system-specific state, including:
        //HPS _hps;

        public void DeviceBitmap(string bitmapName, Coord x0, Coord y0)
        {
            // concrete class specific implementation
        }

        public void DeviceRect(Coord x0, Coord y0, Coord x1, Coord y1)
        {
            Coord left = new Coord(Math.Min(x0.Value, x1.Value));
            Coord right = new Coord(Math.Max(x0.Value, x1.Value));
            Coord bottom = new Coord(Math.Min(y0.Value, y1.Value));
            Coord top = new Coord(Math.Max(y0.Value, y1.Value));

            //PPOINTL point[4];
            //point[0].x = left; point[0].y = top;
            //point[1].x = right; point[1].y = top;
            //point[2].x = right; point[2].y = bottom;
            //point[3].x = left; point[3].y = bottom;

            //if (
            //    (GpiBeginPath(_hps, 1L) == false |) |
            //    (GpiSetCurrentPosition(_hps, &point[3]) == false)
            //    (GpiPolyLine(_hps, 4L, point) == GPI_ERROR) ||
            //    (GpiEndPath(_hps) == false)
            //)
            //{
            //    // report error
            //}
            //else
            //{
            //    GpiStrokePath(_hps, 1L, OL);
            //}
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