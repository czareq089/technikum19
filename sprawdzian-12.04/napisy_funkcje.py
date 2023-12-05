slowo = input("Podaj slowo: ")
def palindrom(slowo):
    return slowo == slowo[::-1]

def anagram(slowo1, slowo2):
    return sorted(slowo1) == sorted(slowo2)

slowo1 = input("Podaj slowo: ")
slowo2 = input("Podaj slowo: ")

def reszta(kwota):
    monety = [200, 100, 50, 20, 10, 5, 2, 1]
    reszta = []
    for moneta in monety:
        while kwota >= moneta:
            kwota -= moneta
            reszta.append(moneta)
    return reszta

