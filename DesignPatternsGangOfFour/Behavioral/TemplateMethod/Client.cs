namespace DesignPatternsGangOfFour.Behavioral.TemplateMethod
{
    public class Client
    {
        public void UseTemplateMethod()
        {
            MyView myView = new MyView();

            myView.Display();
        }
    }
}