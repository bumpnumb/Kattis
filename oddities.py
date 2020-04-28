n = input()
for _ in range(int(n)):
    x = int(input())
    if x % 2 == 0:
        print("" + str(x) + " is even")
    else:
        print("" + str(x) + " is odd")