using System;

namespace OOPINtroCSharp
{
    internal class Persoana
    {
        private string name;
        private int yearOfBirth;

        public Persoana()
        {
            name = "Default Person";
            yearOfBirth = 2000;
        }

        public Persoana(string name, int yearOfBirth)
        {
            this.name = name;
            this.yearOfBirth = yearOfBirth;
        }

        internal void ConsoleWrite()
        {
            Console.WriteLine(name + " - " + yearOfBirth);
        }
    }
}