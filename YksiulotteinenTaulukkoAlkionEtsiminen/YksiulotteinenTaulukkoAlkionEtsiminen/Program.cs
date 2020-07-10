using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace YksiulotteinenTaulukkoAlkionEtsiminen
{
    class Program
    {
        //Luo ohjelma, jossa on yksiulotteinen taulukko, esim
        //int[] taulukko1 = new int[] {2000, 1, 3, 5, 16, 77, 101, 44, 1324, 3234}. Kysy käyttäjältä lukua Console.ReadLinella. Käy taulukko läpi silmukassa
        //Jos käyttäjän antama luku löytyy, anna onnitteluilmoitus. Jos ei löydy, anna ilmoitus "lukua ei löydy".
        //Muuten onnistui, mutta nyt konsoli tulostaa JOKA läpikäynnillä ilmoituksen..
        //Korjattu silmukan tulostus muistiinpanojen avulla
        //Lisätty oma silmukkakäsittely rutiinille
        static void Main(string[] args)
        {
            string arvaus = "";
            int arvausLuku = 0, laskuri = 0;
            bool löytyi, jatka = true; //luodaan boolean löytyi-muuttuja ilman alkuarvoa ja jatka-muuttuja alkuarvolla true(jotta päästään silmukkaan)
            int[] taulukko1 = new int[] { 2000, 1, 3, 5, 16, 77, 101, 44, 1324, 3234 }; //luodaan taulukko ja annetaan sille alkiot
            while (jatka == true) //niin kauan, kuin jatka-muuttujan arvo on true
            {
                Console.Write("Anna luku (X lopettaa): "); //kysytään käyttäjältä luku
                arvaus = Console.ReadLine(); //tallennetaan luku arvaus-muuttujaan
                if (arvaus.ToUpper() == "X") //jos arvaus muutettuna isoksi on X
                {
                    jatka = false; //jatka-muuttuja asetetaan falseksi
                    break;//poistutaan silmukasta ja lopetetaan ohjelma
                }
                löytyi = false; //löytyi-muuttuja asetetaan falseksi
                arvausLuku = int.Parse(arvaus); //muutetaan arvaus int-tyyppiseksi arvausLuku-muuttujaksi
                for (int i = 0; i < taulukko1.Length; i++) //käydään koko taulukko läpi
                {
                    if (arvausLuku == taulukko1[i]) //jos arvausLuku vastaa sen kierroksen taulukon alkiota
                    {
                        Console.WriteLine("Onneksi olkoon, luku {0} vastaa taulukon alkiota {1}!", arvausLuku.ToString(), i.ToString()); //tulostetaan konsolille onnittelu
                        löytyi = true; //löytyi muuttuja asetetaan falseksi
                    }
                    laskuri = i + 1; //kasvatetaan laskuri-muuttujan arvoa yhdellä
                }
                if (löytyi == false) Console.WriteLine("Kävin läpi {0} lukua, mutta en löytänyt lukua {1}!", laskuri.ToString(), arvausLuku.ToString());//jos löytyi-muuttujan arvo on false eli arvausLuku ei vastannut muuttujaa, tulostetaan konsolille tämä
            }
            Console.ReadLine();
        }
    }
}
