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
        //Muutettu laskenta-rutiini omaksi alirutiinikseen
        //Lisätty while-silmukka ja sinne laskennan kutsu sekä try-catch virheen käsittely laskentarutiiniin
        //Päivämääräformaatti? 
        static void Main(string[] args)
        {
            Laskenta(); //kutsuu laskenta-alirutiinia, joka käydään läpi kerran ennen siirtymistä while-silmukkaan
            Boolean jatka = true; //boolean-muuttuja jatka arvo asetetaan tässä trueksi

            while (jatka == true) //while-silmukka pyörii, niin kauan kun jatka-muuttujan arvo on true
            {
                Console.WriteLine("Haluatko suorittaa laskennan uudelleen? K=Kylläl/E=Ei"); //kysytään käyttäjältä, haluaako hän jatkaa
                if (Console.ReadLine().ToUpper() == "K") //jos käyttäjän syöttämä tieto konsolilta luettuna on isoksi muutettuna "K"
                {
                    Laskenta(); //kutsutaan taas Laskenta-alirutiinia
                    jatka = true; //ja asetetaan jatka-muuttujan arvoksi taas true
                } else //jos käyttäjän syöttämä arvo on jotakin muuta kuin "K"
                {
                    jatka = false; //asetetaan jatka-muuttujan arvoksi false, silmukka päättyy ja ohjelman suoritus päättyy
                } 
            }
        }

        private static void Laskenta()
        {
            string paiva1, paiva2;
            Double paivienErotus = 0;

            Console.WriteLine("Anna ensimmäinen päivämäärä muodossa dd.MM.yyyy"); //kysytään käyttäjältä päivämäärä kellonaikoineen
            paiva1 = Console.ReadLine(); //asetetaan konsolilta luettu arvo paiva1 muuttujaan
            try
            {
                DateTime paiva1DT = DateTime.Parse(paiva1); //muutetaan konsolilta saatu tieto DateTime.Parsella DateTime-tyyppiseksi paiva1DT-muuttujaksi
                Console.WriteLine("Anna toinen päivämäärä muodossa dd.MM.yyyy"); //perusasetus ei vaadi kellonajalle muuta formaattia, hyväksyy sen tälläisenään.
                paiva2 = Console.ReadLine();
                DateTime paiva2DT = DateTime.Parse(paiva2);
                paivienErotus = paiva1DT.Subtract(paiva2DT).TotalMinutes; //tallennetaan paiva1DT:n ja paiva2DT:n erotus double-tyyppiseen muuttujaan paivienErotus.
                Console.WriteLine("Päivämäärien erotus on {0} minuuttia.", paivienErotus.ToString()); //tulostetaan laskettu erotus konsolille
        }
            catch (Exception)
            {

                Console.WriteLine("Tarkista syöttämäsi arvo");
            }


}
    }
}
