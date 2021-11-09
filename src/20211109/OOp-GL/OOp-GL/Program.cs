using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.ConsoleTools.Misc;

namespace OOp_GL
{
    class Program
    {
        static void Main(string[] args)
        {
            Mitarbeiter ma = new Mitarbeiter("Gandalf", Gender.Male, new DateTime(1890, 5 ,20));
            Mitarbeiter ma2 = new Mitarbeiter("Marthine", Gender.Divers, new DateTime(1900, 3, 22));
            

            ma.DisplayInfos();
            ma2.DisplayInfos();

            ma.

            ma.Name = "GAndalf der Graue";
            Console.WriteLine(ma.Name);
        }
    }
}
