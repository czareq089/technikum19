plik = open("liczby.txt", "r")
liczby = list(map(int, plik.readline().split()))
dlugosci = []
n = len(liczby)
dlugosc = 1
for i in range(n):
    if liczby[i] <= liczby[i+1]:
        dlugosc += 1
    else:
        dlugosci.append(dlugosc)
        dlugosc = 1
dlugosci.append(dlugosc)
print(max(dlugosci))
plik.close()