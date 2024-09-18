from math import sqrt
from operator import index

plik = open("liczby2.txt", "r")
liczby = list(map(int, plik.read().split()))
plik.close()

def czy_pierwsza(n):
    if n < 2:
        return False
    p = int(sqrt(n))
    for i in range(2, p+1):
        if n % i == 0:
            return False
    return True

def suma_dzielnikow(n):
    T = []
    for i in range(1, n-1):
        if n % i == 0 and czy_pierwsza(i):
            T.append(i)
    return sum(T)

K = []
for i in liczby:
    K.append(suma_dzielnikow(i))



