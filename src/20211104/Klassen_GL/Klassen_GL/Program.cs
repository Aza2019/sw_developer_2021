using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.ConsoleTools.Misc;

namespace Klassen_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanzierung
            Mitarbeiter ma = new Mitarbeiter();

            //Klasse / Object = Instanz
            ma.Name = "Gandalf";
            ma.Geschlecht = Gender.Male;
            ma.ChangeName("Gandalf Der Graue");
            ma.Id = Guid.NewGuid();

            Mitarbeiter ma2 = new Mitarbeiter();


            //Klasse / Object = Instanz
            ma2.Name = "Eomer";
            ma2.Geschlecht = Gender.Male;
            ma2.Id = Guid.NewGuid();



            ma.DisplayInfos();
            ma2.DisplayInfos();


        }      
    }
}
