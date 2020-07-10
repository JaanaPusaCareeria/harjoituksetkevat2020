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
        static void Main(string[] args)
        {
            string arvaus = "";
            int arvausLuku = 0, laskuri = 0;
            bool löytyi;
            int[] taulukko1 = new int[] { 2000, 1, 3, 5, 16, 77, 101, 44, 1324, 3234 }; //luodaan taulukko ja annetaan sille alkiot

            Console.Write("Anna luku: "); //kysytään käyttäjältä luku
            arvaus = Console.ReadLine(); //tallennetaan luku arvaus-muuttujaan

            if (!int.TryParse(arvaus, out arvausLuku) == true)
            {
                Console.WriteLine("Syöttämäsi tieto ei ollut numeerinen");
            }
            löytyi = false;

            for (int i = 0; i < taulukko1.Length; i++) 
            {
                if (arvausLuku == taulukko1[i])
                {
                    Console.WriteLine("Onneksi olkoon, luku {0} vastaa taulukon alkiota {1}!", arvausLuku.ToString(), i.ToString());
                    löytyi = true;
                }
                laskuri = i + 1;
            }

            if (löytyi == false) Console.WriteLine("Kävin läpi {0} lukua, mutta en löytänyt lukua {1}!", laskuri.ToString(), arvausLuku.ToString());
            Console.ReadLine();
        }
    }
}
