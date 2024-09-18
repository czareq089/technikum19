# Zadanie 3

n = int(input())
T = []
for i in range(1, n//2+1):
    if n % i == 0:
        T.append(i)
T.append(n)
print(sum(T))