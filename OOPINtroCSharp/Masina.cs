using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPINtroCSharp
{
    class Masina:IHasExport
    {
        private string tip;
        private string culoare;

        public Masina()
        {
            this.tip = "Audi";
            this.culoare = "Red";
        }

        public Masina(string tip, string culoare)
        {
            this.tip = tip;
            this.culoare = culoare;
        }

        public void Export()
        {
            Console.WriteLine("Am exportat masina: " + tip);
        }
    }
}
