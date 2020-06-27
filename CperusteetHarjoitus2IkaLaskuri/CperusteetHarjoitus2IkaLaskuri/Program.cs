using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CperusteetHarjoitus2IkaLaskuri
{

    //Tehdään laskuri, joka laskee eletyn ajanhetken ja käyttäjän syöttämän syntymäajan erotuksen.
    class Program
    {
        static void Main(string[] args)
        {
            Double aikaEro = 0; //Double-tyyppisessä muuttujassa on desimaalit mukana
            string syntymaAika = "";
            DateTime syntymaAikaDT; //tähän muuttujaan tallennetaan käyttäjän syöttämä syntymäaika
            DateTime tanaan = DateTime.Today; //tähän muuttujaan annetaan arvoksi kuluva ajanhetki

            //Kysytään käyttäjältä syntymäaikaa
            Console.WriteLine("Anna syntymäaikasi muodossa PP.KK.VVVV");
            syntymaAika = Console.ReadLine(); //sijoitetaan string-muuttuja syntymaAikaan käyttäjän syöttämä syntymäaika. HUOM! Se on string-muodossa, kuten käyttäjän syöte aina.
            //Muutetaan yllä saatu string-tyyppinen tieto päivämääräksi:
            syntymaAikaDT = DateTime.Parse(syntymaAika); //jos käyttäjän syöttämä tieto on oikeassa muodossa, tämä muuntaa sen päivämääräksi
            //Lasketaan päivämäärien erotus. Huom: tanaan-muuttuja on DateTime-tyyppinen, joten toisenkin käytettävän muuttujan pitää olla DateTime eli käytetään syntymaAikaDT-muuttujaa, johon yllä muunnettiin käyttäjän syöttämä tieto
            aikaEro = tanaan.Subtract(syntymaAikaDT).Days; //tallennetaan aikaEro muuttujan arvoksi tanaan-muuttujan ja syntymaAikaDT-muuttujan erotus päivinä
            Console.WriteLine("Olet " + aikaEro.ToString() + " päivää vanha");
            Console.ReadLine();
        }
    }
}
