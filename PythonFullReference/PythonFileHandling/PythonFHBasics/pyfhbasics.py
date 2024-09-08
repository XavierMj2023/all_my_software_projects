# File handling is an important part of any web application.
# Python has several functions for creating, reading, updating, and deleting files.

# The key function for working with files in Python is the open() function.
# The open() function takes two parameters; filename, and mode.
#  Make sure the file exists, or else you will get an error.

# "r" - Read - Default value. Opens a file for reading, error if the file does not exist
#
# "a" - Append - Opens a file for appending, creates the file if it does not exist.
#
# "w" - Write - Opens a file for writing, creates the file if it does not exist.
#
# "x" - Create - Creates the specified file, returns an error if the file exists.
#
# "t" - Text - Default value. Text mode
#
# "b" - Binary - Binary mode (e.g. images)

# To open a file for reading it is enough to specify the name of the file:
# Syntax : f = open("demo-file.txt", "r")

# The open() function returns a file object, which has a read() method for reading the content of
# the file.
fileOpenDemo = open("demofile_append.txt", "r")
print(fileOpenDemo)
print(fileOpenDemo.read())

print("-----------------------------------------")

# If the file is located in a different location, you will have to specify the file path, like this.
fileinOtherLoc = open("D:\\RECYCLE BIN EXTRAS\\ONLY_DOCS\\PythonFullReference\\PythonFileHandling"
                      "\\PythonFilesDemo"
                      "\\fileinotherloc.txt")
print(fileinOtherLoc)
print(fileinOtherLoc.read())

print("-----------------------------------------")

# By default, the read() method returns the whole text, but you can also specify how many characters
# you want to return.
fileHowManyCharacter = open("demofile_append.txt", "r")
print(fileHowManyCharacter.read(8))

print("-----------------------------------------")

# You can return one line by using the readline() method. By calling readline() two times, you can
# read the two first lines.
fileReadLine = open("demofile_append.txt", "r")
print(fileReadLine.readline())
print("-----------------    ---------------------")
print(fileReadLine.readline())

print("-----------------------------------------")

# By looping through the lines of the file, you can read the whole file, line by line.
fileReadLineLoopy = open("demofile_append.txt", "r")
for li in fileReadLineLoopy:
    print(li)

print("-----------------------------------------")

# It is a good practice to always close the file when you are done with it - close()
fileCloseDemo = open("demofile_append.txt", "r")
print(fileCloseDemo.readline())
fileCloseDemo.close()