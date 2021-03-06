﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CperusteetHarjoitus1henkiloTiedot
{
    //C#-perusteet, harjoitustehtävä 1
    //TEHTÄVÄNANTO: Tee ohjelma, joka kysyy käyttäjältä henkilötietoja (nimi, osoite, ikä jne) sekä sukupuolen ja tulostaa annetut tiedot konsolille.
    //Lisää sukupuolen tarkasteluun seuraava toiminto: jos käyttäjä syöttää sukupuolekseen mies, kysytään lopuksi "Mitä jäbä duunaa?" ja jos käyttäjä
    //syöttää sukupuolekseen nainen, kysytään "Mitä mimmi puuhaa?".

    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            string nimi, osoite, postinumero, postitoimipaikka, sukupuoli, puhelinnumero, sahkoposti, ikaluokka; //luodaan string-tyyppiset muuttujat
            int ika; //luodaan int-tyyppinen muuttuja
            DateTime tanaan = DateTime.Today; //luodaan DateTime-muuttuja. Today ei sisällä kellonaikaa, .Now sisältäisi

            Console.WriteLine("Henkilötietosovellus, harjoitustehtävä 1. Tänään on: " + tanaan.ToString("d", culture)); //CultureInfo-tieto annetaan parametrinä

            Console.Write("Kerro nimesi: "); //kysytään käyttäjältä tiedot
            nimi = Console.ReadLine(); //tallennetaan käyttäjän syöttämä tieto muuttujaan
            Console.Write("Kerro ikäsi: ");
            ika = int.Parse(Console.ReadLine()); //muunnetaan käyttäjän syöttämä tieto int-tyyppiseksi (syöte on aina teksti- eli string-tyyppiä) ja tallennetaan muuttujaan
            if (ika < 7)
            {
                ikaluokka = "Olet alle kouluikäinen.";
            } else if (ika < 18)
            {
                ikaluokka = "Olet alaikäinen";
            } else if (ika < 66)
            {
                ikaluokka = "Olet työikäinen";
            } else
            {
                ikaluokka = "Olet eläkkeellä";
            }
            Console.Write("Kerro osoitteesi: ");
            osoite = Console.ReadLine();
            Console.Write("Kerro postinumerosi: ");
            postinumero = Console.ReadLine();
            Console.Write("Kerro postitoimipaikkasi: ");
            postitoimipaikka = Console.ReadLine();
            Console.Write("Kerro sukupuolesi: ");
            sukupuoli = Console.ReadLine().ToLower();
            Console.Write("Kerro puhelinnumerosi: ");
            puhelinnumero = Console.ReadLine();
            Console.Write("Kerro sähköpostisi: ");
            sahkoposti = Console.ReadLine();

            string osoitetiedot = osoite + "\r\n" + postinumero + " " + postitoimipaikka; //luodaan string-muuttuja, johon yhdistetään osoitetiedot

            Console.WriteLine();
            Console.WriteLine("***************");
            Console.WriteLine("Hei " + nimi + "!" + " Olet " + ika.ToString() + "-vuotias " + sukupuoli + ". " + ikaluokka + ". " + "\r\n"
                + "Osoitetietosi ovat:" + "\r\n" + osoitetiedot
                + "\r\n" + puhelinnumero + "\r\n" + sahkoposti); //konkatenoidaan tallennetut tiedot tulosteeseen
            Console.WriteLine("***************");
            Console.WriteLine();
            if (sukupuoli.ToLower() == "nainen") //jos käyttäjän syöttämä tieto pieniksi kirjaimiksi muutettuna on "nainen"
            {
                Console.WriteLine("Mitä mimmi puuhaa?"); //kirjoitetaan "Mitä mimmi puuhaa?"
            }
            else if (sukupuoli.ToLower() == "n")
            {
                Console.WriteLine("Mitä mimmi puuhaa?");
            }
            else if (sukupuoli.ToLower() == "mies")
            {
                Console.WriteLine("Mitä jäbä duunaa?");
            }
            else if (sukupuoli.ToLower() == "m")
            {
                Console.WriteLine("Mitä jäbä duunaa?");
            }
            else //jos käyttäjän syöttämä tieto ei vastaa mitään yllä olevista
            {
                Console.WriteLine("En tunnistanut syöttämääsi tietoa");
            }
            Console.ReadLine();

        }
    }
}
