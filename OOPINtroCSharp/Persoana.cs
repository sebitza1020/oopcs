using System;

namespace OOPINtroCSharp
{
    internal class Persoana
    {
        protected string name;
        protected int yearOfBirth;

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