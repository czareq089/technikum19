using System;
namespace Symulator.classes
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool isDamaged { get; set; }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
            isDamaged = false;
        }

        public void Drive()
        {
            if (isDamaged)
            {
                Console.WriteLine($"Samochod marki {Brand} model {Model} jest uszkodzony i nie moze jechac.");
            }
            else
            {
                Console.WriteLine($"Jade samochodem {Brand} {Model}.");
            }
        }

        public void SimulateRandomDamage()
        {
            Random random = new Random();
            int damageType = random.Next(1, 3);

            switch (damageType)
            {
                case 1:
                    Console.WriteLine($"Samochod marki {Brand} model {Model} ma przebitą oponę.");
                    isDamaged = true;
                    break;
                case 2:
                    Console.WriteLine($"Silnik samochodu marki {Brand} model {Model} odmówił posłuszeństwa.");
                    break;
                case 3:
                    Console.WriteLine($"Samochód marki {Brand} model {Model} ma problemy z układem hamulcowym.");
                    break;
            }
        }
    }
}