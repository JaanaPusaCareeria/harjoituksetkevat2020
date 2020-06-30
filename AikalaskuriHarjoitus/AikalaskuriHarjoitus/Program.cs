using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikalaskuriHarjoitus
{
    class Program
    {
        //Tee konsolisovellus, joka kysyy käyttäjältä kaksi päivämäärää kellonaikoineen ja laskee niiden erotuksen minuuteissa.
        //Tulos näytetään konsolilla ja rutiini laitetaan silmukan sisään, jotta käyttäjän on helppo syöttää uudet arvot ja laskea uusi erotus.
        static void Main(string[] args)
        {
            string paiva1, paiva2;
            DateTime paivienErotusDT;
            Double paivienErotus = 0;
            Boolean jatka = true;

            while (jatka = true)
            {
                Console.WriteLine("Haluatko suorittaa laskennan uudelleen? K=Kyllä/E=Ei");
                if (Console.ReadLine().ToUpper() == "K")
                {
                    jatka = true;
                    Console.WriteLine("Anna päivämäärä nro 1");
                    paiva1 = Console.ReadLine();
                    DateTime paiva1DT = DateTime.Parse(paiva1);

                    Console.WriteLine("Anna toinen päivämäärä");
                    paiva2 = Console.ReadLine();
                    DateTime paiva2DT = DateTime.Parse(paiva2);

                    paivienErotus = paiva1DT.Subtract(paiva2DT).TotalMinutes;

                    Console.WriteLine("Päivämäärien erotus on {0} minuuttia.", paivienErotus.ToString());

                    Console.ReadLine();

                } else
                {
                    jatka = false;
                }
            }



        }
    }
}
