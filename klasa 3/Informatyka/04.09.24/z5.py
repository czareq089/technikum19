# Zadanie 5

n = int(input())

suma = 0

def isPrime(n):
    if n % 2 == 0:
        return False
    else:
        return True



for i in range(2, n + 1):
    if n%i == 0 and isPrime(i):
        print(i)
