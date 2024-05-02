namespace Dziedziczenie
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public double Fuel { get; set; }

        public virtual void StartEngine()
        {
            Console.WriteLine("\nEngine started");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine("\nEngine stopped");
        }

        public void Refuel(double fuel)
        {
            Fuel += fuel;
            Console.WriteLine($"\nRefueled by {fuel} liters");
        }

        public class Car : Vehicle
        {
            public byte Doors { get; set; }
        }

        internal class Program
        {
            public class Main(string[] args)
            {
                Vehicle v = new Vehicle();
                
            }
        }
    }
}