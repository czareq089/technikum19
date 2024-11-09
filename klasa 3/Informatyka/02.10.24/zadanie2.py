def wyszukiwanie_binarne_rekurencyjne(T, a, n, lewy, prawy):
    if lewy > prawy:
        return False
    srodek = (lewy + prawy) // 2
    if T[srodek] == a:
        return True
    elif T[srodek] < a:
        return wyszukiwanie_binarne_rekurencyjne(T, a, srodek + 1, prawy)
    else:
        return wyszukiwanie_binarne_rekurencyjne(T, a, lewy, srodek - 1)

def ciag_niemalejacy(T, n):
    for i in range(n-1):
        if T[i] > T[i+1]:
            return False
    return True

T = []
for i in range(1, 10):
    T.append(int(input()))
print("Podaj liczbe")
liczba = int(input())
if wyszukiwanie_binarne_rekurencyjne(T, liczba, len(T), 0, len(T) - 1):
    print("Tak")
else:
    print("Nie")