using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singletone s1 = new Singletone();
            //s1.printDetails("heelo");

            //Singletone s2 = new Singletone();
            //s2.printDetails("heelo Brother");


            // Counter will not increment
            Parallel.Invoke(
                () => NewMethod1(),
                () => NewMethod()
            );
            Console.ReadLine();
        }

        private static void NewMethod1()
        {
            Singletone s3 = Singletone.GetSingletone;  // Only one instance of singleton will created
            //s3.printDetails("heelo");
        }

        private static void NewMethod()
        {
            Singletone s4 = Singletone.GetSingletone;  // Only one instance of singleton will created here also
            //s4.printDetails("heelo Brother");
            //Console.ReadLine();
        }
    }
}
