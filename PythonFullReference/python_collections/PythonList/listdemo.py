# Lists are used to store multiple items in a single variable.

# Lists are one of 4 built-in data types in Python used to store collections of data, the other 3 are
# Tuple, Set, and Dictionary, all with different qualities and usage.

# Lists are created using square brackets.
# List are ordered, changeable, and allow duplicate values.
# They are indexed, the first item has index [0], the second item has index [1] etc.

# Create a List
# -------------------
listCreate = ["Curry", "Rice", "Bonda"]
print(listCreate)
print(type(listCreate))

# Ordered
# -------------------
# When we say that lists are ordered, it means that the items have a defined order,
# and that order will not change.
# If you add new items to a list, the new items will be placed at the end of the list.
# There are some list methods that will change the order, but in general: the order of the items will
# not change.
listOrdered = ["Curry", "Rice", "Bonda", "Sweet"]

# Changeable
# -------------------
# The list is changeable, meaning that we can change, add, and remove items in a list after it has been
# created.
listChangeable = ["Curry", "Rice", "Bonda", "Sweet"]

# Allow duplicate values
# ------------------------
# Since lists are indexed, lists can have items with the same value
listDuplicateAllow = ["Curry", "Rice", "Bonda", "Sweet", "sweet", "Rice"]
print(listDuplicateAllow)

# List Length - To determine how many items a list has, use the len() function
# ------------------------
listLength = ["Curry", "Rice", "Bonda", "Sweet", "sweet", "Rice"]
print(len(listLength))

# List item can be of any datatype
listdata1 = [1, 2, 3, 3, 8, 4]
listdata2 = ["Sagar", "River", "Lake"]
listdata3 = [20.6, 67.8, 88.9]
print(listdata1)
print(listdata2)
print(listdata3)

# Type -  lists are defined as objects with the data type 'list':
print(type(listdata3))

# list() Constructor
listConstruct = list(("Sagar", "Bda", "Tiy"))
print(listConstruct)

# Access List item - List items are indexed and you can access them by referring to the index number
listdataaccess = ["Sagar", "River", "Lake"]
print(listdataaccess[1])

# Access List item - Negative indexing
listdataaccess_ni = ["Sagar", "River", "Lake"]
print(listdataaccess_ni[-1])

# Range of Indexes - Refer String Slicing
listRangeIndex = ["Curry", "Rice", "Bonda", "Sweet", "sweet", "Rice"]
print(listRangeIndex[1:3])
print(listRangeIndex[-3:-1])

# To Check if item exists
if "Bonda" in listRangeIndex:
    print("Bonda exists in buffet")
else:
    print("Bomda does not exists in buffet")

# Change Item Value - To change the value of a specific item, refer to the index number.
print("-------------- Changing the Value ------------------")
print(listRangeIndex)
listRangeIndex[4] = "Rasgulla"
print(listRangeIndex)

# Change a Range of Item Value - To change the value of items within a specific range, define a list
# with the new values, and refer to the range of index numbers where you want to
# insert the new values.
print("-------------- Changing the List of Value ------------------")
print(listRangeIndex)
listRangeIndex[1:3] = ["Somali", "Sona Papadi"]
print(listRangeIndex)

# Insert() -  inserts an item at the specified index
print("-------- Inserting the list item----------")
listRangeIndex.insert(4, "Sweet")
print(listRangeIndex)

# Append() - To add an item to the end of the list.
print("--------Inserting the item at the end--------")
listRangeIndex.append("TigerSomali")
print(listRangeIndex)

# extend() - To append elements from another list to the current list.
#           you can add any iterable object (tuples, sets, dictionaries etc.).
listextra = ["Bheema", "Sugy", "Makola"]
print("--------Inserting the list at the end--------")
listRangeIndex.extend(listextra)
print(listRangeIndex)

# remove() method removes the specified item
# If there are more than one item with the specified value, the remove() method removes the first
# occurence
print("--------Removing item --------")
listRangeIndex.remove("Sweet")
print(listRangeIndex)

# pop()- removes the specified index.
print("--------Removing item for specified index --------")
listRangeIndex.pop(6)
print(listRangeIndex)
print("--------Removing item for no index --------")
listRangeIndex.pop()
print(listRangeIndex)

# del keyword - removes the specified index/ complete list.
print("--------Removing item for no index using del()--------")
del listRangeIndex[5]
print(listRangeIndex)

# clear() -  empties the list.The list still remains, but it has no content.
print("--------Clearing the list--------")
listRangeIndex.clear()
print(listRangeIndex)

# Loop through the list
print("------Looping through list------")
listLoo = ["Alpha", "Beta", "Gamma"]
for looplistitem in listLoo:
    print(looplistitem)

# Loop Through the Index Numbers - create a suitable iterable
print("------Loop Through the Index Numbers------")
for looplistitem in range(len(listLoo)):
    print(listLoo[looplistitem])

# List Comprehension - List comprehension offers a shorter syntax when you want to create a new list
# based on the values of an existing list.

# Syntax - newlist = [expression for item in iterable if condition == True]

# The condition is like a filter that only accepts the items that valuate to True.
# The condition is optional and can be omitted.
# The iterable can be any iterable object, like a list, tuple, set etc.
# The expression is the current item in the iteration, but it is also the outcome, which you can
# manipulate before it ends up like a list item in the new list:

print("---- Without List Comprehension ----------")
listLoo2 = ["Alpha", "Aeta", "Aamma", "Sigma", "Tigala"]
listLoo2_newlist = []
for li in listLoo2:
    if "g" in li:
        listLoo2_newlist.append(li)
print(listLoo2_newlist)

# But with List compression
print("---- With List Comprehension ----------")
listLoo3 = ["Alpha", "Aeta", "Aamma", "Sigma", "Tigala"]
listLoo3_newlist = [li for li in listLoo3 if "g" in li]
print(listLoo3_newlist)

# sort() - Sort the list - that will sort the list alphanumerically, ascending, by default
print("------Sorting list in ascending---------")
thislist = ["orange", "mango", "kiwi", "pineapple", "banana"]
thislist.sort()
print(thislist)

# sort() - Sort the list - that will sort the list alphanumerically, descending
# To sort descending, use the keyword argument reverse = True.
print("------Sorting list in descending---------")
thislist.sort(reverse=True)
print(thislist)

# Customize Sort Function
# You can also customize your own function by using the keyword argument key = function.
print("----Customize Sort function-----------")


def sortMyFunc(n):
    return abs(n - 40)


thislist2 = [100, 60, 56, 45, 30]
thislist2.sort(key=sortMyFunc)
print(thislist2)

# Case Insensitive Sort
# It is case-sensitive, resulting in all capital letters being sorted before lower case
# letters.
print("--------Case Insensitive Sort-------")
Dthislist = ["banana", "Orange", "Kiwi", "cherry"]
Dthislist.sort()
print(Dthislist)

# Reverse Order -  regardless of the alphabet
print("----------Reverse List ------")
Dthislist.reverse()
print(Dthislist)

# Copy a list - list()/copy()
print("----------Copy List ------")
lis1 = [1, 90, 69]
newlist_copy = lis1.copy()
newlist_list = lis1.copy()
print(newlist_copy)
print(newlist_list)

#Join the list using + operator
print("-------Joining the list using + operator -----------")
newlist_plus_join = newlist_list + newlist_copy
print(newlist_plus_join)