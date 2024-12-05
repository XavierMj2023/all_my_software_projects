# A set is a collection which is unordered, unchangeable*, and unindexed.
# Set items are unchangeable, but you can remove items and add new items.
# Sets are written with curly brackets.
# Sets are unordered, so you cannot be sure in which order the items will appear.
# Set items are unordered, unchangeable, and do not allow duplicate values.
# Set items can appear in a different order every time you use them, and cannot be referred to by index
# or key.
# The values True and 1 are considered the same value in sets, and are treated as duplicates.
# The values False and 0 are considered the same value in sets, and are treated as duplicates.

# Create a Set
createSet = {"Non Voice", "Voice", "HR Fresher"}
print(createSet)
print(type(createSet))

print("------------------")

# Duplicate values will be ignored. Sets cannot have two items with the same value.
dupset = {"Non Voice", "Voice", "HR Fresher", "Voice", "voice"}
print(dupset)

print("------------------")

# The values True and 1 are considered the same value in sets, and are treated as duplicates.
dupbool = {"Pitbull", "Minus", "Zero", "Sal Key Ray", True, 1}
print(dupbool)
# The values False and 0 are considered the same value in sets, and are treated as duplicates.
dupbool2 = {"Pitbull", "Minus", "Zero", "Sal Key Ray", False, 0}
print(dupbool2)

print("------------------")

# Get the Length of a Set.
print(len(dupbool2))

# Set items can be of any data type. A set can contain different data types.

print("------------------")

# The set() Constructor
# It is also possible to use the set() constructor to make a set.
thset = set(("Tiger", "Lion", "Wolf", "Fox"))
print(thset)
print(type(thset))

print("------------------")

# Access Items
# You cannot access items in a set by referring to an index or a key.
# But you can loop through the set items using a for loop, or ask if a specified value is present
# in a set, by using the in keyword.
for tset in thset:
    print(tset)

print("------------------")

# Check if item is present in set
# Case 1: Lowercase - It is case-sensitive
print("lion" in thset)
# Case 2: Spaces Lowercase - Ignores space
print("lion " in thset)
# Case 3: Finding the item
print("Lion" in thset)
# Case 4: Spaces Uppercase - Not found because space is there
print("Lion " in thset)

print("------------------")

# To add one item to a set use the add() method.
setadddemo = {"7U", "One Up"}
print(setadddemo)
setadddemo.add("Master 89")
print(setadddemo)

print("------------------")

# To add items from another set into the current set, use the update() method.
# The object in the update() method does not have to be a set, it can be any iterable object
# tuples, lists, dictionaries etc.
setadddemo2 = {"7U", "One Up"}
setadddemo3 = {"8U", "Two Up"}
setadddemo2.update(setadddemo3)
print(setadddemo2)

print("------------------")

# To remove an item in a set, use the remove(), or the discard() method.
# If the item to remove does not exist, remove() will raise an error.
# If the item to remove does not exist, discard() will NOT raise an error.
setadddemo2.remove("Two Up")
print(setadddemo2)

print("------------------")

setadddemo2.discard("One Up")
print(setadddemo2)

print("------------------")

# You can also use the pop() method to remove an item.
# But this method will remove a random item, so you cannot be sure what item that gets removed.
# The return value of the pop() method is the removed item.
print(setadddemo2)
setadddemo2.pop()
print(setadddemo2)

print("------------------")

# The clear() method empties the set.
print(setadddemo2)
setadddemo2.clear()
print(setadddemo2)

print("------------------")

# The del keyword will delete the set completely.
print(setadddemo2)
del setadddemo2
print(setadddemo2)