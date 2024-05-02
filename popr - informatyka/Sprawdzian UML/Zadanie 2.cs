internal class Kompozycja
{


    class Przystanek
    {
        public string nazwa { get; set; }
        public int numer { get; set; }

        public List<Przystanek> listaPrzystanków = new List<Przystanek>();

        public string TypPrzystanku { get; set; }

        public Dictionary<int, Autobus> listaAutobusów { get; set; }
        public int PunktCentralny()
        {
            return 0;
        }
    }

    public class Biletomat
    {
        public bool czyDziała { get; set; }
    }


    public class Autobus
    {
        public int numer { get; set; }

    }

    public static void Main(string[] args)
    {
        Autobus autobus = new Autobus();
        autobus.numer = 1;
        autobus.

        Przystanek przystanek = new Przystanek();
        przystanek.nazwa = "Przystanek 1";
        przystanek.numer = 1;
        przystanek.TypPrzystanku = "Zwykły";



    }
}
