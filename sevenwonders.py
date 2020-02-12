import math
t = input()
print(int(math.pow(t.count('T'), 2) + math.pow(t.count('C'), 2) + math.pow(t.count('G'), 2) + min(t.count('T'),t.count('C'),t.count('G')) * 7))