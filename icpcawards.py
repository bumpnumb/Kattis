

N = int(input())

universities = []

for i in range(N):
    uni, team = input().split(' ')

    if uni not in universities and len(universities) < 12:
        universities.append(uni)
        print(uni + ' ' + team)
    