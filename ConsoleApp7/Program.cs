using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public delegate void OlayYakalayıcı();
    class Buton
    {
        public event OlayYakalayıcı Tıkla;
        public void Tetikle()
        {
            if (Tıkla != null)
                Tıkla();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Events(Olaylar)
            Buton btn = new Buton();
            btn.Tıkla += Btn_Tikla;

            btn.Tetikle();
        }

        private static void Btn_Tikla()
        {
            Console.WriteLine("Butona Tıklandı...");
        }
    }
}
