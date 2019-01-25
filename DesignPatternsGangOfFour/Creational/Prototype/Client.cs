using DesignPatternsGangOfFour.Creational.AbstractFactory;
using DesignPatternsGangOfFour.Creational.Common;

namespace DesignPatternsGangOfFour.Creational.Prototype
{
    public class Client
    {
        public Maze CreateSimpleMazeGame()
        {
            MazeGame game = new MazeGame();

            MazePrototypeFactory simpleMazeFactory = new MazePrototypeFactory(
                new Maze(), 
                new Wall(), 
                new Room(), 
                new Door()
            );

            // To change the type of maze, we initialize MazePrototypeFactory with a different
            // set of prototypes. The following call creates a maze with a BombedDoor
            // and a RoomWithABomb:
            //MazePrototypeFactory bombedMazeFactory = new MazePrototypeFactory(
            //    new Maze(), 
            //    new BombedWall(),
            //    new RoomWithABomb(), 
            //    new Door()
            //);

            // An object that can be used as a prototype, such as an instance of Wall, must
            // support the Clone operation. It must also have a copy constructor for cloning.
            // It may also need a separate operation for reinitializing internal state.

            return game.CreateMaze(simpleMazeFactory);
        }
    }
}