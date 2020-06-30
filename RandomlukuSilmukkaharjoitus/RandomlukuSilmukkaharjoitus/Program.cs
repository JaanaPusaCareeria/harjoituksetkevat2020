using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomlukuSilmukkaharjoitus
{
    class Program
    {
        //Tee sovellus, joka:
        //asettaa satunnaisluvun (1,3001) muuttujaan
        //toimii silmukassa
        //silmukka etsii tätä satunnaislukua
        //silmukassa lasketaan, montako kierrosta piti mennä, ennen kuin satunnaisluku löytyi
        //silmukka pysähtyy, kun luku on löydetty ja ohjelma kertoo montako kierrosta meni
        //EI TOIMI VIELÄ OIKEIN, TULEE AINA SAMAT LUVUT
        static void Main(string[] args)
        {
             
            Random random = new Random(); //luodaan random-olio
            int rluku = random.Next(1, 3001); //annetaan int rluku-muuttujalle arvoksi seuraava random-olion arvo väliltä 1 - 3001
            int i = 0, uusirluku = 0;

            while (rluku != uusirluku) 
            {
                Random newrandom = new Random();
                uusirluku = newrandom.Next(1, 3001);
                Console.WriteLine("Kierroksella {0} luku oli {1}", (i + 1).ToString(), uusirluku.ToString());
                i++;
            }

            Console.WriteLine("Ensimmäinen luku oli {0} ja toinen {1}", rluku.ToString(), uusirluku.ToString());
            Console.ReadLine();
        }
    }
}
