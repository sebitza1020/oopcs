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

        internal void ConsoleWrite()
        {
            Console.WriteLine(name + " - " + yearOfBirth);
        }
    }
}