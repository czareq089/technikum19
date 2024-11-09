#Zadanie 1
imie = input("Podaj swoje imię: ")
nazwisko = input("Podaj swoje nazwisko: ")

with open("dane_osobowe.txt", "w") as plik:
    plik.write(imie + "\n")
    plik.write(nazwisko + "\n")

print("Dane zostały zapisane.")