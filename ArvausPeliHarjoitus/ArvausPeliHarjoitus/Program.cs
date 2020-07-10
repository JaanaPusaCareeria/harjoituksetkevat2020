﻿using System;
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
       //Välitallennus, saatu muuten toimimaan paitsi listalle tallennus
        static void Main(string[] args)
        {
            string arvaus;
            int arvausLuku, rluku;
            bool jatka = true; //asetetaan boolean jatka-muuttujan lähtöarvoksi true, jotta päästään while-silmukkaan
            Random luku = new Random(); //luodaan uusi random-muuttuja
            rluku = luku.Next(1, 101); //haetaan int rluku-muuttujalle seuraava random-arvo välilltä 1-100.
            List<int> arvausLista = new List<int>(); //luodaan uusi arvausLista-niminen lista-olio

            Console.WriteLine("Tervetuloa arvauspeliin!");

            while (jatka == true) //niin kauan kuin jatka-muuttujan arvo on true, silmukka pyörii
            {
                Console.WriteLine("Arvaa luku: "); //kysytään käyttäjältä luku
                arvaus = Console.ReadLine(); //tallennetaan saatu tieto arvaus-muuttujaan
                try
                {
                    arvausLuku = int.Parse(arvaus); //tallennetaan arvausLuku-muuttujaan int.Parsen avulla arvaus-muuttujan arvo
                    //arvausLista.Add(arvausLuku); //lisätään arvausLuku arvausListalle alkioksi
                    Console.WriteLine(arvausLuku);
                    if (arvausLuku == rluku)
                    {
                        Console.WriteLine("Onneksi olkoon, arvasit oikein!");
                        jatka = false;
                        //for (int i = 0; i < arvausLista.Count; i++)
                        //{
                        //    Console.WriteLine("Arvaus numero {0} oli {1}", (i + 1).ToString(), arvausLuku.ToString()); ;
                        //}
                    } else if (arvausLuku > rluku)
                    {
                        Console.WriteLine("Arvauksesi oli suurempi kuin luku");
                    } else
                    {
                        Console.Write("Arvauksesi oli pienempi kuin luku");
                    }
                }
                catch (Exception) //jos arvaus-muuttujan arvoa ei voida muuttaa int.Parsella ts se ei ole numeerinen
                {
                    Console.WriteLine("Syöttämäsi tieto ei ollut numeerinen"); //tulostetaan konsolille tämä
                    //boolean-muuttujaan jatka ei kosketa tässä kohtaa, koska halutaan pysyä silmukassa
                }               
            }



            Console.ReadLine();
        }
    }
}
