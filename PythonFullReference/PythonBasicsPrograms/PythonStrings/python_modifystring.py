# Modifying Strings

# upper()
comstat1 = "Hulimavu is a great place"
print(comstat1.upper())

# lower()
comstat2 = "Hulimavu is a great place"
print(comstat2.lower())

# Whitespace is the space before and/or after the actual text, and very often you want to remove this
# space.
# strip() - removes any whitespace from the beginning or the end
comstat3 = "Hulimavu is a great place  -ionic and cob  "
print(comstat3.strip())

# replace() method replaces a string with another string:
originalstat = "Word of the mistaken"
replacestat = "day!"
print(originalstat.replace("mistaken", replacestat))

# split() method returns a list where the text between the specified separator becomes the list items.
originalstat1 = "Word, of, the, mistaken"
print(originalstat1.split(","))

# Named index
# You can also use named indexes by entering a name inside the curly brackets {carname},
# but then you must use names when you pass the parameter values txt.format(carname = "Ford").
order = "I have a {carname}, it is a {model}."
print(order.format(carname="Volvo", model="12034"))
