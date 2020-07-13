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
            Persoana q = new Persoana("Michael", 7);
            Elev e = new Elev();
            Elev f = new Elev("Hoko", 1999, 5, "Scoala vietii");
            Student s = new Student();
            Student w = new Student("Dorel", 2008, "litere");


            List<IHasExport> l = new List<IHasExport>();
            l.Add(p);
            l.Add(q);
            l.Add(e);
            l.Add(f);
            l.Add(s);
            l.Add(w);
            l.Add(new Masina());

            foreach(IHasExport obiect in l)
            {
                obiect.Export();
            }

        }
    }
}
