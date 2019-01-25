namespace DesignPatternsGangOfFour.Structural.Adapter.Object
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