import math
import sys

best = 0
bp = 0

for row in range(5):
    votes = input().split(' ')
    score = 0
    for vote in votes:
       score += int(vote)

    if score > best:
        best = score
        bp = row

print(bp+1 , best)
