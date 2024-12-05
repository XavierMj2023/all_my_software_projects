# The finally block, if specified, will be executed regardless if the try block raises an error or
# not.
# This can be useful to close objects and clean up resources.

try:
    print(x)
except:
    print("Something went wrong!..")
finally:
    print("Try Except is finished!...")