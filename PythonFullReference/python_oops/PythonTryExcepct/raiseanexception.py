# As a Python developer you can choose to throw an exception if a condition occurs.
# To throw (or raise) an exception, use the raise keyword.

nio = -18
if nio < 0:
    raise Exception("Sorry, No numbers below zero!...")

str = "MJ Desai"
if not type(str) is int:
    raise TypeError("Numbers allowed only bro!..")