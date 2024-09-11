#
# Napisz program, który sprawdzi, czy liczby całkowite dodatnie a i b podane przez użytkownika są
# liczbami zaprzyjaźnionymi. Liczby całkowite dodatnie a i b są liczbami zaprzyjaźnionymi, jeżeli są
# różne oraz suma dzielników właściwych liczby a jest równa liczbie b oraz suma dzielników właściwych
# liczby b jest równa liczbie a. Program wyświetli jeden z komunikatów „tak” lub „nie”. Przykłady liczb
# zaprzyjaźnionych:
# Dzielniki liczby 284: 1, 2, 4, 71, 142
# Dzielniki liczby 220: 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, 110
# 220 = 1 + 2 + 4 + 71 + 142
# 284 = 1 + 2 + 4 + 5 + 10 + 11 + 20 + 22 + 44 + 55 + 110
# Kolejna para liczb zaprzyjaźnionych: 1184 i 1210
#

a = 220
b = 284
Ta = []
Tb = []
if a == b:
    print("nie")
else:
    for i in range(1, a - 1):
        if a % i == 0:
            Ta.append(i)
    for j in range(1, b - 1):
        if b % j == 0:
            Tb.append(j)
    if sum(Ta) == b and sum(Tb) == a:
        print("tak")
    else:
        print("nie")
