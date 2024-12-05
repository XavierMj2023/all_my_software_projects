# Python Variable - Variable are container for storing data values.
# There is no command for declaring variable
#  is created the moment you first assign to it.
a = 5
print(type(a))
print(a)

a = "Stri"
print(type(a))
print(a)

# Variable names are case sensitive
b = 5
B = "Mango"
print(b)
print(B)

# Variable Rules
# 1
age = 5
_age = 10
print(age)
print(_age)

# 2 - SyntaxError: invalid decimal literal
# 2a = 6
# print(2a)


# Assign Multiple Values
x, y, z = "County", "Monty", "Zolo"
print(x)
print(y)
print(z)

# Unpacking
fruits = ["Kiwi", "apple", "sol"]
a, b, c = fruits
print(a)
print(b)
print(c)

print("Hi")

# Printing Multiple Values
fruits = ["Kiwi", "apple", "sol"]
a, b, c = fruits
print(a, b, c)

# Printing Multiple Values
fruits = ["Kiwi", "apple", "sol"]
a, b, c = fruits
print(a + b + c)

# Print different data type
h = 10
j = "Rani"
print(h, j)

# Global Variable and Local Variable
x = "awesome"
def myfunc():
    print("Python is " + x)
myfunc()

# Global Variable and Local Variable
print("----------------------------")
x = "awesome"
def myfunc():
    x = "fantastic"
    print("Python is " + x)
myfunc()
print("Python is " + x)

# Global Keyword
print("----------------------------")
x = "awesome"
def myfunc():
    global x
    x = "fantastic"
    print("Python is " + x)
myfunc()
print("Python is " + x)
