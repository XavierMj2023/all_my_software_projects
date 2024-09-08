#Slicing
#You can return a range of characters by using the slice syntax.
#Specify the start index and the end index, separated by a colon, to return a part of the string.
stringforslice = "Ammi Jaan"
print(stringforslice[2:6])

#Slicing - Slice from the Start
#By leaving out the start index, the range will start at the first character.
stringforslice2 = "Ammi Jaan"
print(stringforslice2[:6])

#Slicing - Slice from the end
#By leaving out the end index, the range will go to the end
stringforslice3 = "Ammi Jaan"
print(stringforslice3[2:])

#Negative Indexing
#Use negative indexes to start the slice from the end of the string
stringforslice4 = "Juice Apple"
print(stringforslice4[-5:-2])
