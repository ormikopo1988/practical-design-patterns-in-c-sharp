using DesignPatternsGangOfFour.Creational.Common;

namespace DesignPatternsGangOfFour.Creational.FactoryMethod
{
    public class EnchantedMazeGame : MazeGame
    {
        public override Door MakeDoor(Room room1, Room room2)
        {
            return new SpellNeedingDoor(room1, room2);
        }

        public override Room MakeRoom(int roomNumber)
        {
            return new EnchantedRoom(roomNumber, CastSpell());
        }

        protected Spell CastSpell()
        {
            return new Spell();
        }
    }
}