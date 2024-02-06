namespace Kotlarski_Cezary_06._02.classes;

public class Person
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string DataUrodzenia { get; set; }
    public List<string> ImionaZwierzat { get; set; }
    
    public Person(string imie, string nazwisko, string dataUrodzenia, List<string> imionaZwierzat)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        DataUrodzenia = dataUrodzenia;
        ImionaZwierzat = imionaZwierzat;
    }
    
    public void GetInfo()
    {
        Console.WriteLine($"Imie: {Imie}, Nazwisko: {Nazwisko}, Data urodzenia: {DataUrodzenia}");
        Console.WriteLine("Imiona zwierzat:");
        foreach (var imieZwierzaka in ImionaZwierzat)
        {
            Console.WriteLine(imieZwierzaka);
        }
    }
    
    public void AddAnimal(string imieZwierzaka)
    {
        ImionaZwierzat.Add(imieZwierzaka);
    }
    
    public string ListAnimals()
    {
        string listaZwierzat = "";
        foreach (var imieZwierzaka in ImionaZwierzat)
        {
            listaZwierzat += imieZwierzaka + ", ";
        }
        return listaZwierzat.TrimEnd(',', ' ');
    }
}