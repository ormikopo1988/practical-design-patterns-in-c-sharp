using DesignPatternsGangOfFour.Structural.Common;

namespace DesignPatternsGangOfFour.Structural.Adapter.Object
{
    public class TextShapeAdapter : IShape
    {
        private readonly TextView textView;

        public TextShapeAdapter(TextView textView)
        {
            this.textView = textView;
        }

        public void BoundingBox(Point bottomLeft, Point topRight)
        {
            Coord bottom = new Coord(), left = new Coord(), width = new Coord(), height = new Coord();

            textView.GetOrigin(bottom, left);
            textView.GetExtent(width, height);

            bottomLeft = new Point(bottom.Value, left.Value);
            topRight = new Point(bottom.Value + height.Value, left.Value + width.Value);
        }

        public Manipulator CreateManipulator()
        {
            return new TextManipulator(this);
        }

        public bool IsEmpty()
        {
            return textView.IsEmpty();
        }
    }
}
