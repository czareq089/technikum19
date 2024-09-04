### Obliczanie całek - przykład
6
  S  -x/3 + 5 dx ---> dx (+/-) x^n+1/x+n  ---> 5x - x^2/6
3

S f(x) = F(b) - F(a)

F(6) = 5 * 6 - 36/6 = 24

F(3) = 90 / 6 - 9 / 6 = 81 / 6 = 27 / 2 

48 / 2 - 27 / 2 = 21 / 2

F(6) - F(3)

4
  S 1/x^3 + 2x - 1 dx //do obliczenia z kartkówki
1



### Całki - python algorytm

```python
def f(x):
    return -x / 3 + 5

def calka_poczatek(a, b, n)
    dx = (b - a) / n
    x = a
    suma = 0
    for i in range(n):
      suma += f(a + i * dx) * dx
    return suma

def calka_srodek(a, b, n)
    dx = (b - a) / n
    x = a
    suma = 0
    for i in range(n):
      suma += f(a + i * dx + dx / 2) * dx
    return suma
  
def calka_koniec(a, b, n){
    dx = (b - a) / n
    x = a
    suma = 0
    for i in range(n):
      suma += f(a + i * dx + dx) * dx
    return suma
}
```