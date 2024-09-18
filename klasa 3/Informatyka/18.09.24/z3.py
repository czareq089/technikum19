def dzielniki(n):
    wszystkie = []
    for i in range(1, n-1):
        if n % i == 0:
            wszystkie.append(i)
    return sum(wszystkie)

plik = open("liczby2.txt", "r")
liczby = list(map(int, plik.read().split()))
plik.close()

wszystkie_dzielniki = []
for i in liczby:
    wszystkie_dzielniki.append(dzielniki(i))

print(sum(wszystkie_dzielniki))


