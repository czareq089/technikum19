def wyszukiwanie_binarne(T, a, n):
    lewy = 0
    prawy = n-1
    while lewy < prawy:
        srodek = (lewy + prawy)//2
        if T[srodek] < a:
            lewy = srodek + 1
        else:
            prawy = srodek
    return T[lewy] == a

