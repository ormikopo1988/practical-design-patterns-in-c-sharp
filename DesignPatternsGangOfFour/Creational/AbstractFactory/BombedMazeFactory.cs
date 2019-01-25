using DesignPatternsGangOfFour.Creational.Common;

namespace DesignPatternsGangOfFour.Creational.AbstractFactory
{
    public class BombedMazeFactory : MazeFactory
    {
        public BombedMazeFactory()
        {

        }

        public override Wall MakeWall()
        {
            return new BombedWall();
        }

        public override Room MakeRoom(int roomNumber)
        {
            return new RoomWithABomb(roomNumber);
        }
    }
}
