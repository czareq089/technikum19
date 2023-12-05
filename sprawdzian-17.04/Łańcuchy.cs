using System.Collections;

/*
// 1 - odwracanie napisu
string napis = Console.ReadLine();

for (int i = 0; i < napis.Length; i++)
{
    Console.Write(napis[napis.Length - i - 1]);
}


// 2 - usuwanie duplikatów
string duplikaty = Console.ReadLine();
string bezduplikatow = new string(duplikaty.Distinct().ToArray());
Console.WriteLine(bezduplikatow);

// 3 - wyliczanie powtórzeń
string powtorzenia = Console.ReadLine();
int suma = 0;
for (int i = 0; i < powtorzenia.Length - 1; i++)
{
    if (powtorzenia[i] == powtorzenia[i + 1])
    {
        suma++;
    }
}
Console.WriteLine(suma + 1);

// 4 - anagramy 
string wyraz = Console.ReadLine();
string anagram = Console.ReadLine();

wyraz = new string(wyraz.OrderBy(c => c).ToArray());
anagram = new string(anagram.OrderBy(c => c).ToArray());

if (wyraz == anagram)
{
    Console.WriteLine("anagram");
}
else
{
    Console.WriteLine("nie");
}

//5 - kolejność alfabetyczna
string alfa = Console.ReadLine();
alfa = new string(alfa.OrderBy(a => a).ToArray());
Console.WriteLine(alfa);

//6 - palindrom 
string slowo = Console.ReadLine();
char[] charArray = slowo.ToCharArray();
Array.Reverse(charArray);
string owols = new string(charArray);

if (slowo == owols)
{
    Console.WriteLine("tak");
}
else
{
    Console.WriteLine("nie");
}
*/
//7 - usuwanie spacji
string wyraz = Console.ReadLine();

string bezspacji = new string (wyraz.Replace(" ", ""));

Console.WriteLine(bezspacji);