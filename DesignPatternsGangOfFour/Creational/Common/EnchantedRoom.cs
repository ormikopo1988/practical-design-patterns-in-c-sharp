namespace DesignPatternsGangOfFour.Creational.Common
{
    public class EnchantedRoom : Room
    {
        private int roomNumber;
        private Spell spell;

        public EnchantedRoom(int roomNumber, Spell spell)
            : base(roomNumber)
        {
            this.roomNumber = roomNumber;
            this.spell = spell;
        }
    }
}