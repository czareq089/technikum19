# Zadanie 6

def isPrime(n):
    if n % 2 == 0 and n > 2:
        return False
    else:
        return True


a = int(input())
b = int(input())

if isPrime(a) and isPrime(b) and a - b == 2:
    print("tak")
else:
    print("nie")