A = [0, 5, 99, 3, 7, 111, 13, 4, 24, 4, 8]
n = 10

# i = 1
# while i <= n:
#     if A[i] % 2 == 0:
#         w = A[i]
#         break
#     i = i + 1
# print(w)

lewy = 1
prawy = n
while lewy < prawy:
    srodek = (lewy+prawy)/2
    if A[srodek] % 2 == 0:
        lewy = srodek + 1
    else:
        prawy = srodek
w = A[lewy]
