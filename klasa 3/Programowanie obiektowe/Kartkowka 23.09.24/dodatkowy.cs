/*using System;

public class Vehicle
{
    public string Brand;
    public string Model;

    // Constructor for the Vehicle class
    public Vehicle(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    // Virtual method to be overridden in derived classes
    public virtual void DisplayInfo()
    {
        Console.Write($"{Brand} {Model}");
    }
}

public class Car : Vehicle
{
    public int IloscDrzwi; // Number of doors

    // Constructor for the Car class, which calls the base constructor
    public Car(string brand, string model, int ilosc) : base(brand, model)
    {
        IloscDrzwi = ilosc;
    }

    // Overriding the DisplayInfo method to include the number of doors
    public override void DisplayInfo()
    {
        Console.Write($"{Brand} {Model} {IloscDrzwi}");
    }
}

public class Motor: Vehicle
{
    public bool HasSideCar;
    public Motor(string brand,string model, bool has) : base(brand,model)
    {
        HasSideCar = has;
    }
    
    public override void DisplayInfo()
    {
        Console.Write($"{Brand} {Model} {HasSideCar}");
    }
}

public class HelloWorld
{
    public static void Main()
    {
        Car auto = new Car("McLaren", "Senna", 3);
        auto.DisplayInfo();
        Console.WriteLine();
        Motor motorek = new Motor("Duke","140",false);
        motorek.DisplayInfo();
    }
}*/