using DesignPatternsGangOfFour.Creational.AbstractFactory;
using DesignPatternsGangOfFour.Creational.Common;

namespace DesignPatternsGangOfFour.Creational.Prototype
{
    public class MazePrototypeFactory : MazeFactory
    {
        private readonly Maze prototypeMaze;
        private readonly Wall prototypeWall;
        private readonly Room prototypeRoom;
        private readonly Door prototypeDoor;

        public MazePrototypeFactory(
            Maze maze,
            Wall wall,
            Room room,
            Door door
        )
        {
            this.prototypeMaze = maze;
            this.prototypeWall = wall;
            this.prototypeRoom = room;
            this.prototypeDoor = door;
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            Door door = prototypeDoor.Clone();

            door.Initialize(room1, room2);

            return door;
        }

        public override Maze MakeMaze()
        {
            return prototypeMaze.Clone();
        }

        public override Room MakeRoom(int roomNumber)
        {
            Room room = prototypeRoom.Clone();

            room.Initialize(roomNumber);

            return room;
        }

        public override Wall MakeWall()
        {
            return prototypeWall.Clone();
        }
    }
}