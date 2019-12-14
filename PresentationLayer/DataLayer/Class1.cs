using System;

namespace DataLayer
{
    public class Singleton
    {
        private static Singleton instance;
        
        private Singleton() { }
       

        public static Singleton Instance
        /* It returns an object that represents the only instance of this class*/
        {
            get
            {
                if (instance == null)

                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
