using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Say()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Yaz()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("AAA");
            }
        }
        static void Main(string[] args)
        {
            //single-Thread
            //Say();
            //Yaz();

            //Multi-Thread
            //Thread t1 = new Thread(Say);
            ThreadStart ts1 = new ThreadStart(Say);
            Thread t1 = new Thread(ts1);
            Thread t2 = new Thread(Yaz);

            t1.Priority = ThreadPriority.Highest; //öncelik yüksek
            t2.Priority = ThreadPriority.Lowest;
            t1.Start();
            t2.Start();

        }
    }
}
