﻿using System;
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

            Elev f = new Elev("Hoko", 1999, 5, "Scoala vietii");
            f.ConsoleWrite();
                
            Student s = new Student();
            s.ConsoleWrite();

            Student w = new Student("Dorel", 2008, "litere");
            w.ConsoleWrite();
        }
    }
}
