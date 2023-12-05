#dodawanie ulamkow
a, b = map(int,input().split("/"))
c, d = map(int,input().split("/"))


x = b
y = d 

iloczyn = x * y

while y > 0:
    x, y = y, x % y

nww = iloczyn // x

e = (nww // b) * a
f = (nww // d) * c
g = e + f

#skracanie ulamka do najprostszej postaci
x = g
y = nww

while y > 0:
    x, y = y, x % y

nww = nww // x
g = g // x

print(f"{a}/{b} + {c}/{d} = {e}/{nww} + {f}/{nww} = {g}/{nww}")


#odejmowanie ulamkow
a, b = map(int,input().split("/"))
c, d = map(int,input().split("/"))

x = b
y = d

iloczyn = x * y

while y > 0:
    x, y = y, x % y

nww = iloczyn // x

e = (nww // b) * a
f = (nww // d) * c
g = e - f

print(f"{a}/{b} - {c}/{d} = {e}/{nww} - {f}/{nww} = {g}/{nww}")








