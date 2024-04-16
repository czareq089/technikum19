using System;
using System.Collections.Generic;
using Symulator.classes;
namespace Symulator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Car> list = new List<Car>();
            Dictionary<int, Car> carDictionary = new Dictionary<int, Car>();

            while (true)
            {
                Console.WriteLine("Menu glowne:");
                Console.WriteLine("1. Dodaj samochod");
                Console.WriteLine("2. Usun samochod");
                Console.WriteLine("3. Wyswietl liste samochodow");
                Console.WriteLine("4. Symuluj losowe uszkodzenie");
                Console.WriteLine("5. Jedz samochodem");
                Console.WriteLine("6. Wyjdz z programu");
                Console.Write("Wybierz opcje: ");
                int option = int.Parse(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                        Console.Write("Podaj marke samochodu: ");
                        string brand = Console.ReadLine();
                        Console.Write("Podaj model samochodu: ");
                        string model = Console.ReadLine();
                        Car car = new Car(brand, model);
                        list.Add(car);
                        carDictionary.Add(list.Count, car);
                        break;
                    case 2:
                        Console.Write("Podaj numer samochodu do usuniecia: ");
                        int carNumber = int.Parse(Console.ReadLine());
                        list.RemoveAt(carNumber - 1);
                        carDictionary.Remove(carNumber);
                        break;
                    case 3:
                        foreach (var car1 in list)
                        {
                            Console.WriteLine($"Samochod marki {car1.Brand} model {car1.Model}");
                        }
                        break;
                    case 4:
                        Console.Write("Podaj numer samochodu do uszkodzenia: ");
                        int carNumber2 = int.Parse(Console.ReadLine());
                        carDictionary[carNumber2].SimulateRandomDamage();
                        break;
                    case 5:
                        Console.Write("Podaj numer samochodu do jazdy: ");
                        int carNumber3 = int.Parse(Console.ReadLine());
                        carDictionary[carNumber3].Drive();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}