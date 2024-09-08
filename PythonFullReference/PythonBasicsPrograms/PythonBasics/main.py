import sys

# To Print system version
print(sys.version)

# To print a simple hello world
print("Hello World!")

# Indentation- Case 1 - What happens if you put indentation
if 5 > 2:
    print("5 is greather than 2")

# Indentation- Case 2 - What happens if you do not put indentation - then you get error

# if 5 > 2:
# print("5 is greather than 2")


# Python Variable
x = 56
print(x)

# Python Variable - change type after they have been set.
change1 = 4
print(change1)
change1 = "Sally"
print(change1)

# Casting - Converting int to decimal - constructor functions like float(),str(),int() e.t.c
castTo = float(78)
print(castTo)

# Get The Type - <class 'int'> - use the keyword 'type'
typeData = 90
print(type(typeData))

# String variables can be declared either by using single or double quotes
str1 = 'Manoj'
str2 = "Manoj"
print("The value of str1 (Single quotes) is : " + str1)
print("The value of str2 (Double quotes) is : " + str2)

"""
Variable Names
A variable can have a short name (like x and y) or a more descriptive name (age, carname, total_volume). 

Rules for Python variables:
A variable name must start with a letter or the underscore character
A variable name cannot start with a number
A variable name can only contain alpha-numeric characters and underscores (A-z, 0-9, and _ )
Variable names are case-sensitive (age, Age and AGE are three different variables)
A variable name cannot be any of the Python keywords.
"""

# Variable names are case-sensitive
b = "Badshah"
B = 20
print(B)
print(b)

# Many Values to Multiple Variables
# Python allows you to assign values to multiple variables in one line
fruit1, fruit2, fruit3 = "Watermelon", "Apple", "Grapes"
print("Fruit 1 : " + fruit1)
print("Fruit 2 : " + fruit2)
print("Fruit 3 : " + fruit3)

# One Value to Multiple Variables
# Assign the same value to multiple variables in one line:
fruit11 = fruit21 = fruit31 = "Watermelon"
print("Fruit 1 : " + fruit11)
print("Fruit 2 : " + fruit21)
print("Fruit 3 : " + fruit31)

# --------------------
# Unpack a collection
# --------------------
# If you have a collection of values in a list, tuple etc.
# Python allows you to extract the values into variables. This is called unpacking.
cars = ["Mercedes", "Volvo", "Renault"]
car1, car2, car3 = cars
print("The Cars are : " + car1)
print("The Cars are : " + car2)
print("The Cars are : " + car3)

# Output multiple variables -  you output multiple variables, separated by a comma or '+'
s1 = "Python "
s2 = "can be used for"
s3 = "AI and ML"
print("Using Comma : " + s1, s2, s3)
print("Using + : " + s1 + s2 + s3)

"""
Global Variables
----------------
Variables that are created outside of a function  are known as global variables.
Global variables can be used by everyone, both inside of functions and outside.
"""
#Case 1:
golbtest = "makeara"
def goltes():
    print("The Value is : "+golbtest)
goltes()

print("----------------------------------------")

#Case 2:
golbtest = "makeara"
def goltes():
    golbtest = "manoja"
    print("The Value is : "+golbtest)
goltes()
print("the Value is : "+golbtest)


print("----------------------------------------")

"""
Global Keyword
-------------------------
#Normally, when you create a variable inside a function, that variable is local, and can only be used 
# inside that function.
# To create a global variable inside a function, you can use the global keyword.
"""
golbtest1 = "makeara"
def goltes():
    global golbtest1
    golbtest1 = "manoja"
    print("The Value is : "+golbtest1)
goltes()
print("the Value is : "+golbtest1)

