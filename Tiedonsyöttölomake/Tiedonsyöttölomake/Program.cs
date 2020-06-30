using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiedonsyöttölomake
{
    class Program
    {
        //Tee sovellus, joka kysyy käyttäjältä etunimen, sukunimen, osoitteen, postinumeron, postitoimipaikan, puhelinnumeron ja sähköpostiosoitteen. Tiedot tallennetaan
        //Console.ReadLinella kukin omaan muuttujaansa. Luvun jälkeen tiedot tulostetaan konsolille. Lopuksi selvitetään, montako merkkiä käyttäjä oli yhteensä syöttänyt 
        //eri kenttiin. Blankoja ei lasketa. 
        static void Main(string[] args)
        {
            string etunimi, sukunimi, osoite, postinumero, postitoimipaikka, puhelinnumero, sahkoposti;
            //Kysytään tiedot käyttäjältä ja tallennetaan muuttujiin
            Console.WriteLine("Anna etunimi");
            etunimi = Console.ReadLine();
            Console.WriteLine("Anna sukunimi");
            sukunimi = Console.ReadLine();
            Console.WriteLine("Anna osoite");
            osoite = Console.ReadLine();
            Console.WriteLine("Anna postinumero");
            postinumero = Console.ReadLine();
            Console.WriteLine("Anna postitoimipaikka");
            postitoimipaikka = Console.ReadLine();
            Console.WriteLine("Anna puhelinnumero");
            puhelinnumero = Console.ReadLine();
            Console.WriteLine("Anna sahkoposti");
            sahkoposti = Console.ReadLine();
            //Tulostetaan tiedot konsolille
            Console.WriteLine("Tiedot ovat: " + "\r\n" + etunimi + " " + sukunimi + "\r\n" + osoite + "\r\n" + postinumero + " " + postitoimipaikka
                + "\r\n" + puhelinnumero + "\r\n" + sahkoposti);

            //Lasketaan kenttiin syötettyjen merkkien yhteissumma
            etunimi = etunimi.Replace(" ", ""); //korvataan etunimi-muuttujan arvossa tyhjä mahdollinen blanko " " pois
            int etunimilkm = etunimi.Length; //tallennetaan muuttujan merkkien lukumäärä etunimilkm-muuttujaan
            sukunimi = sukunimi.Replace(" ", "");
            int sukunimilkm = sukunimi.Length;
            osoite = osoite.Replace(" ", "");
            int osoitelkm = osoite.Length;
            postinumero = postinumero.Replace(" ", "");
            int postinumerolkm = postinumero.Length;
            postitoimipaikka = postitoimipaikka.Replace(" ", "");
            int postitoimipaikkalkm = postitoimipaikka.Length;
            puhelinnumero = puhelinnumero.Replace(" ", "");
            int puhelinnumerolkm = puhelinnumero.Length;
            sahkoposti = sahkoposti.Replace(" ", "");
            int sahkopostilkm = sahkoposti.Length;
            
            //Lasketaan muuttujien merkkimäärä yhteen uuteen muuttujaan
            int merkkiensumma = etunimilkm + sukunimilkm + osoitelkm + postinumerolkm + postitoimipaikkalkm + puhelinnumerolkm + sahkopostilkm;

            Console.WriteLine("Syöttämiesi merkkien summa on {0}", merkkiensumma.ToString()); //Tulostetaan konsolille yllä laskettu summa
            Console.ReadLine();
        }
    }
}
