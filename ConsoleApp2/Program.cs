using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate void Temsilci();
    class Program
    {
        static void Yaz()
        {
            Console.WriteLine("Yaz()");
        }
        static void Merhaba()
        {
            Console.WriteLine("Merhaba()");
        }
        static void Gunaydin(string str)
        {
            Console.WriteLine("Gunaydin()");
        }
        static string Hello()
        {
            return "Hello()";
        }
        static void Main(string[] args)
        {
            /*
            Delegates(Temsilciler)
            -Metod Taşır(return type + imzası aynı olan metodları taşır)
            En fazla görünen delegates
            1-Function(func)(bir metod geriye değer döndürüyorsa yani return type'ı varsa)
            2-Action(return type yoksa yani void'se)
            -Delegeler aynı zamanda koleksiyondur.Bir çok metodu tutabilir.
            -Birden fazla metod tutanlara multicast delege denir.
            -Metod isminin bir önemi yoktur.İhtiyacımız olduğunda delegeyi tetikleriz ve metod çalışır.
            -Void olmak zorunda değildir ama çoğu yerde void kullanılır. Çünkü birden fazla delegeyi peşpeşe bağlarsanız ve return type'ı farklı olursa (int-string-double gibi) en son değer yakalanır sadece(double).
            ??????"void Btn-Click(object sender EventArgs e)"??????
            */
            Temsilci t = new Temsilci(Yaz);

            t += Yaz; //delegelere bu şekilde kolayca metod ekleyebiliriz.
            t += Merhaba;//multicast delege çok kullanılmaz.
            t += Merhaba;
            t -= Merhaba;
            t();
            Console.WriteLine("------------");
            foreach (Delegate del in t.GetInvocationList())
            {
                Console.WriteLine();
                if (del.Method.Name == "Yaz")
                    del.DynamicInvoke();
            }


        }
    }
}
