using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Koszyk
    {
        public List<Produkt> Produkty;

        public IZniżkaStrategia Strategia;
        public Koszyk()
        {
            GenerujPróbki();
        }
        private void GenerujPróbki()
        {
            Produkty.Add(new ProduktFizyczny("Komputer", 400));
            Produkty.Add(new ProduktFizyczny("Zinger", 25));
        }

        public int ObliczWartoscKoszyka()
        {
            int w = 0;
            foreach (var item in Produkty)
            {
                w += item.Cena;
            }
            return w;
        }

        public int ObliczWartoscKoszykaPoRabacie(IZniżkaStrategia strategia, int x)
        {
            Strategia = strategia;
            int w = ObliczWartoscKoszyka();
            return Strategia.obliczZniżke(w, x);
            
        }
    }
}
