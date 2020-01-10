zero =  ["+---+", "|   |", "|   |", "+   +", "|   |", "|   |", "+---+"]
one =   ["    +", "    |", "    |", "    +", "    |", "    |", "    +"]
two =   ["+---+", "    |", "    |", "+---+", "|    ", "|    ", "+---+"]
three = ["+---+", "    |", "    |", "+---+", "    |", "    |", "+---+"]
four =  ["+   +", "|   |", "|   |", "+---+", "    |", "    |", "    +"]
five =  ["+---+", "|    ", "|    ", "+---+", "    |", "    |", "+---+"]
six =   ["+---+", "|    ", "|    ", "+---+", "|   |", "|   |", "+---+"]
seven = ["+---+", "    |", "    |", "    +", "    |", "    |", "    +"]
eight = ["+---+", "|   |", "|   |", "+---+", "|   |", "|   |", "+---+"]
nine =  ["+---+", "|   |", "|   |", "+---+", "    |", "    |", "+---+"]
colon = [" "    , " "    , "o"    , " "    , "o"    , " "    , " "    ]


def PrintNumbers(literals):
    for y in range(7):
        for x in range(5):
            print(literals[x][y], end = '')
            if x != 4:
                print("  ", end = '')
        print()
    print()
    print()


def GetLiterals(number):
    literals = []
    for i in range(len(number)):
        if number[i] == "0":
            literals.append(zero)
        elif number[i] == "1":
            literals.append(one)
        elif number[i] == "2":
            literals.append(two)
        elif number[i] == "3":
            literals.append(three)
        elif number[i] == "4":
            literals.append(four)
        elif number[i] == "5":
            literals.append(five)
        elif number[i] == "6":
            literals.append(six)
        elif number[i] == "7":
            literals.append(seven)
        elif number[i] == "8":
            literals.append(eight)
        elif number[i] == "9":
            literals.append(nine)
        elif number[i] == ":":
            literals.append(colon)
    return literals


while True:
    s = input()
    if s == "end":
        print("end")
        break
    PrintNumbers(GetLiterals(s))
       