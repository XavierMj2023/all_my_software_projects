# When looping through a dictionary, the return value are the keys of the dictionary,
# but there are methods to return the values as well.
# You can loop through a dictionary by using a for loop.

# Loop to get the keys
dictConstruct2 = dict(name="Manoj", age=25, color="Black")
for loopTheValue in dictConstruct2:
    print(loopTheValue)

print("--------------------------------")

# Loop to get the values
for loopTheValue2 in dictConstruct2:
    print(dictConstruct2[loopTheValue2])

print("--------------------------------")

# Loop to get the values - values()
for loopTheValue2 in dictConstruct2.values():
    print(loopTheValue2)

print("--------------------------------")

# Loop to get the keys - keys()
for loopTheValue2 in dictConstruct2.keys():
    print(loopTheValue2)

print("--------------------------------")

# Loop to get the items - items()
for loopTheValue2 in dictConstruct2.items():
    print(loopTheValue2)

print("--------------------------------")

# Loop to get the values - values() - another alternative
for loopTheValue2, loopTheValue3 in dictConstruct2.items():
    print(loopTheValue2, loopTheValue3)
