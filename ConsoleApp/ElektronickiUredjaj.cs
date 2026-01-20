using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ElektronickiUredjaj
    {
        public string Naziv;
        public string Proizvodjac;
        public int GodinaProizvodnje;

        public ElektronickiUredjaj(string naziv, string proizvodjac, int godina)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godina;
        }

        public void IspisiInformacije()
        {
            Console.WriteLine(Naziv);
            Console.WriteLine(Proizvodjac);
            Console.WriteLine(GodinaProizvodnje);
        }
    }
}
