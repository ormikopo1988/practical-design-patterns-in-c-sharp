namespace DesignPatternsGangOfFour.Behavioral.Iterator
{
    public class List<TElem>
        where TElem : class
    {
        private TElem[] array;

        public List(long size)
        {
            this.array = new TElem[size];
        }

        public int Count()
        {
            int count = 0;

            for(int i = 0; i < this.array.Length; i++)
            {
                if(this.array[i] != null)
                {
                    count++;
                }
            }

            return count;
        }

        public TElem Get(int index)
        {
            for (var i = 0; i < this.array.Length; i++)
            {
                if (i == index)
                {
                    return this.array[index];
                }
            }

            return default(TElem);
        }
    }
}