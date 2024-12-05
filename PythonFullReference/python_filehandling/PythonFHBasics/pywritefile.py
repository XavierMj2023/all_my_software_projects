# To write to an existing file, you must add a parameter to the open() function:
#
# "a" - Append - will append to the end of the file
#
# "w" - Write - will overwrite any existing content

# Appending the text - Append
fileAppendExistFile = open("demofile_append.txt", "a")
print(fileAppendExistFile)
fileAppendExistFile.write("Appending more text!...")
fileAppendExistFile.close()

#open and read the file after the appending.
fileAppendExistFile = open("demofile_append.txt", "r")
print(fileAppendExistFile.read())
fileAppendExistFile.close()

print("---------------------------------------------------------------")

# Overwrite the text - Overwrite
fileAppendExistFile = open("demofile_overwrite.txt", "w")
print(fileAppendExistFile)
fileAppendExistFile.write("Overwriting more text!...")
fileAppendExistFile.close()

#open and read the file after the overwriting.
fileAppendExistFile = open("demofile_overwrite.txt", "r")
print(fileAppendExistFile.read())
fileAppendExistFile.close()