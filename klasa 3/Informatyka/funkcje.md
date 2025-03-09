### **1. Sortowanie przez scalanie (Merge Sort)**  
Rekurencyjnie dzielimy listę na pół, sortujemy podlisty i scalamy:  
```python
def merge_sort(arr):
    if len(arr) <= 1:
        return arr
    mid = len(arr) // 2
    left = merge_sort(arr[:mid])
    right = merge_sort(arr[mid:])
    return merge(left, right)

def merge(left, right):
    result = []
    i = j = 0
    while i < len(left) and j < len(right):
        if left[i] <= right[j]:
            result.append(left[i])
            i += 1
        else:
            result.append(right[j])
            j += 1
    result.extend(left[i:])
    result.extend(right[j:])
    return result
```

**Użycie:**
```python
lista = [5, 4, 1, 8, 2]
print(merge_sort(lista))
```

---

### **2. Schemat Hornera (Obliczanie wartości wielomianu)**
Zamiast potęgowania i mnożenia dla każdego wyrazu, Horner przekształca wielomian do formy zoptymalizowanej:  
```python
def horner(coeffs, x):
    result = 0
    for coef in reversed(coeffs):
        result = result * x + coef
    return result
```

**Użycie:**
```python
# Wielomian 2x³ + 3x² - x + 5 dla x = 2
wspolczynniki = [5, -1, 3, 2]
x = 2
print(horner(wspolczynniki, x))  # Wynik: 27
```

---

### **3. Operacje na plikach (Odczyt, Zapis)**
**Odczyt całej zawartości:**
```python
with open("plik.txt", "r") as f:
    zawartosc = f.read()
```

**Odczyt linii jako lista:**
```python
with open("plik.txt", "r") as f:
    linie = f.readlines()
```

**Zapis do pliku:**
```python
with open("wynik.txt", "w") as f:
    f.write("To jest wynik\n")
```

---

### **4. Wyszukiwanie podciągów (Subciągi)**
**Generowanie wszystkich podciągów spójnych:**
```python
def podciagi_spojne(arr):
    n = len(arr)
    for i in range(n):
        for j in range(i + 1, n + 1):
            print(arr[i:j])
```

**Użycie:**
```python
podciagi_spojne([3, 2, 5, 1])
```

---

### **5. Sprawdzanie monotoniczności ciągu**  
**Ciąg rosnący:**
```python
def czy_rosnacy(arr):
    return all(arr[i] < arr[i+1] for i in range(len(arr) - 1))
```

**Ciąg malejący:**
```python
def czy_malejacy(arr):
    return all(arr[i] > arr[i+1] for i in range(len(arr) - 1))
```

**Użycie:**
```python
print(czy_rosnacy([1, 2, 3, 4]))  # tak
print(czy_malejacy([4, 3, 2, 1]))  # tak
```

---

### **6. Zamiana liczby binarnej na dziesiętną (Schemat Hornera)**
```python
def bin_to_dec(bin_str):
    return sum(int(bit) * 2**i for i, bit in enumerate(reversed(bin_str)))
```

**Użycie:**
```python
print(bin_to_dec("1011"))  # Wynik: 11
```

---

### **7. Maksymalna suma podciągu (Kadane’s Algorithm)**
**Znajduje największą sumę spójnego podciągu.**
```python
def max_subarray_sum(arr):
    max_sum = arr[0]
    current_sum = 0
    for num in arr:
        current_sum = max(num, current_sum + num)
        max_sum = max(max_sum, current_sum)
    return max_sum
```

**Użycie:**
```python
print(max_subarray_sum([2, 3, -4, 2, -5, 5, 2, -4]))  # Wynik: 7
```

---