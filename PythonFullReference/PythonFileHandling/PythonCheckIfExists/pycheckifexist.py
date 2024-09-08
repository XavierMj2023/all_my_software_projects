import os.path

# To avoid getting an error, you might want to check if the file exists before you try to delete it.
if os.path.exists("removeMe3.txt"):
    os.remove("removeMe3.txt")
else:
    print("The File does not exist!..")