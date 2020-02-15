import collections

N = int(input())

for i in range(N):
    G = input()

    codes = [int(x) for x in input().split(' ')]
    c = collections.Counter(codes)
    print("Case #" + str(i +1) + ": " + str(c.most_common()[len(c) - 1][0]))

