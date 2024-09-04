### Algorytm Newtona - Raphsona  ---> pseudokod

```pseudo
1. pobierz liczbę
2. x<-liczba/2
3. dopóki |x-liczba/x|> ustalona dokładność wykonuj
4. x=(x+liczba/x)/2
5. jeżeli x*x równa się liczbie zakończ działanie pętli
6. zwróć x
```


### Algorytm Newtona - Raphsona ---> python

```python
int liczba = input("Podaj liczbę: ")
x = liczba/2
while abs(x-liczba/x) > 0.0000001:
    x = (x+liczba/x)/2
    if x*x == liczba:
        break
print(x)
```