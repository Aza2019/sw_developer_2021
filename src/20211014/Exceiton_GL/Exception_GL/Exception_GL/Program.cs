using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_GL
{
    class Program
    {
        static void Main(string[] args)
        {
            int geburtsJahr = 0;
            int alter = 0;
            bool isInputValid = false;

            Console.Write("Bitte Geburtsjahr eingeben: ");

            try
            {
              
                geburtsJahr = int.Parse(Console.ReadLine());
                isInputValid = true;

               
            }
            catch
            {
                isInputValid = true;

                Console.WriteLine("Unfortunately something went wrong!");
            }
            if (isInputValid == true)
            {

                alter = DateTime.Now.Year - geburtsJahr;
                Console.WriteLine("Du bist " + alter + " Jahre alt. ");

   
            }
        }
    }
}
