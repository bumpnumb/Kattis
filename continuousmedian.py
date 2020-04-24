import statistics
import math
T = int(input())

for i in range(T):
    N = int(input())
    val = [int(x) for x in input().split(' ')]
    
    # first median is always first value
    s = val[0]
    index = 0

    for j in range(1,N+1):
        print("S =" + str(s) + " index =" + str(index))
        inc = False

        if val[j] <= val[index]:
            index += 1
            inc = True
        if ((j+1)%2 == 0):# +1 because we start at 1, but we are at index 2
            s += math.floor((val[index] + val[index+1])/2)
            if (not inc):
                index += 1
        else:
            s += val[index]




    print(s)