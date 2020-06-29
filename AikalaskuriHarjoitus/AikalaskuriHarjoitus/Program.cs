using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikalaskuriHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            string paiva1, paiva2;
            DateTime paivienErotusDT;

            Console.WriteLine("Anna päivämäärä nro 1");
            paiva1 = Console.ReadLine();
            DateTime paiva1DT = DateTime.Parse(paiva1);

            Console.WriteLine("Anna toinen päivämäärä");
            paiva2 = Console.ReadLine();
            DateTime paiva2DT = DateTime.Parse(paiva2);

            //paivienErotusDT = paiva1DT.Subtract(paiva2DT).TotalMinutes;

        }
    }
}
