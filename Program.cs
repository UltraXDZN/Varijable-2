using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sto = 100;
            int tisucu = -1000;
            char slovo = 'a';
            string istina = "\"true\"";
            float prviBroj = 3.123f;
            double drugiBroj = 3.123456789;
            bool istinaB = true;

            Console.WriteLine($"{sto}, {tisucu}, {slovo}, {prviBroj}, {drugiBroj}, {istinaB}, {istina}");
            Console.ReadKey();
        }
    }
}
