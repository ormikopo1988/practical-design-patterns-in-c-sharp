namespace DesignPatternsGangOfFour.Creational.Singleton
{
    public class SingletonMazeFactory
    {
        private static SingletonMazeFactory instance = null;

        public static SingletonMazeFactory Instance()
        {
            if (instance == null)
            {
                instance = new SingletonMazeFactory();
            }

            return instance;
        }

        protected SingletonMazeFactory()
        {
            
        }
    }
}