namespace DesignPatternsGangOfFour.Creational.Builder
{
    public class CountingMazeBuilder : MazeBuilder
    {
        private int rooms;
        private int doors;

        public CountingMazeBuilder()
        {
            this.rooms = 0;
            this.doors = 0;
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            rooms++;
        }

        public override void BuildRoom(int roomNumber)
        {
            doors++;
        }

        public void GetCounts(out int rooms, out int doors)
        {
            rooms = this.rooms;
            doors = this.doors;
        }
    }
}