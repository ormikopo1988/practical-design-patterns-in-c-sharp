namespace DesignPatternsGangOfFour.Creational.AbstractFactory
{
    public class Client
    {
        public MazeGame CreateSimpleMazeGame()
        {
            MazeGame game = new MazeGame();

            MazeFactory factory = new MazeFactory();

            game.CreateMaze(factory);

            return game;
        }

        public MazeGame CreateEnchanedMazeGame()
        {
            MazeGame game = new MazeGame();

            MazeFactory factory = new EnchantedMazeFactory();

            game.CreateMaze(factory);

            return game;
        }

        public MazeGame CreateMazeGameWithBombs()
        {
            MazeGame game = new MazeGame();

            MazeFactory factory = new BombedMazeFactory();

            game.CreateMaze(factory);

            return game;
        }
    }
}