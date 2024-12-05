# You can send any data types of argument to a function (string, number, list, dictionary etc.),
# and it will be treated as the same data type inside the function.
# E.g. if you send a List as an argument, it will still be a List when it reaches the function.

def listasArg(listArg):
    for larg in listArg:
        print(larg)

listasArg_sample = ["List1", "Lis2","Li3"]
listasArg(listasArg_sample)