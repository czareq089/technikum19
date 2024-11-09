def wyszukiwanie_binarne(T, a, n):
    lewy = 0
    prawy = n-1
    while lewy < prawy:
        srodek = (lewy + prawy)//2
        if T[srodek] < a:
            lewy = srodek + 1
        else:
            prawy = srodek
    return T[lewy] == a


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
if wyszukiwanie_binarne(T, liczba, len(T)):
    print("Tak")
else:
    print("Nie")
