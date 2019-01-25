using DesignPatternsGangOfFour.Creational.Common;

namespace DesignPatternsGangOfFour.Creational.Builder
{
    public class Client
    {
        public Maze BuildMaze()
        {
            Maze maze;

            MazeGame game = new MazeGame();
            StandardMazeBuilder builder = new StandardMazeBuilder();

            game.CreateMaze(builder);

            maze = builder.GetMaze();

            return maze;
        }

        public Maze BuildCountingMaze()
        {
            MazeGame game = new MazeGame();

            CountingMazeBuilder builder = new CountingMazeBuilder();

            var maze = game.CreateMaze(builder);

            builder.GetCounts(out int rooms, out int doors);

            return maze;
        }
    }
}