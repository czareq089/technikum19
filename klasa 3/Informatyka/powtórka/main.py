# import random
#
# # def sito(n):
# #     czy_pierwsza = [True] * (n + 1)
# #     czy_pierwsza[0] = False
# #     czy_pierwsza[1] = False
# #     p = 2
# #     while p * p <= n:
# #         if czy_pierwsza[p]:
# #             for i in range(p * p, n + 1, p):
# #                 czy_pierwsza[i] = False
# #         p += 1
# #     return czy_pierwsza
# #
# # n = sito(100)
# # for i in range(len(n)):
# #     if n[i]:
# #         print(i)
#
#
# def binary_search(T, a, n):
#     left = 0
#     right = n - 1
#     while left < right:
#         mid = (left + right) // 2
#         if T[mid] < a:
#             left = mid + 1
#         else:
#             right = mid
#     return T[left] == a
#
# def binary_search_reku(T, a, left, right):
#     if left > right:
#         return False
#     center = (left + right) // 2
#     if T[center] == a:
#         return True
#     elif T[center] < a:
#         return binary_search_reku(T, a, center + 1, right)
#     else:
#         return binary_search_reku(T, a, left, center - 1)
#
#
# # random values for testing
# l = [1, 4, 8, 9, 12, 15, 17, 19, 20, 22, 25, 27, 29, 30, 33, 35, 37, 39, 40, 42, 45, 47, 49, 50, 52, 55, 57, 59, 60, 63,
#      65, 67, 69, 70, 72, 75, 77, 79, 80, 82, 85, 87, 89, 90, 92, 95, 97, 99]
# n = len(l)
# for i in range(n):
#     print(binary_search_reku(l, l[i], 0, n - 1), end=" ")
# print()
# # random values for testing
# for i in range(n):
#
#     random_value = 1
#     while random_value in l:
#         random_value = random.randint(0, 100)
#     print(binary_search_reku(l, random_value, 0, n - 1), end=" ")




def sito(n):
    czy_pierwsza = [True]  * (n + 1)
    czy_pierwsza[0] = False
    czy_pierwsza[1] = False
    p = 2

    while p*p <= n:
        if czy_pierwsza[p]:
            for i in range(p*p, n+1, p):
                czy_pierwsza[i] = False
            p += 1
    return czy_pierwsza

def binary_search(T, szukany):
    lewy = 0
    prawy = len(T)
    while lewy < prawy:
        srodek = (lewy + prawy) // 2
        if T[srodek] < szukany:
            lewy = srodek + 1
        else:
            prawy = srodek
    return T[lewy] == szukany




















