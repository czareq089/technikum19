// 1. Stwórzcie tablice 115 pierwszych liczb, które w reprezentacji binarnej kończą się na 11, 111, 1011, 1111
// 2. stwórzcie plik o nazwie osoby z zawartością 5 osób: imię nazwisko wiek
// 3. wstawcie obiekty do typu osoba z właściwościami / polami pliku, czyli imie, nazwisko, wiek

/*
int[] tab = new int[115];

for (int i = 0; i < 115; i++)
{
    tab[i] = i;
}

for (int i = 0; i < 115; i++)
{
    if (tab[i] % 4 == 3)
    {
        Console.WriteLine(tab[i]);
    }
}

Console.ReadKey();
*/



/*StreamReader sr = new StreamReader("osoby.txt");
string line = sr.ReadLine();
string[] osoby = new string[5];

for (int i = 0; i < 5; i++)
{
    osoby[i] = line;
    line = sr.ReadLine();
}

sr.Close();

Osoba[] osobyObiekty = new Osoba[5];

for (int i = 0; i < 5; i++)
{
    string[] dane = osoby[i].Split(' ');
    osobyObiekty[i] = new Osoba(dane[0], dane[1], int.Parse(dane[2]));
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(osobyObiekty[i].Imie + " " + osobyObiekty[i].Nazwisko + " " + osobyObiekty[i].Wiek);
}

Console.ReadKey();

class Osoba
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public int Wiek { get; set; }

    public Osoba(string imie, string nazwisko, int wiek)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Wiek = wiek;
    }
}*/

using System.Collections;

ArrayList al = new ArrayList();

al.Add(1);
al.Add(2);
al.Add(0);

int i = 2;
while (al[i] < 100)
{
    al[i] = al[i-1] + al[i-2];
    i++;
}