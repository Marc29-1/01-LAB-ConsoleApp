using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav;

        public PametniTelefon(string naziv, string proizvodjac, int godina, string os)
            : base(naziv, proizvodjac, godina)
        {
            OperativniSustav = os;
        }

        public void InstalirajAplikaciju(string app)
        {
            Console.WriteLine("Instalirana aplikacija: " + app);
        }
    }
}
