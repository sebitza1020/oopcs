using System;

namespace OOPINtroCSharp
{
    internal class Persoana:IHasExport
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

        public virtual void ConsoleWrite()
        {
            Console.WriteLine("->" + name + " - " + yearOfBirth);
        }

        public void Export()
        {
            Console.WriteLine("Am exportat persoana: " + name);
        }
    }
}