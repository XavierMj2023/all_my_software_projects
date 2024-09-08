#The local variable can be accessed from a function within the function
def myfunc():
    x = 109

    def innerfunc():
        print(x)

    innerfunc()

myfunc()
