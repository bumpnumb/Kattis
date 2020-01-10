n = int(input(''))
c = input('').split(' ')
divider = n
upper = 0
for x in range(n):
    if c[x] == '-1':
        divider -=1
    else:
        upper += int(c[x])

print(upper/divider)