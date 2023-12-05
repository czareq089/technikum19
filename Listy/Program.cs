namespace Listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tworzenie listy liczb całkowitych używając .Add
            List<int> ints = new List<int>();
            //dodawanie elementów do listy
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            foreach (var i in ints)
            {
                Console.Write($"[{i}] ");
            }
            Console.WriteLine();
            Console.WriteLine();
            //usuwanie elementu z listy
            ints.Remove(2);
            foreach (var i in ints)
            {
                Console.Write($"[{i}] ");
            }
            Console.WriteLine();
            Console.WriteLine();
            
            //tworzenie listy liczb całkowitych używając inicjalizatora kolekcji
            List<int> ints2 = new List<int> { 1, 2, 3, 10 };
            foreach (var i in ints2)
            {
                Console.Write($"[{i}] ");
            }

            Console.WriteLine();
            Console.WriteLine();
            //tworzenie listy losowych liczb całkowitych
            List<int> lista = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                lista.Add(random.Next(1, 100+1));
            }
            Console.WriteLine("Lista liczb losowych: ");
            Console.WriteLine();
            foreach (var i in lista)
            {
                Console.Write($"[{i}] ");
            }

            Console.WriteLine();
            Console.WriteLine();
            
            //użycie metody divisibleByThreeOrFive
            List<int> listDivisibleByThreeOrFive = divisibleByThreeOrFive(lista);
            Console.WriteLine("Liczby podzielne przez 3 lub 5 z powyższej listy:");
            Console.WriteLine();
            foreach (int i in listDivisibleByThreeOrFive)
            {
                Console.Write($"[{i}] ");
            }
            Console.ReadKey();
        }

        static List<int> divisibleByThreeOrFive(List<int> lista)
        {
            List<int> result = new List<int>();
            foreach (var i in lista)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}