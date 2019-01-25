using DesignPatternsGangOfFour.Creational.Common;

namespace DesignPatternsGangOfFour.Creational.AbstractFactory
{
    public class EnchantedMazeFactory : MazeFactory
    {
        public EnchantedMazeFactory()
        {

        }

        public override Room MakeRoom(int roomNumber)
        {
            return new EnchantedRoom(roomNumber, CastSpell());
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            return new SpellNeedingDoor(room1, room2);
        }

        protected Spell CastSpell()
        {
            return new Spell();
        }
    }
}