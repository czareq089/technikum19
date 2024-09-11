n = int(input())
czynnik = 2
while n > 1:
    while n % czynnik == 0:
        print(czynnik)
        n = int(n / czynnik)
    czynnik += 1

