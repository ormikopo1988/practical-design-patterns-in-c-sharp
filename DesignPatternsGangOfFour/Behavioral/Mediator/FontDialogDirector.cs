namespace DesignPatternsGangOfFour.Behavioral.Mediator
{
    public class FontDialogDirector : DialogDirector
    {
        private Button okButton;
        private Button cancelButton;
        private ListBox fontList;
        private EntryField fontName;

        public override void WidgetChanged(Widget theChangedWidget)
        {
            if (theChangedWidget == fontList)
            {
                fontName.SetText(fontList.GetSelection());
            }
            else if (theChangedWidget == okButton)
            {
                // apply font change and dismiss dialog
                // . . .
            }
            else if(theChangedWidget == cancelButton)
            {
                // dismiss dialog
            }
        }

        protected override void CreateWidgets()
        {
            okButton = new Button(this);
            cancelButton = new Button(this);
            fontList = new ListBox(this);
            fontName = new EntryField(this);

            // fill the listBox with the available font names

            // assemble the widgets in the dialog
        }
    }
}