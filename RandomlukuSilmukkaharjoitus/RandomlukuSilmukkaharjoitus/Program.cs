using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomlukuSilmukkaharjoitus
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int rluku = random.Next(1, 3001);
            Random newrandom = new Random();
            int uusirluku = newrandom.Next(1, 3001);
            int i = 0;

            while (rluku != uusirluku)
            {
                uusirluku = newrandom.Next(1, 3001);
                Console.WriteLine("Kierroksella {0} luku oli {1}", (i + 1).ToString(), uusirluku.ToString());
                i++;
            }

            Console.WriteLine("Ensimmäinen luku oli {0} ja toinen {1}", rluku.ToString(), uusirluku.ToString());
            Console.ReadLine();
        }
    }
}
