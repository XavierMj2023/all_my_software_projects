# Sample sets of set 1 and set 2
set1 = {"Pikacku", "Electabuz", "Raichu"}
set2 = {"Magmar", "Charizard"}
set3 = {"Squirttle", "Starmy", "Kingdra"}

# The union() method returns a new set with all items from both sets
setunion = set1.union(set2)
print(setunion)

print("----------------------------------")

# You can use the | operator instead of the union() method, and you will get the same result.
# The | operator only allows you to join sets with sets, and not with other data types like you can
# with the  union() method.
setunionalternative = set1 | set2
print(setunionalternative)

print("----------------------------------")

# All the joining methods and operators can be used to join multiple sets.
# When using a method, just add more sets in the parentheses, separated by commas.
setmultiplejoin = set1.union(set2, set3)
print(setmultiplejoin)

print("----------------------------------")

# When using the | operator, separate the sets with more | operators
setmultiplejoin2 = set1 | set2 | set3
print(setmultiplejoin2)

print("----------------------------------")

# The union() method allows you to join a set with other data types, like lists or tuples.
# The result will be a set.
listdatajoin = ["Hulimavu", "Arekere", "Junction Yard"]
datadiff = set1.union(listdatajoin)
print(datadiff)

print("----------------------------------")

# The update() method inserts all items from one set into another.
# The update() changes the original set, and does not return a new set.
# Both union() and update() will exclude any duplicate items.
print(set1)
set1.update(set2)
print(set1)

print("----------------------------------")

# The intersection() method will return a new set, that only contains the items that are present in
# both sets.
set4 = {"Ash", "Misty", "Brock", "Kanto"}
set5 = {"Ash", "Brock", "Hoenn", "May"}
setintersect = set4.intersection(set5)
print(setintersect)

print("----------------------------------")

# You can use the & operator instead of the intersection() method, and you will get the same result.
setintersectalt = set4 & set5
print(setintersectalt)

print("----------------------------------")

# The & operator only allows you to join sets with sets, and not with other data types like you can
# with the intersection() method.

# The intersection_update() method will also keep ONLY the duplicates, but it will change the
# original set instead of returning a new set.
set4.intersection_update(set5)
print(set4)

# The values True and 1 are considered the same value. The same goes for False and 0.

print("----------------------------------")


set6 = {"Ash", "Misty", "Brock", "Kanto"}
set7 = {"Ash", "Brock", "Hoenn", "May"}

# The difference() method will return a new set that will contain only the items from the first set
# that are not present in the other set.
setdiffdemo = set6.difference(set7)
print(setdiffdemo)

print("----------------------------------")

# You can use the - operator instead of the difference() method, and you will get the same result.
# The - operator only allows you to join sets with sets, and not with other data types like you can
# with the difference() method.
setdiffdemoalt = set6 - set7
print(setdiffdemoalt)

print("----------------------------------")

# The difference_update() method will also keep the items from the first set that are not in the
# other set, but it will change the original set instead of returning a new set.
set6.difference_update(set7)
print(set6)

print("----------------------------------")

set8 = {"Ash", "Misty", "Brock", "Kanto"}
set9 = {"Ash", "Brock", "Hoenn", "May"}

# The symmetric_difference() method will keep only the elements that are NOT present in both sets.
setsymmdiff = set8.symmetric_difference(set9)
print(setsymmdiff)

print("----------------------------------")

# You can use the ^ operator instead of the symmetric_difference() method, and you will get the same
# result.
setsymmdiffalt = set8 ^ set9
print(setsymmdiffalt)

# The ^ operator only allows you to join sets with sets, and not with other data types like you can
# with the symmetric_difference() method.

print("----------------------------------")

# The symmetric_difference_update() method will also keep all but the duplicates,
# but it will change the original set instead of returning a new set.
set8.symmetric_difference_update(set9)
print(set8)

print("----------------------------------")

