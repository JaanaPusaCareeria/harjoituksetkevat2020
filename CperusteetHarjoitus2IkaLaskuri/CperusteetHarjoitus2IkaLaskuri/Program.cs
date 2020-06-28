using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CperusteetHarjoitus2IkaLaskuri
{

    //Tehdään laskuri, joka laskee eletyn ajanhetken ja käyttäjän syöttämän ajan erotuksen.
    //Laskuri antaa sukupuolen ja annetun syntymäpäivän perusteella eliniän ennusteen.
    class Program
    {
        static void Main(string[] args)
        {
            Double aikaJaljella = 0; //Double-tyyppisessä muuttujassa on desimaalit mukana
            int elinIanOdote = 0;
            string alkuAika = "", sp="", vuodetKuukaudetPaivat = "";
            DateTime syntymaAikaDT, elinianOdotusDT; //tähän muuttujaan tallennetaan käyttäjän syöttämä aika
            DateTime tanaan = DateTime.Today; //tähän muuttujaan annetaan arvoksi kuluva ajanhetki. DateTime.Now sisältää kellonajan, DateTime.Today:ssä olisi vain päivämäärä
            string formaatti = "dd.MM.yyyy"; //luodaan string-apumuuttuja -formaatti, jossa kerrotaan, missä muodossa päivämäärätieto tulee käyttäjältä.
            CultureInfo kulttuuri = CultureInfo.InvariantCulture; //luodaan CultureInfo

            Console.WriteLine("Kerro sukupuoli, M=Mies/N=Nainen");
            sp = Console.ReadLine().ToUpper();
            switch (sp) //mitä tutkitaan
            {
                case "M": //jos käyttäjä on syöttänyt M. Pitää olla lainausmerkit, koska on string eikä char.
                    elinIanOdote = 78; //int-muuttuja elinIanOdote on 78
                    break;

                case "N": //jos käyttäjä on syöttänyt N
                    elinIanOdote = 84;
                    break;
                default: //jos ei ole mikään yllä olevista
                    Console.WriteLine("Virheellinen valinta!");
                    elinIanOdote = 0; //ei välttämätön, koska lähtöarvoksi on syötetty jo nolla.
                    break; 
            }

            //Pyydetään käyttäjää syöttämään syntymäaika
            Console.WriteLine("Anna syntymäaika muodossa PP.KK.VVVV");
            alkuAika = Console.ReadLine(); //sijoitetaan string-muuttuja syntymaAikaan käyttäjän syöttämä syntymäaika. HUOM! Se on string-muodossa, kuten käyttäjän syöte aina.
            //Muutetaan yllä saatu string-tyyppinen tieto päivämääräksi:
            //Lisätään try-catch -käsittely
            try //try-catchia käytetään virheen käsittelyyn
            {
                //tätä ohjelma yrittää tehdä
                syntymaAikaDT = DateTime.ParseExact(alkuAika, formaatti, kulttuuri); //Muunnetaan käyttäjän syöttämä päivämäärä oikeaan muotoon. ParseExact tarvitsee useamman parametrin, ensin muunnettava string-muuttuja, sitten formaatti, missä tieto tulee ja sitten CultureInfo
                elinianOdotusDT = syntymaAikaDT.AddYears(elinIanOdote); //lisätään syntymäaikaan eliniän odote AddYears-metodilla, jolle annetaan parametriksi int elinIanOdote
                //Lasketaan päivämäärien erotus. Huom: molempien muuttujien oltava DateTime-tyyppisiä jotta laskenta voidaan tehdä
                aikaJaljella = elinianOdotusDT.Subtract(tanaan).TotalDays; //Vähennetään elinianOdotusDT-muuttujasta tänään eli DateTime.Now -arvo.
                DateTime paivat = new DateTime(new TimeSpan((int)aikaJaljella+1, 0, 0, 0).Ticks); //luodaan DateTime-olio, joka on samalla Timespan-olio jolle annetaan parametriksi int-muotoon castattu aikaJaljella-double.
                vuodetKuukaudetPaivat = string.Format("{0} vuotta {1} kuukautta ja {2} päivää", paivat.Year-1, paivat.Month-1, paivat.Day-1); //tähän otetaan parametriksi paivat, koska sinne sijoitettiin TimeSpaniin aikaJaljella
            }
            catch (Exception ee) //Muodostettu exceptionista oma objekti. Jos ohjelma menee virheeseen, tapahtuu näin:
            {
                Console.WriteLine("Ohjelma ei osannut laskea päivämääräerotusta. Tarkista pvm-formaatti!"); //eli tulee tämä itse muotoiltu virheilmoitus
                Console.WriteLine(ee.Message); //Tulostetaan konsolille Exceptionin sisältämä message
                aikaJaljella = 0;
            }
            Console.WriteLine("Odotettua elinaikaa jäljellä " + vuodetKuukaudetPaivat + ".");
            Console.ReadLine();
        }
    }
}
