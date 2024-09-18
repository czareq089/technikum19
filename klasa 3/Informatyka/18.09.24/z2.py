plik = open("liczby2.txt", "r")
liczby = list(map(int, plik.read().split()))
plik.close()

for i in liczby:
    if i % 2 == 0:
        print(i)