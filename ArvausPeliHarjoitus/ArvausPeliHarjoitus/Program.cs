using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvausPeliHarjoitus
{
    class Program
    {

       //Luo ohjelma, joka hakee random-luvun 1-100. Kun ohjelman käynnistää, se arvuuttaa käyttäjältä mikä luku on kyseessä.
       //Mikäli käyttäjä arvaa liian suuren luvun, ohjelma sanoo "luku on pienempi kuin arvaus" ja mikäli käyttäjä arvaa liian pienen luvun, ohjelma
       //sanoo "luku on suurempi kuin arvaus". Arvaukset tallennetaan listalle. Lopuksi, kun arvaus osuu oikeaan, käyttäjää onnitellaan ja kerrotaan montako arvausta 
       //tarvittiin sekä tulostetaan listalla olevat arvaukset.
        static void Main(string[] args)
        {
            string arvaus;
            int arvausLuku, rluku;
            Random luku = new Random();
            rluku = luku.Next(1, 101);
            List<int> arvausLista = new List<int>();
            

        }
    }
}
