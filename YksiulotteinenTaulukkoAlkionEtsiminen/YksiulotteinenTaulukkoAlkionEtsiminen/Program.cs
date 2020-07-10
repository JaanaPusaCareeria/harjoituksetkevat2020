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
        static void Main(string[] args)
        {
            string arvaus = "";
            Boolean jatka = true;
            int arvausLuku = 0;
            int[] taulukko1 = new int[] { 2000, 1, 3, 5, 16, 77, 101, 44, 1324, 3234 }; //luodaan taulukko ja annetaan sille alkiot

            Console.Write("Anna luku: "); //kysytään käyttäjältä luku
            arvaus = Console.ReadLine(); //tallennetaan luku arvaus-muuttujaan
            arvausLuku = int.Parse(arvaus);

            for (int i = 0; i < taulukko1.Length; i++)
            {
                if (arvausLuku == taulukko1[i])
                {
                    Console.WriteLine("Onneksi olkoon, luku {0} vastaa taulukon alkiota {1}!", arvausLuku.ToString(), i.ToString());
                } else
                {
                    Console.WriteLine("Valitettavasti lukua ei löytynyt");
                }
            }

            Console.ReadLine();
        }
    }
}
