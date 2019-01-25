namespace DesignPatternsGangOfFour.Creational.Common
{
    public class RoomWithABomb : Room
    {
        public RoomWithABomb()
            : base()
        {

        }

        public RoomWithABomb(int roomNumber) 
            : base(roomNumber)
        {
        }
    }
}