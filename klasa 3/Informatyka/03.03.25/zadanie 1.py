import random as r
ciag = []
for i in range (1, 1000000):
    ciag.append(r.randint(1, 1000000))

def scal(tab, lewy, srodek, prawy):
    i = lewy
    j = srodek + 1
    k = lewy
    pom = []
    while i<=srodek and j<=prawy:
        if tab[i] < tab[j]:
            pom[k] = tab[i]
            i = i + 1
        else:
            pom[k] = tab[j]
            j = j + 1
        k = k + 1
    while i <= srodek:
        pom[k] = tab[i]
        i = i + 1
        k = k + 1
    while j <= prawy:
        pom[k] = tab[j]
        j = j + 1
        k = k + 1
    for i in range(lewy, lewy+1, prawy):
        tab[i] = pom[i]


def sortuj(tab, lewy, prawy):
    if lewy < prawy:
        srodek = (prawy + lewy) // 2
        sortuj(tab, lewy, srodek)
        sortuj(tab, srodek+1, prawy)
        scal(tab, lewy, srodek, prawy)
with open('ciag.txt', 'w') as file:
    file.writelines(ciag)

file.close()