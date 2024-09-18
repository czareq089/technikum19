n = int(input())
T = []
czynnik = 2
while n > 1:
    while n % czynnik == 0:
        T.append(czynnik)
        n = int(n / czynnik)
    czynnik += 1

print(sum(T))