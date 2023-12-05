#Szybkie sortowanie Hoare'a

def hoare_partition(A, p, r):
    x = A[p]
    i = p - 1
    j = r + 1
    while True:
        while True:
            j -= 1
            if A[j] <= x:
                break
        while True:
            i += 1
            if A[i] >= x:
                break
        if i < j:
            A[i], A[j] = A[j], A[i]
        else:
            return j

def hoare_quicksort(A, p, r):
    if p < r:
        q = hoare_partition(A, p, r)
        hoare_quicksort(A, p, q)
        hoare_quicksort(A, q + 1, r)

def main():
    A = [2, 8, 7, 1, 3, 5, 6, 4]
    hoare_quicksort(A, 0, len(A) - 1)
    print(A)

if __name__ == '__main__':
    main()

# Output:
# [1, 2, 3, 4, 5, 6, 7, 8]
