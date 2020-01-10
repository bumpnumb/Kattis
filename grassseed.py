import math


c = float(input(''))
n = int(input(''))

area = 0
for x in range(n):
    val = input('').split(' ')
    area += float(val[0]) * float(val[1])

print(area * c)
