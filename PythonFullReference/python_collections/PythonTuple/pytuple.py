#   Tuples are used to store multiple items in a single variable.
#   A tuple is a collection which is ordered and unchangeable.
#   Tuples are written with round brackets.
#   Tuple items are ordered, unchangeable, and allow duplicate values.
#   Tuple items are indexed, the first item has index [0], the second item has index [1] etc.

#   Create a Tuple
tup = ("Desar", "Munda", "Ballu")
print(tup)
print(type(tup))

# Unchangeable
# Tuples are unchangeable, meaning that we cannot change, add or remove items after the tuple has
# been created.

# Tuple Length
print(len(tup))

print("----------------------")

# Create Tuple With One Item
# To create a tuple with only one item, you have to add a comma after the item,
# otherwise Python will not recognize it as a tuple
anotherTuple = ("apple")
print(anotherTuple)
print(type(anotherTuple))

print("----------------------")

anotherTuple2 = ("apple",)
print(anotherTuple2)
print(type(anotherTuple2))

# Tuple items can be of any data type. A tuple can contain different data types.
# From Python's perspective, tuples are defined as objects with the data type 'tuple'.

print("----------------------")

# The tuple() Constructor
# It is also possible to use the tuple() constructor to make a tuple.
roundTuple = tuple(("MJ", "CH", "CJ"))
print(roundTuple)
print(type(roundTuple))

print("----------------------")

#  Access Tuple Items
#  You can access tuple items by referring to the index number, inside square brackets.
#  The first item has index 0.
print(roundTuple[2])

print("----------------------")

#   Negative Indexing
#   Negative indexing means start from the end. -1 refers to the last item,
#   -2 refers to the second last item etc.
print(roundTuple[-2])

print("----------------------")

#   Change Tuple Values
#   Once a tuple is created, you cannot change its values.
#   Tuples are unchangeable, or immutable as it also is called.
#   You can convert the tuple into a list, change the list, and convert the list back into a tuple.

# Tuple
tupledemo = ("Sona Kiya", "Baarish", "Lattu Da Des")
tupledemostr = "The Tuple is {tupledata} and the type is : {tupletype}"
print(tupledemostr.format(tupledata=tupledemo, tupletype=type(tupledemo)))

# Tuple to List
listConvert = list(tupledemo)
listdemostr = "The Tuple converted to list is {listdata} and the type is : {listtype}"
print(listdemostr.format(listdata=listConvert, listtype=type(listConvert)))

# Update List
listConvert[1] = "Rain Is Wonderland"
print(listConvert)

# Convert to back to tuple
listConvertBack = tuple(listConvert)
listdemostrback = "The list converted to tuple back is {tdata} and the type is : {ttype}"
print(listdemostrback.format(tdata=listConvertBack, ttype=type(listConvertBack)))

print("----------------------")

# Remove Items
# Convert the tuple into a list, remove item  and convert it back into a tuple.
# Or you can delete the tuple completely.
# The del keyword can delete the tuple completely.

# Unpacking a Tuple
# When we create a tuple, we normally assign values to it. This is called "packing" a tuple.

itparks = ("Manyata Tech Park", "Henge Park", "Helios Buisness Park")
print(itparks)
print(type(itparks))

# But, in Python, we are also allowed to extract the values back into variables.
# This is called "unpacking".

(itpark1, itpark2, itpark3) = itparks
print("IT PARK 1 : "+itpark1)
print("IT PARK 2 : "+itpark2)
print("IT PARK 3 : "+itpark3)

print("----------------------")

# Using Asterisk *
# If the number of variables is less than the number of values, you can add an * to the variable
# name and the values will be assigned to the variable as a list.

fruits = ("apple", "banana", "cherry", "strawberry", "raspberry")
(green, yellow, *red) = fruits
print("Fruit 1 : "+green)
print("Fruit 2 : "+yellow)
print("Fruit 3 : "+format(red))

print("----------------------")

# If the asterisk is added to another variable name than the last, Python will assign values
# to the variable until the number of values left matches the number of variables left.
fruits2 = ("apple", "banana", "cherry", "strawberry", "raspberry")
(green, *yellow, red) = fruits2
print("Fruit 1 : "+green)
print("Fruit 2 : "+format(yellow))
print("Fruit 3 : "+red)

print("----------------------")

# Loop Through a Tuple
# You can loop through the tuple items by using a for loop.
for frus in fruits2:
    print(frus)