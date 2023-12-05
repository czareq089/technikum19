int[] T = new int[20];
Random r = new Random();

for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(0, 100);
}

for (int i = 0; i < T.Length; i++)
{
    for (int j = 0; j < T.Length - 1; j++)
    {
        if (T[j] > T[j + 1])
        {
            int temp = T[j];
            T[j] = T[j + 1];
            T[j + 1] = temp;
        }
    }
}


foreach (int item in T)
{
    Console.WriteLine(item);
}


