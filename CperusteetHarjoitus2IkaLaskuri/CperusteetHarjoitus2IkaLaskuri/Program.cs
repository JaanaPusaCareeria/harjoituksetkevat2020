using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CperusteetHarjoitus2IkaLaskuri
{

    //Tehdään laskuri, joka laskee eletyn ajanhetken ja käyttäjän syöttämän ajan erotuksen.
    class Program
    {
        static void Main(string[] args)
        {
            Double aikaEro = 0; //Double-tyyppisessä muuttujassa on desimaalit mukana
            string alkuAika = "";
            DateTime syntymaAikaDT; //tähän muuttujaan tallennetaan käyttäjän syöttämä aika
            DateTime tanaan = DateTime.Now; //tähän muuttujaan annetaan arvoksi kuluva ajanhetki. DateTime.Now sisältää kellonajan, DateTime.Today:ssä olisi vain päivämäärä
            string formaatti = "yyyy.MM.dd HH:mm:sss"; //luodaan string-apumuuttuja -formaatti, jossa kerrotaan, missä muodossa päivämäärätieto tulee käyttäjältä.
            CultureInfo kulttuuri = CultureInfo.InvariantCulture; //luodaan CultureInfo

            //Pyydetään käyttäjää syöttämään aika
            Console.WriteLine("Anna alkuaika muodossa VVVV.KK.PP HH:mm:ss");
            alkuAika = Console.ReadLine(); //sijoitetaan string-muuttuja syntymaAikaan käyttäjän syöttämä syntymäaika. HUOM! Se on string-muodossa, kuten käyttäjän syöte aina.
            //Muutetaan yllä saatu string-tyyppinen tieto päivämääräksi:
            syntymaAikaDT = DateTime.ParseExact(alkuAika, formaatti, kulttuuri); //Muunnetaan käyttäjän syöttämä päivämäärä oikeaan muotoon. ParseExact tarvitsee useamman parametrin, ensin muunnettava string-muuttuja, sitten formaatti, missä tieto tulee ja sitten CultureInfo
            //Lasketaan päivämäärien erotus. Huom: tanaan-muuttuja on DateTime-tyyppinen, joten toisenkin käytettävän muuttujan pitää olla DateTime eli käytetään syntymaAikaDT-muuttujaa, johon yllä muunnettiin käyttäjän syöttämä tieto
            aikaEro = tanaan.Subtract(syntymaAikaDT).TotalHours; //tallennetaan aikaEro muuttujan arvoksi tanaan-muuttujan ja syntymaAikaDT-muuttujan erotus
            Console.WriteLine("Päivämäärien/aikojen erotus on " + aikaEro.ToString()); //tulostetaan konsolille laskennan tulos aikaEro muutettuna string-muotoon.
            Console.ReadLine();
        }
    }
}
