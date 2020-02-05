import math
t = input().split(' ')
print(math.ceil(math.sqrt(math.pow(float(t[0]),2) + math.pow(float(t[0]) / math.tan(math.radians(float(t[1]))),2))))