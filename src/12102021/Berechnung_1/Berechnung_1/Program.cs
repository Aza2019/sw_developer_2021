using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berechnung_1
{
    class Program
    {
        static void Main()
        {
            int laenge = 3;
            int breite = 5;
            int umfang = 0;

            //berechnung des umfanges
            umfang = (laenge + breite) * 2;

            //Ausgabe Der Ergebnisse
            Console.WriteLine("Der umfang beträgt: " + umfang);

        }
    }
}
