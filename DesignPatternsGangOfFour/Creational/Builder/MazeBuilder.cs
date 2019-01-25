using DesignPatternsGangOfFour.Creational.Common;

namespace DesignPatternsGangOfFour.Creational.Builder
{
    public class MazeBuilder
    {
        public MazeBuilder()
        {

        }

        public virtual void BuildMaze()
        {

        }

        public virtual void BuildRoom(int roomNumber)
        {

        }

        public virtual void BuildDoor(int roomFrom, int roomTo)
        {

        }

        public virtual Maze GetMaze()
        {
            return null;
        }
    }
}
