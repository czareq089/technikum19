using System.Collections;


int[,] T = new int[10, 10];
Random r = new Random();

for (int i = 0; i < T.GetLength(0); i++)
{
    for (int j = 0; j < T.GetLength(1); j++)
    {
        T[i, j] = r.Next(10, 50);
        Console.WriteLine(T[i, j]);
    }
}

ArrayList AL = new ArrayList();
AL.Add(r.Next(10, 20));

foreach (int item in AL)
{
    Console.WriteLine(item);
}
