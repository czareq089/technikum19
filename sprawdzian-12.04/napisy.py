# #Program zliczający wystąpienia litery w napisie
napis = input()
litera = input()
suma = 0

for i in range (len(napis)):
    if napis[i] == litera:
        suma += 1
print ("Liczba wystąpień: ", suma)

# #Odwracanie napisu
napis = input()
for i in range(len(napis) - 1, -1, -1):
    print(napis[i], end="")

#Wyraz z liter występujących więcej niż raz
napis = input()
for i in range(len(napis)):
    if napis.count(napis[i]) > 1:
        print(napis[i], end="")

#Usuwanie białych znaków
napis = input()
for i in range(len(napis)):
    if napis[i] != " " or napis[i] != "\t":
        print(napis[i], end="")


#Wykrywanie wielkich liter
napis = input()
for i in range(len(napis)):
    if napis[i] == napis[i].upper():
        print(napis[i], end="")

#Wypisywanie liter w ilości zależnej od indeksu
napis = input()
for i in range(len(napis)):
    print(napis[i] * i)

#Złączenie dwóch napisów
napis1 = input()
napis2 = input()
print (napis1 + napis2)
