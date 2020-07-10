using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenkiloListaHarjoitus
{
    class Program
    {
        //Tee ohjelma, jossa pyydetään käyttäjältä nimiä, jotka tallennetaan listalle. Sitten käyttäjältä kysytään, haluaako hän tulostaa
        //listalle tallennetut nimet nousevassa vai laskevassa järjestyksessä ja nimet tulostetaan sen mukaan konsolille.
        static void Main(string[] args)
        {
            List<string> HenkiloLista = new List<string>(); //luodaan uusi string-tyyppinen lista
            string nimi = " "; //muuttujalle annetaan lähtöarvoksi tyhjä, jotta silmukka alkaa pyörimään
            int laskuri = 0;

            while (nimi.Length > 0) //silmukkaa pyöritetään niin kauan, kuin string nimi-muuttujan merkkien määrä eli pituus on yli 0 (enter lopettaa silmukan)
            {
                Console.Write("Anna nimi: ");
                nimi = Console.ReadLine();
                if (nimi != "") //jos nimi ei ole pelkkä enter. Jos painetaan vaan enteriä, while-silmukan ehto ei ole voimassa ja silmukka päättyy.
                {
                    HenkiloLista.Add(nimi); //Lisätään nimi listalle lista.Add-metodilla
                }
            }

            Console.WriteLine("Haluatko tulostaa listan nousevassa vai laskevassa järjestyksessä? N=Nouseva/L=Laskeva");
            switch (Console.ReadLine().ToUpper()) //tutkitaan käyttäjän syöttämää kirjainta isoksi muutettuna
            {
                case "N": //jos se on N
                    HenkiloLista.Sort(); //lajitellaan lista nousevaan järjestykseen
                    break;

                case "L": //jos se on L
                    HenkiloLista.Sort(); //lajitellaan lista ensin nousevaan järjestykseen
                    HenkiloLista.Reverse(); //ja sitten käännetään järjestys laskevaan
                    break;

                default:
                    Console.WriteLine("Virheellinen valinta!"); //muussa tapauksessa tulostetaan konsolille "Virheellinen valinta!" eikä lajitella listaa
                    break;
            }

            for (int i = 0; i < HenkiloLista.Count; i++) //käydään läpi listaa niin kauan, kun laskurimuuttuja i on pienempi kuin listan alkioiden määrä
            {
                Console.WriteLine("Listan alkio " + i + " on " + HenkiloLista[i]); //tulostetaan listan alkiot
                laskuri = i + 1; //kasvatetaan laskuri-muuttujan arvoa
            }

            Console.WriteLine("Syötit {0} nimeä.", laskuri.ToString());
            Console.ReadLine();
            Console.WriteLine("Paina enter lopettaaksesi");
            Console.ReadLine();
        }
    }
}
