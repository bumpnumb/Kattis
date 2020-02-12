


t = input()
counter = [0,0,0,0]
for c in t:
    if c == '_':
        counter[0] += 1
    elif c >= 'A' and c <= 'Z':
        counter[2] += 1
    elif c >= 'a' and c <= 'z':
        counter[1] += 1
    else:
        counter[3] += 1

for row in counter:
    print(row/sum(counter))
