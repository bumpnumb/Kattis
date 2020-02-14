

k,n = [int(x) for x in input().split(' ')]

c = 0
denied = 0
for i in range(n):
    t = input().split(' ')

    if t[0] == "enter":
        if int(t[1]) + c > k:
            denied += 1
        else:
            c += int(t[1])
    else:
        c -= int(t[1])

print(denied)


