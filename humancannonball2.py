import math

N = int(input())

for i in range(N):
    v0, theta, x1, h1, h2 = [float(x) for x in input().split(' ')]

    r = math.radians(theta)
    t = x1 / (v0 * math.cos(r))
    y = (v0 * t * math.sin(r)) - (0.5*9.81*t*t)

    if h1 + 1 <= y <= h2 -1:
        print("safe")
    else:
        print("Not Safe")
