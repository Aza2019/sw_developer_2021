using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.ConsoleTools.Misc;

namespace OOp_GL
{
    class Mitarbeiter
    {
        private Guid _id;
        private object _Id;
        private string _name;
        private string _Name;
        private Gender _geschlecht;
        private object _Geschlecht;
        private DateTime _birthday;


        ///Standard Konstruktor
        //public Mitarbeiter()
        //{
          //  Id = Guid.NewGuid();
         //   Geschlecht = Gender.Undefined;
           // Name = "NO Name_" + Id;

       // }

        //benutzerspezifische Konstruktor
        public Mitarbeiter(String name, Gender geschlecht, DateTime birthday)
        {
            _id = Guid.NewGuid();
            _geschlecht = geschlecht;
            _name = name;
            _birthday = _birthday;
        }
      //Anderungs und zugriffmethoden   
       // public Guid GetId ()
       // {
          //  return Id;
       // }

    //    public void SetId(Guid newId)
       // {
       //     if(newId ! = Guid.Empty)
       //     {
       //         Id = newId;
      //      }
      //  }
      public Guid Id
        {
            get
            {
                return _id;
            }
        }


            
        public string Name 
        {
        get
            {
                return _name;
            }
            
        }

        public Gender Geschlecht
        {
            get { return _geschlecht; }
            set { _geschlecht = value; }
        }

        public int Alter
        {
            get { return DateTime.Now.Year - _birthday.Year; }
        }
        public void ChangeName(string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                _Name = newName;
            }
        }

        public void DisplayInfos()
        {
            Console.WriteLine($"ID:      [{_Id}]");
            Console.WriteLine($"Name:    {_Name}");
            Console.WriteLine($"Gender:: {_Geschlecht}");

        }
    }
}
