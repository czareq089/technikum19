using Main.classes;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(suma.Suma(2, 5));
            osoby osoba = new osoby("Jan", "Kowalski", "M");
            Console.WriteLine(osoba.Opis());
        }
    }
}
