/*
 1. Wpisz do tablicy T 5 losowych liczb dwucyfrowych. Stwórz tablicę W liczb parzystych znajdujących się między 
minimalną i maksymalną wartością z tablicy T.

2. Utwóz ArrayListę A zawierającą 10 losowych słów 3-literowych. 
    Wypisz słowo o najwiekszej sumie kodów ASCII jego liter

3. Stwórz listę L składającą się z list 10 losowych cyfr. Oblicz sumę maksymalnych cyfr w listach listy L oraz 
    sprawdź czy istnieje taka lista gdzie wylosowano 3 identyczne cyfry.

4. Stwórz słownik D z kluczami i = 1, 2, 3 ... n (user podaje n) oraz wartościami 
i-cyfrowych dzielników każdej liczby 10 do potęgi i dla każdego z kluczy.

5. Korzystając ze słownika utwórz graf G zbudowany z n wierzchołków i k krawędzi. 
    Policz wierzchołki nie mające żadnych sąsiadów.
*/

using System.Collections;

//1
Console.WriteLine("Zadanie 1");
Random r = new Random();
int[] T = new int[5];
Console.WriteLine("5 losowych liczb:");
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(10, 100);
    Console.Write(T[i] + " ");
}

int min = T[0];
int max = T[0];
foreach (var l in T)
{
    if (l < min)
    {
        min = l;
    }

    if (l > max)
    {
        max = l;
    }
}
Console.Write($"\n");
Console.WriteLine("Przedział liczb parzystych:");
int[] W = new int[(max - min) / 2 + 1];
int index = 0;
for (int i = min; i <= max; i++)
{
    if (i % 2 == 0)
    {
        W[index] = i;
        Console.Write(W[index] + " ");
        index++;
    }
}

//2
Console.WriteLine("\n");
Console.WriteLine("Zadanie 2");
ArrayList A = new ArrayList();
Random rnd = new Random();
for (int i = 0; i < 10; i++)
{
    A.Add((char)rnd.Next(97, 123) + "" + (char)rnd.Next(97, 123) + "" + (char)rnd.Next(97, 123));
}

foreach (var item in A)
{
    Console.Write(item + "\t");
}

int maxsuma = 0;
string maxString = "";
foreach (var item in A)
{
    int sum = 0;
    foreach (var letter in item.ToString())
    {
        sum += letter;
    }
    if (sum > maxsuma)
    {
        maxsuma = sum;
        maxString = item.ToString();
    }
}

Console.WriteLine(maxString);

//3
Console.WriteLine("\n");
Console.WriteLine("Zadanie 3");
List<List<int>> L = new List<List<int>>();
for (int i = 0; i < 10; i++)
{
    List<int> list = new List<int>();
    for (int j = 0; j < 10; j++)
    {
        list.Add(r.Next(0, 10));
    }
    L.Add(list);
}

