import random as r
liczby = []
for i in range(100):
    liczby.append(r.randint(1, 1000))

def minimum_maksimum(liczby):
    if liczby[0] < liczby[1]:
        minimum = liczby[0]
        maksimum = liczby[1]
    else:
        minimum = liczby[1]
        maksimum = liczby[0]
    for i in range(2, len(liczby)-2, 2):
        if liczby[i] < liczby[i+1]:
            if liczby[i] < minimum:
                minimum = liczby[i]
            if liczby[i+1] > maksimum:
                maksimum = liczby[i+1]
        else:
            if liczby[i+1] < minimum:
                minimum = liczby[i+1]
            if liczby[i+1] > maksimum:
                maksimum = liczby[i+1]
    return(minimum, maksimum)

print(minimum_maksimum(liczby))