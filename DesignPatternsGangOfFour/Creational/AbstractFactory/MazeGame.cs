using DesignPatternsGangOfFour.Creational.Common;

namespace DesignPatternsGangOfFour.Creational.AbstractFactory
{
    public class MazeGame
    {
        public Maze CreateMaze(MazeFactory factory)
        {
            Maze aMaze = factory.MakeMaze();
            Room room1 = factory.MakeRoom(1);
            Room room2 = factory.MakeRoom(2);
            Door aDoor = factory.MakeDoor(room1, room2);

            aMaze.AddRoom(room1);
            aMaze.AddRoom(room2);

            room1.SetSide(Direction.North, factory.MakeWall());
            room1.SetSide(Direction.East, aDoor);
            room1.SetSide(Direction.South, factory.MakeWall());
            room1.SetSide(Direction.West, factory.MakeWall());

            room2.SetSide(Direction.North, factory.MakeWall());
            room2.SetSide(Direction.East, factory.MakeWall());
            room2.SetSide(Direction.South, factory.MakeWall());
            room2.SetSide(Direction.West, aDoor);

            return aMaze;
        }
    }
}