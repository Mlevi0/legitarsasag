using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace utazasokgenerator
{
    //dao
    class Program
    {

        static void Main(string[] args)
        {
            List<string> legitarsasagok = new List<string>()
            { "Aegean", "Aer Lingus", "Airbaltic", "Air China","Air France","Austrian Airlines","British Airways","Brussels Airlines","China Eastern Airlines","Easyjet","Egyptair","El-Al","Emirates","Eurowing","Finnair","Flydubai","Iberia","Jet2.com","KLM","Lot Polish Airlines", "Lufthansa","Norwegian","Pegasus","Qatar Airways", "Ryanair", "Shanghai Airlines","Sunexpress","Swiss","Tarom","Turkish Airlines","Wizz Air"};
            List<string> varosok = new List<string>() 
            { "Oslo", "Stockholm", "Helsinki", "Koppenhága", "Reykjavík", "London", "Dublin", "Párizs", "Brüsszel", "Amszterdam", "Luxembourg", "Lisszabon", "Madrid", "Róma", "Ljubljana", "Zágráb", "Belgrád", "Podgorica", "Szarajevó", "Skopje", "Pristina", "Tirana", "Szófia", "Athén", "Tallinn", "Riga", "Vilnius", "Bukarest", "Kisinyov", "Moszkva", "Kijev", "Minszk", "Berlin", "Bern", "Bécs", "Prága", "Varsó", "Pozsony", "Budapest", "Nicosia", "La Valetta", "Monaco", "San Marino", "Andorra la Vella", "Vaduz" };
            List<string> odavissza = new List<string>() { };
            StreamWriter sw = new StreamWriter("utazasok.txt");
            Random rnd = new Random();
            for (int i = 0; i < varosok.Count; i++)
            {
                odavissza.Add(varosok[rnd.Next(0, varosok.Count)]);
                var valtozo = varosok[rnd.Next(0, varosok.Count)];
                while (odavissza.Contains(valtozo))
                {
                    valtozo = varosok[rnd.Next(0, varosok.Count)];
                }
                odavissza.Add(valtozo);
                sw.WriteLine(legitarsasagok[rnd.Next(0, legitarsasagok.Count)] + ";" + odavissza[0] + ";" + odavissza[1] + ";" + rnd.Next(200, 15001) + ";" + rnd.Next(60, 1111) + ";" + rnd.Next(1, 16));
                odavissza.Clear();
            }
            sw.Close();
            StreamWriter sw2 = new StreamWriter("populacio.txt");
            for (int i = 0; i < varosok.Count; i++)
            {
                sw2.WriteLine(varosok[i] + ";" + rnd.Next(37000, 32000000));
            }
            sw2.Close();
        }
    }
}
