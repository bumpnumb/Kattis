import math

n = int(input())

for x in range(n):
    t = input()
    l = len(t)
    d = int(math.sqrt(l))
    lines = [t[i:i+d] for i in range(0, l, d)]


    for x in range(d-1, -1, -1):
        for y in range(d):
            print(lines[y][x], end = '')
    print()



    