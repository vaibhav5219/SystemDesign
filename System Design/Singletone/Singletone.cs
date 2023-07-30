using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public sealed class Singletone
    {
        public static int counter = 0;
        public static Object obj = new Object();
        private static Singletone instance = null;
        public static Singletone GetSingletone   // It's a Property
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        //It will also work
                        if (counter == 0)
                            instance = new Singletone();  //Only one instance of singleton will created here also

                        if (instance == null)
                            instance = new Singletone();  //Only one instance of singleton will created here also
                    }
                }
                return instance;
            }
        }
        private Singletone()
        {
            ++counter;
            Console.WriteLine("counter in constructor " + counter);
        }
        public void printDetails(string mssg)
        {
            Console.WriteLine(mssg + " counter=" + counter);
        }
    }
}
