import sys

#To Print system version
print(sys.version)

#To print a simple hello world
print("Hello World!")

#Indentation- Case 1 - What happens if you put indentation
if 5 > 2:
    print("5 is greather than 2")

#Indentation- Case 2 - What happens if you do not put indentation - then you get error

#if 5 > 2:
#print("5 is greather than 2")


#Python Variable
x = 56
print(x)

#Python Variable - change type after they have been set.
change1 = 4
print(change1)
change1 = "Sally"
print(change1)

#Casting - Converting int to decimal
castTo = float(78)
print(castTo)

#Get The Type - <class 'int'> - use the keyword 'type'
typeData = 90
print(type(typeData))

#String variables can be declared either by using single or double quotes
str1 = 'Manoj'
str2 = "Manoj"
print("The value of str1 (Single quotes) is : "+str1)
print("The value of str2 (Double quotes) is : "+str2)

#Variable names are case-sensitive
b = "Badshah"
B = 20
print(B)
print(b)

"""
Variable Names
A variable can have a short name (like x and y) or a more descriptive name (age, carname, total_volume). Rules for Python variables:
A variable name must start with a letter or the underscore character
A variable name cannot start with a number
A variable name can only contain alpha-numeric characters and underscores (A-z, 0-9, and _ )
Variable names are case-sensitive (age, Age and AGE are three different variables)
A variable name cannot be any of the Python keywords.
"""
