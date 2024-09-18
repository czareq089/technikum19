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

D = []

for i in T:
    if isprime(i) and i not in D:
        D.append(i)

for i in D:
    print(i)
print(len(D))