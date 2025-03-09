plik = open("ciagi.txt", "r")
liczby = list(map(int, plik.readline().split()))
plik.close()

for i in liczby