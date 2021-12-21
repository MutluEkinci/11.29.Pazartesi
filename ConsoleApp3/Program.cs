using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public delegate void Temsilci();
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Anonim Metodlar:Uzun yıllar,c#'ta bir metod içerisinde metod tanımlanması yapılamazdı.Bunun tek bir yolu vardı,o da anonim metod yazmaktı. Artık bir metod içerisinde,lokal metod tanımlanabilir ve kullanılabilinir.
            */
            Temsilci t = delegate ()
            {
                Console.WriteLine("Anonim Metod...");
            };
            t += delegate ()
            { 
                Console.WriteLine("Metod 2...."); 
            };

            t();


        }
    }
}
