# Copy a Dictionary
# You cannot copy a dictionary simply by typing dict2 = dict1, because: dict2 will only be a
# reference to dict1, and changes made in dict1 will automatically also be made in dict2.

# Use the built-in Dictionary method copy().
# Another way to make a copy is to use the built-in function dict().

dict1 = {
    "name": "Manoj",
    "age": 25
}
dict2 = {
    "name": "Xavier",
    "age": 28
}
print("Using a copy()")
mydictcopy = dict1.copy()
print(mydictcopy)

print("----------------------------------")

print("Using a dict()")
mydictcopy2 = dict(dict2)
print(mydictcopy2)