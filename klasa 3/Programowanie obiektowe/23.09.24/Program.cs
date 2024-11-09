using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_dziedziczenie
{
  internal class Program
  {

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

      public Circle(float r)
      {
        radius = r;
      }

      public void SetRadius(float r)
      {
        radius = r;
      }

      public override float CalculateArea()
      {
        // return base.CalculateArea();
        return (float)Math.Round((Math.PI * radius * radius), 2);
      }

      public override float CalculatePerimeter()
      {
        return (float)Math.Round((2 * Math.PI * radius), 2);
      }
    }

    class Triangle : Shape
    {
      private float sideA;
      private float sideB;
      private float sideC;

      public Triangle(float sideA, float sideB, float sideC)
      {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
      }

      public override float CalculateArea()
      {
        float s = (sideA + sideB + sideC) / 2;
        return (float)Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
      }

      public override float CalculatePerimeter()
      {
        return sideA + sideB + sideC;
      }
    }
    static void Main(string[] args)
    {
      while (true)
      {
        Console.WriteLine("Wybierz kształt do obliczenia:");
        Console.WriteLine("1. Prostokąt");
        Console.WriteLine("2. Koło");
        Console.WriteLine("3. Trójkąt");
        Console.WriteLine("4. Trapez");
        Console.WriteLine("5. Kula");
        Console.WriteLine("6. Wyjście");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
          case 1:
            Rectangle rect = new Rectangle();
            Console.Write("Podaj szerokość:");
            float rectWidth = float.Parse(Console.ReadLine());
            Console.Write("Podaj wysokość:");
            float rectHeight = float.Parse(Console.ReadLine());
            rect.SetDimensions(rectWidth, rectHeight);
            Console.WriteLine("Powierzchnia prostokąta: {0}", rect.CalculateArea());
            Console.WriteLine("Obwód prostokąta: {0}", rect.CalculatePerimeter());
            break;
          case 2:
            float circRadius = GetValidInput("Podaj promień:");
            Circle circ = new Circle(circRadius);
            Console.WriteLine("Powierzchnia koła: {0}", circ.CalculateArea());
            Console.WriteLine("Obwód koła: {0}", circ.CalculatePerimeter());
            break;
          case 3:
            float sideA, sideB, sideC;
            do
            {
              sideA = GetValidInput("Podaj długość boku A:");
              sideB = GetValidInput("Podaj długość boku B:");
              sideC = GetValidInput("Podaj długość boku C:");

              if (!IsValidTriangle(sideA, sideB, sideC))
              {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNieprawidłowe dane. Spróbuj ponownie.\n");
                Console.ResetColor();
              }
            } 
            while (!IsValidTriangle(sideA, sideB, sideC));

            Triangle tri = new Triangle(sideA, sideB, sideC);
            Console.WriteLine("Powierzchnia trójkąta: {0}", tri.CalculateArea());
            Console.WriteLine("Obwód trójkąta: {0}", tri.CalculatePerimeter());

            break;
          case 6:
            return;
          default:
            Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie");
            break;

        }

      }


      /*
      Rectangle rect = new Rectangle();

      rect.SetHeight(2.5f);
      rect.SetWidth(3f);

      Console.WriteLine("Pole prostokąta wynosi: {0}", rect.CalculateArea());

      Circle circ = new Circle();
      circ.SetRadius(2.4f);
      Console.WriteLine("Pole koła wynosi: {0}", circ.CalculateArea());
      */
      Console.ReadKey();
    }

    private static bool IsValidTriangle(float sideA, float sideB, float sideC)
    {
      return (sideA + sideB > sideC) && (sideB + sideC > sideA) && (sideA + sideC > sideB);
    }

    private static float GetValidInput(string prompt)
    {
      float result;
      while (true)
      {
        Console.Write(prompt);
        if (float.TryParse(Console.ReadLine(), out result) && result > 0)
        {
          return result;
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Nieprawidłowe dane. Spróbuj ponownie.");
          Console.ResetColor();
        }
      }
    }
  }
}
