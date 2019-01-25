namespace DesignPatternsGangOfFour.Structural.Decorator
{
    public class Client
    {
        public void CreateBorderedScrollableView()
        {
            TextView textView = new TextView();

            // TextView is a VisualComponent, which lets us put it into SetContents
            SetContents(textView);

            // But we want a bordered and scrollable TextView. So we decorate it accordingly
            // before calling the SetContents method.
            var scrollingTextView = new ScrollDecorator(textView);
            var scrollingTextViewWithBorder = new BorderDecorator(scrollingTextView, 1);

            SetContents(scrollingTextViewWithBorder);
        }

        public void SetContents(VisualComponent content)
        {
            // Some Implementation
        }
    }
}