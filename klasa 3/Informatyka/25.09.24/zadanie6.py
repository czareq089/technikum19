def sito_eratostenesa(n):
    sito = [True] * (n + 1)
    sito[0] = sito[1] = False
    for i in range(2, int(n ** 0.5) + 1):
        if sito[i]:
            for j in range(i * i, n + 1, i):
                sito[j] = False
    return [x for x in range(2, n + 1) if sito[x]]


def liczby_pierwsze_w_pliku(plik, liczby_pierwsze):
    with open(plik, 'r') as f:
        liczby = list(map(int, f.readline().strip().split()))
    liczby_pierwsze_set = set(liczby_pierwsze)
    liczby_pierwsze_w_pliku = [liczba for liczba in liczby if liczba in liczby_pierwsze_set]


    procent = (len(liczby_pierwsze_w_pliku) / len(liczby)) * 100 if len(liczby) > 0 else 0

    return len(liczby_pierwsze_w_pliku), procent


if __name__ == "__main__":
    liczby_pierwsze = sito_eratostenesa(1000)
    plik = 'ciag.txt'
    liczba_liczb_pierwszych, procent = liczby_pierwsze_w_pliku(plik, liczby_pierwsze)
    print(f"Liczba liczb pierwszych w pliku: {liczba_liczb_pierwszych}")
    print(f"Procent liczb pierwszych w pliku: {procent:.2f}%")