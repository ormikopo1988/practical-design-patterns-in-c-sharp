using DesignPatternsGangOfFour.Structural.Common;

namespace DesignPatternsGangOfFour.Structural.Bridge
{
    public interface IWindowImp
    {
        void ImpTop();
        void ImpBottom();
        void ImpSetExtent(Point point);
        void ImpSetOrigin(Point point);
        void DeviceRect(Coord x0, Coord y0, Coord x1, Coord y1);
        void DeviceText(string text, Coord x0, Coord y0);
        void DeviceBitmap(string bitmapName, Coord x0, Coord y0);

        // lots more functions for drawing on windows...
    }
}