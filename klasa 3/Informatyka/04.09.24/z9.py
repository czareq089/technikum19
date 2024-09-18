#
#Napisz program, który wyświetli w osobnych wierszach wszystkie pary liczb bliźniaczych mniejszych
#od 1000.
#

def isprime(n):
    for i in range(2, n):
        if n%i == 0:
            return False

for j in range (1, 1000):
    if isprime(j) and isprime(j+2):
        print(f"{isprime(j)} {isprime(j+2)}")










