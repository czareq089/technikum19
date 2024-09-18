#
# Napisz program, który sprawdzi, czy liczba całkowita dodatnia n podana przez użytkownika jest liczbą
# doskonałą. Liczba doskonała, to taka, która jest równa sumie swoich dzielników właściwych (czyli
# mniejszych od tej liczby). Program wyświetli jeden z komunikatów „tak” lub „nie”. Przykładowe liczby
# doskonałe:
# 6 = 1+2+3
# 28 = 1+2+4+7+14

n = int(input())
T = []

for i in range(1, n - 1):
    if n % i == 0:
        T.append(i)
print(sum(T))

if sum(T) == n:
    print("tak")
else:
    print("nie")


