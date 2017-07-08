using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softchape
{
    public class Singleton
    {
        private static Singleton instance = null;
        private static int lvl { get; set; }

        private Singleton() { }

        public static Singleton getInstace()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
}
