# Arrays are used to store multiple values in one single variable.
# However, to work with arrays in Python you will have to import a library, like the NumPy library.
# Python does not have built-in support for Arrays, but Python Lists can be used instead.

#Create a array
cars = ["Ford", "Volvo", "BMW"]

#Access Array element
print(cars[1])

#Length of array
print(len(cars))

#Looping through array
for looparray in cars:
    print(looparray)

#Remove using pop() and remove()
cars.pop(1)
print("Using pop()")
print(cars)
print("Using remove()")
cars.remove("Ford")
print(cars)