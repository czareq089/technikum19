List<string> binarne = new List<string>();
int liczbaZrównoważonych = 0;
int liczbaPrawieZrównoważonych = 0;
bool czyZrównoważona(string liczba)
{
    int licznik = 0;
    foreach(char c in liczba    )
    {
        if (c == '0')
        {
            licznik++;
        }
        else
        {
            licznik--;
        }
    }
    return licznik == 0;
}

bool czyPrawieZrównoważona(string liczba)
{
    int licznik = 0;
    foreach (char c in liczba)
    {
        if (c == '0')
        {
            licznik++;
        }
        else
        {
            licznik--;
        }
    }
    return Math.Abs(licznik) == 1;
}

StreamReader sr = new StreamReader("przyklad.txt");
string linia;
while ((linia = sr.ReadLine()) != null)
{
    binarne.Add(linia);
    if (czyZrównoważona(linia))
    {
        liczbaZrównoważonych++;
    }
    if (czyPrawieZrównoważona(linia))
    {
        liczbaPrawieZrównoważonych++;
    }
}

Console.WriteLine("Zrównoważonych: " + liczbaZrównoważonych);
Console.WriteLine("Prawie zrównoważonych: " + liczbaPrawieZrównoważonych);


//3.2

StreamReader sr2 = new StreamReader("anagram.txt");

string linia2;
List<string> anagramy = new List<string>();

while ((linia2 = sr2.ReadLine()) != null && (linia2 = sr2.ReadLine()).Length == 8)
{
    anagramy.Add(linia2);
}

int liczbaAnagramów = 0;

Console.WriteLine("Najwięcej anagramów mają liczby: ");

foreach(var item in anagramy)
{
    item.Remove(0);
}