# You can specify that a function can have ONLY positional arguments, or ONLY keyword
# arguments.
# To specify that a function can have only positional arguments, add , / after the arguments.
# Without the , / you are actually allowed to use keyword arguments even if the function expects
# positional arguments.
# But when adding the , / you will get an error if you try to send a keyword argument.

# To specify that a function can have only keyword arguments, add *, before the arguments.
# Without the *, you are allowed to use positional arguments even if the function expects
# keyword arguments.
#

def posonlyarg(x, /):
    print(x)

def keyonlyarg(*, x):
    print(x)


posonlyarg(34)

keyonlyarg(x = 45)
