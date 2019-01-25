using System.Collections.Generic;

namespace DesignPatternsGangOfFour.Creational.Common
{
    public class Room : MapSite
    {
        public int RoomNumber { get; private set; }

        private Dictionary<Direction, MapSite> mapSites;

        public Room()
        {
            this.RoomNumber = 0;
        }

        public Room(int roomNumber)
        {
            this.RoomNumber = roomNumber;
            this.mapSites = new Dictionary<Direction, MapSite>();
        }

        public MapSite GetSide(Direction direction)
        {
            MapSite mapSite = null;

            mapSites.TryGetValue(direction, out mapSite);

            return mapSite;
        }

        public void SetSide(Direction direction, MapSite mapSite)
        {
            mapSites.Add(direction, mapSite);
        }

        public override void Enter()
        {

        }

        // Extra implementation for supporting the prototype pattern
        // Copy constructor for prototype pattern
        public Room(Room roomToClone)
        {
            this.RoomNumber = roomToClone.RoomNumber;
        }

        public virtual void Initialize(int roomNumber)
        {
            this.RoomNumber = roomNumber;
        }

        public virtual Room Clone()
        {
            return new Room(this);
        }
    }
}