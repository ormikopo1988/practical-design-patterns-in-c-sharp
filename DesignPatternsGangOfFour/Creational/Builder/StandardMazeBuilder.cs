using DesignPatternsGangOfFour.Creational.Common;

namespace DesignPatternsGangOfFour.Creational.Builder
{
    public class StandardMazeBuilder : MazeBuilder
    {
        private Maze currentMaze;

        public StandardMazeBuilder()
        {
            currentMaze = null;
        }

        public override void BuildMaze()
        {
            currentMaze = new Maze();
        }

        public override void BuildRoom(int roomNumber)
        {
            if (currentMaze.RoomNo(roomNumber) == null)
            {
                Room room = new Room(roomNumber);

                currentMaze.AddRoom(room);

                room.SetSide(Direction.North, new Wall());
                room.SetSide(Direction.South, new Wall());
                room.SetSide(Direction.East, new Wall());
                room.SetSide(Direction.West, new Wall());
            }
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            Room r1 = currentMaze.RoomNo(roomFrom);
            Room r2 = currentMaze.RoomNo(roomTo);

            if(r1 != null && r2 != null)
            {
                Door d = new Door(r1, r2);

                r1.SetSide(CommonWall(r1, r2), d);
                r2.SetSide(CommonWall(r2, r1), d);
            }
        }

        public override Maze GetMaze()
        {
            return currentMaze;
        }

        private Direction CommonWall(Room room1, Room room2)
        {
            // Utility operation that determines the direction of the common
            // wall between two rooms
            return Direction.East;
        }
    }
}