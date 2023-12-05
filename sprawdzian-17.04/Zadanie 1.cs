using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Średnia arytmetyczna podanych liczb wynosi: " + Average(a, b));
            Console.ReadKey();
        }
        static int Average(int a, int b)
        {
            return (a + b) / 2;
        }
    }
}