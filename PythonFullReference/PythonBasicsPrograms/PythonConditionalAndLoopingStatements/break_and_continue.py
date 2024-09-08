#With the break statement we can stop the loop even if the while condition is true:

number = 10
i = 1

print("----------Break Statement---------------")
while i < 6:
    print(number)
    i += 1
    if i == 3:
        break
    print(number)

print("----------Continue Statement---------------")
while i < 6:
    print(number)
    i += 1
    if i == 3:
        continue
    print(number)

print("----------No Longer condition satisfied for while Statement---------------")
while i < 10:
    print(number)
    i += 1
else:
    print("No Longer available loopy!")