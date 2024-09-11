n = int(input())
T = []
czynnik = 2
while n > 1:
    while n % czynnik == 0:
        T.append(czynnik)
        n = int(n / czynnik)
    czynnik += 1

def isprime(n):
    if n < 2:
        return False
    i = 2
    while i * i <= n:
        if n % i == 0:
            return False
        i = i + 1
    return True

print(isprime(sum(T)))
