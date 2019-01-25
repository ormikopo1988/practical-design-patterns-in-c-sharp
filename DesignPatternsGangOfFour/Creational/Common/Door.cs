namespace DesignPatternsGangOfFour.Creational.Common
{
    public class Door : MapSite
    {
        public Room Room1 { get; private set; }
        public Room Room2 { get; private set; }
        public bool IsOpen { get; private set; }

        public Door()
        {
            this.Room1 = null;
            this.Room2 = null;
            this.IsOpen = false;
        }

        public Door(Room room1, Room room2, bool isOpen = false)
        {
            this.Room1 = room1;
            this.Room2 = room2;
            this.IsOpen = isOpen;
        }

        public override void Enter()
        {

        }

        public Room OtherSideFrom(Room room)
        {
            if(room.RoomNumber == this.Room1.RoomNumber)
            {
                return this.Room2;
            }

            return this.Room1;
        }

        // Extra implementation for supporting the prototype pattern
        // Copy constructor for prototype pattern
        public Door(Door doorToClone)
        {
            this.Room1 = doorToClone.Room1;
            this.Room2 = doorToClone.Room2;
            this.IsOpen = doorToClone.IsOpen;
        }

        public virtual void Initialize(Room room1, Room room2, bool isOpen = false)
        {
            this.Room1 = room1;
            this.Room2 = room2;
            this.IsOpen = isOpen;
        }

        public virtual Door Clone()
        {
            return new Door(this);
        }
    }
}