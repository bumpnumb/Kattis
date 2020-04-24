

while True:
    N = input()
    if (N == "0"):
        break

    Nsum = 0
    for letter in N:
        Nsum = Nsum + int(letter)
    
    i = 11
    while True:
        iStr = str(i * int(N))
        isum = 0
        for letter in iStr:
            isum = isum + int(letter)
        if isum == Nsum:
            print(str(i))
            break
        i = i+1