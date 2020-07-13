using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPINtroCSharp
{
    class Elev : Persoana
    {
        private int nota;
        private string scoala;
        public Elev():base("Default elev", 2010)
        {
            nota = 8;
            scoala = "Scoala Gimnaziala nr. 21";
        }

        public Elev(string name, int yearOfBirth, int nota, string scoala):base(name, yearOfBirth)
        {
            this.nota = nota;
            this.scoala = scoala;
        }

        public override void ConsoleWrite()
        {
            Console.WriteLine(name + " - " + yearOfBirth + " - " + scoala + " - " + nota);
        }
    }
}
