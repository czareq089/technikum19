namespace Main.classes;

public class osoby
{
    public string imie;
    public string nazwisko;
    public string plec;
    
    public string Imie
    {
        get { return imie; }
        set { imie = value; }
    }
    
    public string Nazwisko
    {
        get { return nazwisko; }
        set { nazwisko = value; }
    }
    
    public string Plec
    {
        get { return plec; }
        set { plec = value; }
    }
    
    public osoby(string imie, string nazwisko, string plec)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.plec = plec;
    }
    
    public string Opis()
    {
        return "Imie: " + imie + " Nazwisko: " + nazwisko + " Plec: " + plec;
    }
}