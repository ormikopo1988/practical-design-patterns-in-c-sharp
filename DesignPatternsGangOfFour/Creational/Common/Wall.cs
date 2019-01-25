namespace DesignPatternsGangOfFour.Creational.Common
{
    public class Wall : MapSite
    {
        public Wall()
        {

        }

        public override void Enter()
        {

        }

        // Extra implementation for supporting the prototype pattern
        // Copy constructor for prototype pattern
        public Wall(Wall wallToClone)
        {

        }

        public virtual void Initialize()
        {

        }

        public virtual Wall Clone()
        {
            return new Wall(this);
        }
    }
}