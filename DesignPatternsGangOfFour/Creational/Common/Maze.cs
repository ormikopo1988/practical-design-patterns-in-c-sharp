using System.Collections.Generic;

namespace DesignPatternsGangOfFour.Creational.Common
{
    public class Maze
    {
        public Dictionary<int, Room> Rooms { get; private set; }

        public Maze()
        {
            this.Rooms = new Dictionary<int, Room>();
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room.RoomNumber, room);
        }

        public Room RoomNo(int roomNumber)
        {
            Room room = null;

            Rooms.TryGetValue(roomNumber, out room);

            return room;
        }

        // Extra implementation for supporting the prototype pattern
        // Copy constructor for prototype pattern
        public Maze(Maze mazeToClone)
        {
            this.Rooms = mazeToClone.Rooms;
        }

        public virtual void Initialize(Dictionary<int, Room> rooms)
        {
            this.Rooms = rooms;
        }

        public virtual Maze Clone()
        {
            return new Maze(this);
        }
    }
}