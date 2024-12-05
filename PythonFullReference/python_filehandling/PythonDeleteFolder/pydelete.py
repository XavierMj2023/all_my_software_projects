import os

# To delete an entire folder, use the os.rmdir() method.
# You can only remove empty folders.
if os.path.exists("emptyfolder"):
    os.rmdir("emptyfolder")
else:
    print("You can only remove empty folders.")