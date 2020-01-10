import math
import sys


inp = input()
n,d  = inp.split(' ')

res = 0

for card in range(int(n) * 4):
    c = input()
    card = c[0]
    suit  = c[1]

    if card == 'A':
        if suit == d:
            res += 11;
            continue
        res += 11;
    elif card == 'K':
        if suit == d:
            res += 4;
            continue
        res += 4;
    elif card == 'Q':
        if suit == d:
            res += 3;
            continue
        res += 3;
    elif card == 'J':
        if suit == d:
            res += 20;
            continue
        res += 2;
    elif card == 'T':
        if suit == d:
            res += 10;
            continue
        res += 10;
    elif card == '9':
        if suit == d:
            res += 14;
            continue
        res += 0;


print(res)
