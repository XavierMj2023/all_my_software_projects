import datetime

# Dictionaries are used to store data values in key:value pairs.
# A dictionary is a collection which is ordered*, changeable and do not allow duplicates.
# Dictionaries are written with curly brackets, and have keys and values.
# Dictionary items are presented in key:value pairs, and can be referred to by using the key name.

# Create a Dictionary
todayinterview1 = {
    "ilog": 6001,
    "address": "18, 4th Floor, Guava Garden, KHB Colony, 5th Block, Koramangala, Bengaluru, "
               "Karnataka 560095",
    "build_name": "Enzyme JNC Business Center",
    "company": "Shadowfax Technologies",
    "recruiter": "Bharathi",
    "timings": "10 to 12",
    "status": "opened",
    "date": datetime.datetime(2024, 5, 4)
}
print(todayinterview1)

print("------------------------------------------------------")

# Dictionaries cannot have two items with the same key. Duplicate values will overwrite existing values.
todayinterview2 = {
    "ilog": 6001,
    "ilog": 6002,
    "address": "18, 4th Floor, Guava Garden, KHB Colony, 5th Block, Koramangala, Bengaluru, "
               "Karnataka 560095",
    "build_name": "Enzyme JNC Business Center",
    "company": "Shadowfax Technologies",
    "recruiter": "Bharathi",
    "timings": "10 to 12",
    "status": "opened",
    "date": datetime.datetime(2024, 5, 4)
}
print(todayinterview2)

print("------------------------------------------------------")

# To determine how many items a dictionary has, use the len() function.
# Duplicates keys are ignored.
print(len(todayinterview2))

print("------------------------------------------------------")

# The values in dictionary items can be of any data type.
todayinterview3 = {
    "ilog": 6001,
    "address": "18, 4th Floor, Guava Garden, KHB Colony, 5th Block, Koramangala, Bengaluru, "
               "Karnataka 560095",
    "build_name": "Enzyme JNC Business Center",
    "company": "Shadowfax Technologies",
    "recruiter": "Bharathi",
    "timings": ["10 to 12", "12 to 1", "1 to 2"],
    "status": True,
    "date": datetime.datetime(2024, 5, 4),
}
print(todayinterview3)

print("------------------------------------------------------")

# From Python's perspective, dictionaries are defined as objects with the data type 'dict'.
print(type(todayinterview2))

print("------------------------------------------------------")

# The dict() Constructor
dictConstruct = dict(name="Manoj", age=25, color="Black")
print(dictConstruct)

print("------------------------------------------------------")

# You can access the items of a dictionary by referring to its key name, inside square brackets.
print(dictConstruct['name'])

print("------------------------------------------------------")

# There is also a method called get() that will give you the same result.
print(dictConstruct.get("color"))

print("------------------------------------------------------")

# The keys() method will return a list of all the keys in the dictionary.
# The list of the keys is a view of the dictionary, meaning that any changes done to the dictionary
# will be reflected in the keys list.
dictkeys = dictConstruct.keys()
print(dictkeys)

print("------------------------------------------------------")

# The values() method will return a list of all the values in the dictionary.
# The list of the values is a view of the dictionary, meaning that any changes done to the
# dictionary will be reflected in the values list.
dictValues = dictConstruct.values()
print(dictValues)

print("------------------------------------------------------")

# The items() method will return each item in a dictionary, as tuples in a list.
# The returned list is a view of the items of the dictionary, meaning that any changes done to the
# dictionary will be reflected in the items list.
dictItems = dictConstruct.items()
print(dictItems)