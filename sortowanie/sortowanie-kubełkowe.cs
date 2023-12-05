int[] T = new int[20];

Random r = new Random();

for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 100);
}

int[] B = new int[100];
for (int i = 0; i < T.Length; i++)
{
    B[T[i]]++;
}

int k = 0;
for (int i = 0; i < B.Length; i++)
{
    for (int j = 0; j < B[i]; j++)
    {
        T[k++] = i;
    }
}
for (int i = 0; i < T.Length; i++)
{
    Console.WriteLine(T[i]);
}
