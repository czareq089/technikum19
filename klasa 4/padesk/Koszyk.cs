
namespace Sklep
{
    internal class Koszyk
    {
        public List<Produkt> Produkty = new();
        public IZniżkaStrategia ZniżkaStrategia;

        public Koszyk()
        {
            generujPróbki();
        }
        
       

        private void generujPróbki()
        {
            Produkty.Add(new ProduktFizyczny("Komputer", 400));
            Produkty.Add(new ProduktFizyczny("Zinger", 25));
        }

        public void DodajProdukt(string nazwa, int cena)
        {
            Produkty.Add(new ProduktFizyczny(nazwa, cena));
        }

        public int obliczWartośćKoszyka()
        {
            int w = 0;
            foreach (var item in Produkty)
            {
                w += item.Cena;
            }
            return w;
        }

        public int obliczWartośćKoszykaPoRabacie(IZniżkaStrategia zniżkaStrategia, int x)
        {
            this.ZniżkaStrategia = zniżkaStrategia;
            int w = obliczWartośćKoszyka();
            return ZniżkaStrategia.obliczZniżkę(w, x);
        }


    }
}