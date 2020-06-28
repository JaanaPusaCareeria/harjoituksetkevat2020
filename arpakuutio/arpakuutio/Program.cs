using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arpakuutio
{
    class Program
    {
        //Tehdään ohjelma, joka hakee randomluvun väliltä 1-3000
        static void Main(string[] args)
        {
            Boolean lopeta = false;
            Console.WriteLine("Tervetuloa random-generaattoriin!");
            while (lopeta != true) //niin kauan kuin lopeta ei ole true, jatketaan. Sitten kun joku vastaa jotain, jonka vuoksi lopeta = true, lopetetaan.
            {
                Console.WriteLine("Haetaan seuraavat randomluvut");
                randomLuvut(); //ohjelma kutsuu alirutiinia randomLuvut() -> siirtyy private static void randomLuvut -alirutiiniin
                Console.WriteLine("Haetaanko luvut uudelleen? K=Kyllä/E=Ei");
                if (Console.ReadLine().ToUpper() == "E") lopeta = true; //JOS konsolilta luettu käyttäjän syöttämä kirjain on isoksi muutettuna E, lopeta-boolean asetetaan trueksi jolloin silmukka päättyy (ei haeta enää uusia randomlukuja).
            }
        }

        private static void randomLuvut()
        {
            int rluku = 0;
            Random arpa = new Random(); //luodaan random-luokan olio
            int i = 0; //luodaan i-laskurimuuttuja
            //silmukka alkaa ja pyörii niin kauan kuin laskurimuuttuja on alle 100
            while (i < 100)
            {
                rluku = arpa.Next(1, 3000); //haetaan uusi randomluku
                Console.WriteLine("Silmukan kierroksella {1} randomluku on {0}", rluku.ToString(), (i + 1).ToString()); //tulostetaan randomluku
                i++; //kasvatetaan i:n arvoa yhdellä
            }
        }
    }
}
