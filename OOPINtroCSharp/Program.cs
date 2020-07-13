using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPINtroCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoana p = new Persoana();
            p.ConsoleWrite();

            Persoana q = new Persoana("Michael", 7);
            q.ConsoleWrite();

            Elev e = new Elev();
            e.ConsoleWrite();
        }
    }
}
