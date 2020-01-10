import math
import sys



L = input()
D = input()
X = input()

if L == D == X:
    print(X)
    print(X)


for num in range(int(L), int(D) +1):
    digits = 0
    for d in (str(abs(num))):
        digits += int(d)

    if digits == int(X):
        print(num)
        break
    

for num in range(int(L), int(D) +1):
    realnum = int(D) + int(L) - num
    digits = 0
    for d in (str(abs(realnum))):
        digits += int(d)

    if digits == int(X):
        print(realnum)
        break;
