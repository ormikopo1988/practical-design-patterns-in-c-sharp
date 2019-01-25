namespace DesignPatternsGangOfFour.Structural.Adapter.Class
{
    public class TextManipulator : Manipulator
    {
        private TextShapeAdapter textShapeAdapter;

        public TextManipulator(TextShapeAdapter textShapeAdapter)
        {
            this.textShapeAdapter = textShapeAdapter;
        }
    }
}