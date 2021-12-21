using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static bool TekMi(int sayi)
        {
            return sayi % 2 == 1;
        }
        static void Main(string[] args)
        {
            //Soru2:Tek sayıları bulunuz.

            List<int> sayilar = new List<int> { 34, 45, 1, 4, 7, 90, 15 };


            foreach (var sayi in sayilar)
            {
                if (sayi % 2 == 1)
                    Console.Write(sayi + " ");
            }
            Console.WriteLine();


            //1. Yöntem: Temsilciye metod bağla.

            Predicate<int> temsilci = new Predicate<int>(TekMi);
            foreach (var sayi in sayilar.FindAll(temsilci))
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();


            //2. Yöntem:Predicate temsilcisi tanımlamadan 

            foreach (var sayi in sayilar.FindAll(TekMi))
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();


            //3. Yöntem:Anonim metod ile...

            foreach (var sayi in sayilar.FindAll(delegate (int s) { return s % 2 == 1; }))
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();


            //4. Yöntem:Lamda Expression ile "=>"

            foreach (var sayi in sayilar.FindAll(s => s % 2 == 1))
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();

        }
    }
}
