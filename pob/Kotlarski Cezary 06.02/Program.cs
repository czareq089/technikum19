//Cezary Kotlarski 2E grupa 2

using Kotlarski_Cezary_06._02.classes;
internal class Program
{
    static void Main(string[] args)
    {
        Person osoba = new Person("Cezary", "Kotlarski", "08.04.2008", new List<string>()); //deklaracja obiektu osoba
        Animal pies = new Animal("Burek", "Pies", "Brazowy", 5, 15.5f, osoba); //deklaracja obiektu pies
        pies.Characteristics.Add("przyjazny"); //dodanie cech charakterystycznych dla obiektu (gatunku) pies
        pies.Characteristics.Add("wierny");
        pies.Characteristics.Add("lojalny");
        pies.Characteristics.Add("energiczny");
        pies.Characteristics.Add("radosny");
        osoba.AddAnimal("Burek"); //dodanie imienia zwierzaka do listy imion zwierzat osoby
        pies.GetInfo(); //wywolanie metody GetInfo() obiektu pies (metoda wypisuje informacje o obiekcie pies)
        Console.ReadKey();
        //Wynik:
        /*
            Imie: Burek, Gatunek: Pies, Kolor: Brazowy, Wiek: 5, Waga: 15.5kg
            Wlasciciel: Cezary Kotlarski, Data urodzenia: 08.04.2008, Imiona zwierzat: Burek
            Cechy charakterystyczne dla gatunku Pies: Przyjazny, Wierny, Lojalny, Energiczny, Radosny
         */
    }
}

