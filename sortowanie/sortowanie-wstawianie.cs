int[] T = new int[20];

Random r = new Random();

for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 100);
}

for (int i = 1; i < T.Length; i++)
{
    int j = i;
    while (j > 0 && T[j - 1] > T[j])
    {
        int temp = T[j];
        T[j] = T[j - 1];
        T[j - 1] = temp;
        j--;
    }
}

for (int i = 0; i < T.Length; i++)
{
    Console.WriteLine(T[i]);
}
