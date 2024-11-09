with open("slowa.txt") as slowa:
    slowa = slowa.read().split()

    for line in slowa:
        nrslowa = 1
        print(f"{nrslowa}: {line}")
        nrslowa += 1
