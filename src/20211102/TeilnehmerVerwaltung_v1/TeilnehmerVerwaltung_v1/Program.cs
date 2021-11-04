using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.ConsoleTools;
using TeilnehmerVerwaltung_v1;

namespace TeilnehmerVerwaltung_v1
{
    internal class Program
    {
        /*Teilnehmer verwaltung v
         * 
         * -NAme
         * -Geburtsdatum
         * -Plz
         * 
         */

        static void Main(string[] args)
        {
            int count = 0;
            Teilnehmer [] listofAttendees;
            



            //Eingabe der Anzahl von Teilnemern
            count = UIHelper.GetInt("Bitte Anzahl der Teilnehmer eingeben: ");


            //Dimensiionierung der Liste
            listofAttendees = new Teilnehmer[count];

           

            //Eingabe der Datum
            for (int i = 0; i < count; i++)
            {
                Console.Write($"\tName Teilnehmer {i + 1}: ");
                listofAttendees[i].Name = Console.ReadLine();

                listofAttendees[i].DateOfBirth = UIHelper.GetDateTime(" DateOFBirth: ");
                listofAttendees[i].Plz = UIHelper.GetInt("Plz: ");
                
            }

            //Ausgabe der datum
            foreach(Teilnehmer oneAttendee in listofAttendees)
            {
                Console.WriteLine($"{oneAttendee.Name} ({oneAttendee.DateOfBirth.Year}) kommt aus {oneAttendee.Plz}");
                
            }
        }
    }
}
