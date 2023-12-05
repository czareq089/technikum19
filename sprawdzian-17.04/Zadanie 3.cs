// Zapisz do pliku 20 różnych liczb dwucyfrowych. Otwórz plik i wypisz wszystkie te liczby, których suma cyfr wynosi 10

using System;
using System.IO;

int[] T = new int[20];

Random rnd = new Random();

for (int i = 0; i < T.Length; i++)
{
    T[i] = rnd.Next(10, 100);
}

StreamWriter sw = new StreamWriter (@"C:\Users\cezar\Documents\liczby.txt");
for (int i = 0; i < T.Length; i++)
{
    sw.WriteLine(T[i]);
}

sw.Close();

StreamReader sr = new StreamReader(@"C:\Users\cezar\Documents\liczby.txt");

string linia = sr.ReadLine();


while (linia != null)
{
    int liczbad = int.Parse(linia[0].ToString());
    int liczbaj = int.Parse(linia[1].ToString());
    int suma = liczbad + liczbaj;
    if (suma == 10)
    {
        Console.WriteLine(linia);
    }
    linia = sr.ReadLine();
}
sw.Close();
sr.Close();

Console.ReadKey();















