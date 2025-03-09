plik = open("ciag.txt", "r")
liczby = list(map(int, plik.readline().split()))
plik.close()

n = len(liczby)
maksimum = liczby[0]
for pocz in range(n):
    for dl in range(1, n-pocz+1):
        suma = sum(liczby[pocz: pocz+dl])
        if suma > maksimum:
            maksimum = suma
print(maksimum)