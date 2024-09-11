using System.ComponentModel.Design;

namespace _09._09._24;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1. Prostokąt");
            Console.WriteLine("2. Koło");
            Console.WriteLine("3. Trójkąt");
            Console.WriteLine("4. Trapez");
            Console.WriteLine("5. Wyjście");
            Console.WriteLine();
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Rectangle rect = new Rectangle();
                    Console.WriteLine("Podaj szerokość");
                    float width = float.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj długość");
                    float height = float.Parse(Console.ReadLine());
                    rect.SetDimensions(width, height);
                    Console.WriteLine($"Powierzchnia prostokąta to {rect.CalculateArea()}");
                    Console.WriteLine($"Obwód prostokąta to {rect.CalculatePerimeter()}");
                    break;
                case 2:
                    float radius = GetValidInput("Podaj promień");
                    Circle circ = new Circle();
                    circ.SetRadius(radius);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie");
                    break;
            }
        }
    }

    private static float GetValidInput(string prompt)
    {
        float result;
        while (true)
        {
            Console.WriteLine("Podaj promień koła");
            if (float.TryParse(Console.ReadLine(), out result) && result > 0)
            {
                return result;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nieprawidłowe dane");
                Console.ResetColor();
            }
        }
    }
}

class Shape
{
    public virtual float CalculateArea()
    {
        return 0;
    }

    public virtual float CalculatePerimeter()
    {
        return 0;
    }
    
}

class Rectangle : Shape
{
    private float width;
    private float height;

    public void SetDimensions(float w, float h)
    {
        width = w;
        height = h;
    }

    public override float CalculateArea()
    {
        return width * height;
    }

    public override float CalculatePerimeter()
    {
        return 2 * (width + height);
    }
}

class Circle : Shape
{
    private float radius;
    
    public void SetRadius(float r)
    {
        radius = r;
    }

    public override float CalculateArea()
    {
        return (float)(Math.Round(Math.Pow((Math.PI * radius), 2)),2);
    }

    public override float CalculatePerimeter()
    {
        return (float)(Math.Round(2 * Math.PI * radius),2);
    }
}