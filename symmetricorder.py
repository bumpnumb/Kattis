

setCounter = 0
while True:
    setCounter += 1
    number = int(input())
    if number == 0:
        break

    namelist = [None]*number
    start = 0
    end = number -1


    for i in range(number):
        name = input()
        if i%2 == 0:
            namelist[start] = name
            start += 1
        else:
            namelist[end] = name
            end -= 1


    print("SET " + str(setCounter))
    for n in namelist:
        print(n)
