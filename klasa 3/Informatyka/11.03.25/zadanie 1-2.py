import random as r
liczby = []
for i in range(100):
    liczby.append(r.randint(1, 1000))

def minimum_maksimum(liczby):
    minimum = liczby[0]
    maksimum = liczby[0]
    wykonania = 0
    for l in liczby:
        if l < minimum:
            minimum = l
            wykonania += 1
        if maksimum < l:
            maksimum = l
            wykonania += 1
    print(wykonania)
    return (minimum, maksimum)

print(minimum_maksimum(liczby))