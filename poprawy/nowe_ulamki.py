#utworzenie nowych ułamków
a, b = map(int,input().split("/"))
c, d = map(int,input().split("/"))


#dodanie ułamków
e = a * d + b * c
f = b * d

#skrócenie ułamków
def nwd(a, b):
    while b != 0:
        a, b = b, a % b
    return a

g = nwd(e, f)
e = e // g
f = f // g

#sprawdzenie czy ułamek jest równy 1
if e == f:
    print(1)
else:
    print(f"{e}/{f}")

#zamiana wyniku na liczbę mieszaną
if e > f:
    print(f"{e // f} {e % f}/{f}")


#użycie funkcji gcd z biblioteki math
from math import gcd
a, b = map(int,input().split("/"))
c, d = map(int,input().split("/"))

e = a * d + b * c
f = b * d

g = gcd(e, f)
e = e // g
f = f // g

if e == f:
    print(1)
else:
    print(f"{e}/{f}")

if e > f:
    print(f"{e // f} {e % f}/{f}")

#użycie funkcji Fraction z biblioteki fractions
from fractions import Fraction
a, b = map(int,input().split("/"))
c, d = map(int,input().split("/"))

e = a * d + b * c
f = b * d

g = Fraction(e, f)

if g == 1:
    print(1)
else:
    print(g)

if g > 1:
    print(f"{g // 1} {g % 1}")


