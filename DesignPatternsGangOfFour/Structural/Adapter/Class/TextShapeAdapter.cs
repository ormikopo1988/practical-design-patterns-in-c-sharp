using DesignPatternsGangOfFour.Structural.Common;

namespace DesignPatternsGangOfFour.Structural.Adapter.Class
{
    public class TextShapeAdapter : TextView, IShape
    {
        public TextShapeAdapter()
        {

        }

        public void BoundingBox(Point bottomLeft, Point topRight)
        {
            Coord bottom = new Coord(), left = new Coord(), width = new Coord(), height = new Coord();

            GetOrigin(bottom, left);
            GetExtent(width, height);

            bottomLeft = new Point(bottom.Value, left.Value);
            topRight = new Point(bottom.Value + height.Value, left.Value + width.Value);
        }

        public Manipulator CreateManipulator()
        {
            return new TextManipulator(this);
        }

        public override bool IsEmpty()
        {
            return base.IsEmpty();
        }
    }
}