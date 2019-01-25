using DesignPatternsGangOfFour.Creational.Common;

namespace DesignPatternsGangOfFour.Creational.FactoryMethod
{
    public class MazeGame
    {
        // Factory Methods
        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        public virtual Room MakeRoom(int roomNumber)
        {
            return new Room(roomNumber);
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }

        public Maze CreateMaze()
        {
            Maze aMaze = this.MakeMaze();
            Room room1 = this.MakeRoom(1);
            Room room2 = this.MakeRoom(2);
            Door aDoor = this.MakeDoor(room1, room2);

            aMaze.AddRoom(room1);
            aMaze.AddRoom(room2);

            room1.SetSide(Direction.North, this.MakeWall());
            room1.SetSide(Direction.East, aDoor);
            room1.SetSide(Direction.South, this.MakeWall());
            room1.SetSide(Direction.West, this.MakeWall());

            room2.SetSide(Direction.North, this.MakeWall());
            room2.SetSide(Direction.East, this.MakeWall());
            room2.SetSide(Direction.South, this.MakeWall());
            room2.SetSide(Direction.West, aDoor);

            return aMaze;
        }
    }
}