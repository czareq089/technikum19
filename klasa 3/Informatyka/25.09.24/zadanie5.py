def sito(n):
    pierwsze = [True] * (n + 1)
    pierwsze[0], pierwsze[1] = False, False

    for i in range(2, int(n ** 0.5) + 1):
        if pierwsze[i]:
            for j in range(i * i, n + 1, i):
                pierwsze[j] = False
    return pierwsze


def przedzial(a, b):
    primes = sito(b)
    return [i for i in range(a, b + 1) if primes[i]]


def stats(a, b):
    lista = przedzial(a, b)
    ilosc = len(lista)
    suma = sum(lista)

    print(lista, ilosc, suma)
