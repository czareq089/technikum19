namespace Kotlarski_Cezary_06._02.classes;

public class Animal
{
    public string Name { get; set; }
    public string Species { get; set; }
    public string Color { get; set; }
    public ushort Age { get; set; }
    public float Weight { get; set; }
    
    public List<string> Characteristics { get; set; }
    public Person Owner { get; set; }
    
    public Animal(string name, string species, string color, ushort age, float weight, Person owner)
    {
        Name = name;
        Species = species;
        Color = color;
        Age = age;
        Weight = weight;
        Owner = owner;
        Characteristics = new List<string>();
    }
    
    public string GetCharacteristics()
    {
        string info = $"Cechy charakterystyczne dla gatunku {Species}: ";
        foreach (var characteristic in Characteristics)
        {
            info += characteristic + ", ";
        }
        return info.TrimEnd(',', ' ');
    }
    public void GetInfo()
    {
        Console.WriteLine($"Imie: {Name}, Gatunek: {Species}, Kolor: {Color}, Wiek: {Age}, Waga: {Weight}kg");
        Console.WriteLine($"Wlasciciel: {Owner.Imie} {Owner.Nazwisko}, Data urodzenia: {Owner.DataUrodzenia}, Imiona zwierzat: {Owner.ListAnimals()}");
        Console.WriteLine(GetCharacteristics());
    }
}