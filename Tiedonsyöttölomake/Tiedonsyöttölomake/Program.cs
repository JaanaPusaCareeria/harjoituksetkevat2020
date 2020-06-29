using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiedonsyöttölomake
{
    class Program
    {
        static void Main(string[] args)
        {
            string etunimi, sukunimi, osoite, postinumero, postitoimipaikka, puhelinnumero, sahkoposti;

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

            Console.WriteLine("Tiedot ovat: " + "\r\n" + etunimi + " " + sukunimi + "\r\n" + osoite + "\r\n" + postinumero + " " + postitoimipaikka
                + "\r\n" + puhelinnumero + "\r\n" + sahkoposti);
            Console.ReadLine();
        }
    }
}
