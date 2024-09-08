# You can change the value of a specific item by referring to its key name.

# Updating the dictionary item.
dictConstruct = dict(name="Manoj", age=25, color="Black")
dictConstruct["name"] = "Xavier"
print(dictConstruct)

print("--------------------------------------------")

# The update() method will update the dictionary with the items from the given argument.
# The argument must be a dictionary, or an iterable object with key:value pairs.
# If the item does not exist, the item will be added.
dictConstruct.update({"color": "Yellow"})
print(dictConstruct)

print("--------------------------------------------")

# Adding an item to the dictionary is done by using a new index key and assigning a value to it.
dictConstruct["interview numbers"] = 25
print(dictConstruct)

print("--------------------------------------------")

# The pop() method removes the item with the specified key name.
print("This is the original list : "+format(dictConstruct))
print("Removing age key ....")
dictConstruct.pop("age")
print(dictConstruct)

print("--------------------------------------------")

# The popitem() method removes the last inserted item (in versions before 3.7, a random item is
# removed instead):
print(dictConstruct)
dictConstruct.popitem()
print(dictConstruct)

print("--------------------------------------------")

# The del keyword removes the item with the specified key name.
# The del keyword can also delete the dictionary completely.
print(dictConstruct)
del dictConstruct["name"]
print(dictConstruct)

print("--------------------------------------------")

# The clear() method empties the dictionary.
print(dictConstruct)
dictConstruct.clear()
print(dictConstruct)