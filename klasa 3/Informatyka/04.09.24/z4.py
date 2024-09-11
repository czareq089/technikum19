# Zadanie 4

n = int(input())

ilosc = 0

for i in range(0, n):
    if n % i == 0:
        ilosc += 1
        print(i)
