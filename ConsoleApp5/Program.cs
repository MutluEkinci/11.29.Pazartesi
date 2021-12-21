using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    

    class Program
    {
        public delegate int Temsilci(int s);
        static int Kare(int s)
        {
            return s * s;
        }
        static int Kup(int s)
        {
            return s * s * s;
        }
        static int IkiyeBol(int s)
        {
            return s / 2;
        }
        static void Main(string[] args)
        {
            Temsilci t = new Temsilci(Kare);
            t += Kup;
            t += IkiyeBol;

            Console.WriteLine(t(2));//returnle değer döndürdüğümüz için en son metodu yakaladı sadece.


        }
    }
}
