# Arbitrary Arguments, *args
# If you do not know how many arguments that will be passed into your function,
# add a * before the parameter name in the function definition.
# This way the function will receive a tuple of arguments, and can access the items accordingly.
# Arbitrary Arguments are often shortened to *args in Python documentations.

def arbitar(*fruits):
    print("Fruits : "+fruits[3])
arbitar("Mango", "Apple", "Kiwi", "Timala", "Suhg")

# Keyword Arguments
# You can also send arguments with the key = value syntax.This way the order of the arguments does not
# matter.
# The phrase Keyword Arguments are often shortened to kwargs in Python documentations.
def arbitar2(fruit1, fruit2, fruit3):
    print("Fruit 3 is  : "+fruit3)
arbitar2(fruit1="Mango", fruit2="Apple", fruit3="Kiwi")
