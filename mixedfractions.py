

while True:
    numerator, denomenator = [int(x) for x in input().split(' ')]
    if (numerator == 0 and denomenator == 0):
        exit(0)


    if numerator >= denomenator:
        print(str(numerator // denomenator) + " ", end='')
        print(str(numerator % denomenator) + ' / ' + str(denomenator))

    else:
        print('0 ' + str(numerator) + ' / ' + str(denomenator))
