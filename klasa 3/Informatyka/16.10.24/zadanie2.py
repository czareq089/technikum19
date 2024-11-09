# Zadanie 2

with open("dane_osobowe.txt", "r") as plik:
    imie = plik.readline().strip()
    nazwisko = plik.readline().strip()

print(f"Witaj {imie} {nazwisko}!")