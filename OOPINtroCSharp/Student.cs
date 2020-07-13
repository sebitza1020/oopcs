using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPINtroCSharp
{
    class Student:Persoana
    {
        private string facultate;

        public Student():base("Student implicit", 2002)
        {
            facultate = "facultate implicita";
        }

        public Student(string name, int yearOfBirth, string facultate):base(name, yearOfBirth)
        {
            this.facultate = facultate;
        }

        public void ConsoleWrite()
        {
            Console.WriteLine(name + " - " + yearOfBirth + " - " + facultate);
        }
    }
}
