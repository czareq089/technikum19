plik = open("ciag.txt", "r")
liczby = list(map(int, plik.readline().split()))
plik.close()
n = len(liczby)
maksimum = sum(liczby[:3])
for i in range(1, n-2):
    suma = sum(liczby[i:i+3])
    if suma > maksimum:
        maksimum = suma
print(maksimum)