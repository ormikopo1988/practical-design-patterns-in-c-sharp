using System.Collections.Generic;

namespace DesignPatternsGangOfFour.Behavioral.Mediator
{
    public class ListBox : Widget
    {
        private List<string> listItems;

        public ListBox(DialogDirector dialogDirector) 
            : base(dialogDirector)
        {
            this.listItems = new List<string>();
        }

        public string GetSelection()
        {
            return "someListBoxSelectionFromListItemsField";
        }

        public void SetList(List<string> listItems)
        {
            this.listItems = listItems;
        }

        public override void HandleMouse(MouseEvent mouseEvent)
        {
            this.Changed();
        }

        // ...
    }
}