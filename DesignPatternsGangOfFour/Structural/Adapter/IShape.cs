using DesignPatternsGangOfFour.Structural.Common;

namespace DesignPatternsGangOfFour.Structural.Adapter
{
    public interface IShape
    {
        void BoundingBox(Point bottomLeft, Point topRight);

        Manipulator CreateManipulator();
    }
}