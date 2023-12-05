#1
napis = input()
for i in range(len(napis)):
    for j in range(i+1, len(napis)):
        if napis[i] == napis[j]:
            print(napis[i+1:j])

#2
normal = input()
def od_tylu(normal):
    return normal[::-1]
print(od_tylu(normal))

#3
slowo = input()
def sprawdz(slowo):
    for i in range(1, len(slowo)):
        if slowo[i-1] > slowo[i]:
            return False
    return True
print(sprawdz(slowo))




