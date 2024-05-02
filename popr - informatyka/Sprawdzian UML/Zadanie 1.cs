internal interface Robotny
{
    string Robota { get; set; }

    public void planuj() { } 
}

class Rekin : Robotny
{
    private string imie { get; set; }
    private string nazwisko { get; set; }
    protected void dobierzNarzedzie(Narzedzie);
}

class Leszcz : Robotny
{
    private string imie { get; set; }
    private string odmiana { get; set; }
    protected void wymyślajWymówki() { }
    private void czekaj() { }
    public void udawaj() { }

}

class Gracz : Robotny
{
    private string imie { get; set; }
    private int poziom { get; set; }

    protected void ideGrać() { }
    private void jem() { }

    private bool wydalam() { }

    protected char ZnowuIdeGrać() { }
}

class Narzedzie()
{

}

class Klasa : Teknikum 
{
    public string numerKlasy { get; set; }
    protected List<Robotny> ListaRobotnych = new List<Robotny>();
    
    public void dodajDoListy(List<Robotny> listaRobotnych, Robotny robotny)
    {
         listaRobotnych.Add(robotny);
    }
}

class Teknikum
{
    private string nazwa { get; set; }
    public string podajNazwe(string nazwa) { return nazwa; } 
}

class Szkoła : Teknikum
{
    private string kraj { get; set; } 
    private Szkoła szkola { get; set; }
    public void StworzSzkole() { }
}