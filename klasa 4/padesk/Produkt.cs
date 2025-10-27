using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    internal class Produkt
    {
        public String Nazwa;
        public int Cena;

        public Produkt(string nazwa, int cena)
        {
            Nazwa = nazwa;
            Cena = cena;
        }
    }
}
