
t = input().split(' ')
words = []
for word in t:
    if word in words:
        print('no')
        exit()
    words.append(word)

print('yes')