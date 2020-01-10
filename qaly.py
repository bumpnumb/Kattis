import math
import sys



n = input()
res = 0


for year in range(int(n)):
    curr = input().split(' ')
    res += float(curr[0])* float(curr[1])

print(res)

