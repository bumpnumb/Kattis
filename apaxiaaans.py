t = input()
i = 1
while i < len(t):
    if t[i] == t[i-1]:
        t = t[:i-1] + t[i:]
        continue
    i+=1
print(t)