using DesignPatternsGangOfFour.Creational.Common;

namespace DesignPatternsGangOfFour.Creational.FactoryMethod
{
    public class BombedMazeGame : MazeGame
    {
        public override Room MakeRoom(int roomNumber)
        {
            return new RoomWithABomb(roomNumber);
        }

        public override Wall MakeWall()
        {
            return new BombedWall();
        }
    }
}