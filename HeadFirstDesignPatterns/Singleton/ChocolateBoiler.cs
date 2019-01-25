namespace HeadFirstDesignPatterns.Singleton
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        // 1st way of dealing with multithreading issues - No lazy initialization
        // Use it: If your application always creates and uses an instance of the Singleton or the overhead of
        // creation and runtime aspects of the Singleton are not onerous
        // private static ChocolateBoiler instance = new ChocolateBoiler();
        // public static ChocolateBoiler GetInstance() { return instance; }

        // 2nd way of dealing with multithreading issues - Double check locking
        // Use it: If performance is an issue in your use of the GetInstance() 
        // method then this method can drastically reduce the overhead.
        // Keyword volatile is used as a hint to the compiler that this data
        // member is accessed by multiple threads and ensures that they
        // handle the instance variable correctly when it is being initialized
        // to the ChocolateBoiler instance.
        private volatile static ChocolateBoiler instance = null;

        private static readonly object syncLock = new object();

        private ChocolateBoiler()
        {
            this.empty = true;
            this.boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (instance == null)
            {
                // Note that we use the lock the first time only
                lock(syncLock)
                {
                    if(instance == null)
                    {
                        instance = new ChocolateBoiler();
                    }
                }
            }

            return instance;
        }

        public void Fill()
        {
            if (this.IsEmpty())
            {
                this.empty = false;
                this.boiled = false;
                
                // fill the boiler with a milk/chocolate mixture
            }
        }

        public void Drain()
        {
            if (!this.IsEmpty() && this.IsBoiled())
            {
                // drain the boiled milk and chocolate

                this.empty = true;
            }
        }

        public void Boil()
        {
            if (!this.IsEmpty() && !this.IsBoiled())
            {
                // bring the contents to a boil

                this.boiled = true;
            }
        }

        public bool IsEmpty()
        {
            return this.empty;
        }

        public bool IsBoiled()
        {
            return this.boiled;
        }
    }
}