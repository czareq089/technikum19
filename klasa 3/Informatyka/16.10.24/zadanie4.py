#Zadanie 4
def Policz_Ilość_Parzystych_ciągów(filename):
    with open(filename, 'r') as file:
        count = 0
        for line in file:
            numbers = list(map(int, line.split()))
            total_sum = sum(numbers)
            if total_sum % 2 == 0:
                count += 1
        return count
filename = 'ciagi.txt'
result = Policz_Ilość_Parzystych_ciągów(filename)
print(f'Liczba ciągów o parzystej sumie wyrazów: {result}')