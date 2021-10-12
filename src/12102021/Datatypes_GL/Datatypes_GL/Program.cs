using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_GL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datentyp Variablenbezeichnung
             //Deklaration
              int eineZahl;

            //Initialisierung
            eineZahl = 5;

        Console.WriteLine(eineZahl);
            Console.WriteLine("int-Min: " + int.MinValue);
            Console.WriteLine("int-Max: " + int.MaxValue);

            //Datentyp Variablenbezeichnung
            //Deklaration & Initialisierung
            string name= "\"Gandalf\" /(%&/3216\\54321";
            name = @"C:\myCode\Repos\sw_developer_2021\src";

            Console.WriteLine(name);
            Console.WriteLine("Anzahl Der Zeichen:" + name.Length);

            double gewicht = 0.45;

            Console.WriteLine("Das gewicht ist: " + gewicht + "kg");

            decimal meinBudget = 455.3215m;
            Console.WriteLine(meinBudget);

            bool isPoweron = true;
        }
    }
}
