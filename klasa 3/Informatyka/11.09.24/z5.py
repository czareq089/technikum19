n = int(input())

# def suma_cyfr(n):
#     suma = 0
#     while n > 0:
#         reszta = n % 10
#         suma =  suma + reszta
#         n = n//10
#     return suma


def rozdz(n):
    suma = 0
    while n > 0:
        reszta = n % 10
        suma = suma + reszta
        n = n // 10
    return suma

print(rozdz(n))

# if rozklad(n) == suma_cyfr(n):
#     print("tak")
# else:
#     print("nie")

