wsp = list(map(int, input().split()))
x = int(input())
dl = len(wsp)
w = wsp[dl-1]
for i in range(dl-2, -1, -1):
    w = w * x + wsp[i]
print(w)
