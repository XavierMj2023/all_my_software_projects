# A dictionary can contain dictionaries, this is called nested dictionaries.

# Create a Nested Dictionary
myfamily = {
    "child1": {
        "name": "Emil",
        "year": 2004
    },
    "child2": {
        "name": "Tobias",
        "year": 2007
    },
    "child3": {
        "name": "Linus",
        "year": 2011
    }
}
print(myfamily)

print("-----------------------------------------------")

# Create three dictionaries, then create one dictionary that will contain the other three dictionaries.
child1 = {
    "name": "Emil",
    "year": 2004
}
child2 = {
    "name": "Tobias",
    "year": 2007
}
child3 = {
    "name": "Linus",
    "year": 2011
}

myfamily = {
    "child1": child1,
    "child2": child2,
    "child3": child3
}
print(myfamily)

print("-----------------------------------------------")
# Access Items in Nested Dictionaries
# To access items from a nested dictionary, you use the name of the dictionaries,
# starting with the outer dictionary.
print(myfamily["child2"]["name"])

print("-----------------------------------------------")

# Loop Through Nested Dictionaries
for x, obj in myfamily.items():
    print(x)
    for y in obj:
        print(y + ':', obj[y])
