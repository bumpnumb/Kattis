import math
# import time

def sum(n):
    s = 0
    b = math.sqrt(n)

    if int(b) == b:
        s = int(b)
    
    for i in range(2,math.ceil(b),1):
        if n % i == 0:
            s += i+ (n/i)
    
    return s + 1
while (True):
    try:
        num = int(input())
        # start = time.time()
        print(num, end=' ')
        s = sum(int(num))
        if num == s:
            print('perfect')
        elif abs(s-num) <= 2:
            print('almost perfect')
        else:
            print('not perfect')

        # print(time.time() - start)
    except EOFError:
        break