def sito(n):
    tab = []
    for i in range(n+1):
       tab.append(0) # uzupełniam listę zerami
    tab[0] = tab[1] = 1 # liczby 0 i 1 nie są pierwsze
    i = 2 # liczba 2 jest pierwszą liczbą pierwszą
    while i*i <= n: # (**)
        if tab[i] == 0: # jeżli liczba i jest pierwsza
            for j in range(i*i, n+1, i): # (*)
                tab[j] = 1 # wykreślamy wielokrotności liczby i
        i += 1

    return tab # zwracamy listę z sitem