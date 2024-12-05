# The __str__() function controls what should be returned when the class object is represented as
# a string.
# If the __str__() function is not set, the string representation of the object is returned.

class InterviewWithoutStrFunction:
    def __init__(self, name, age):
        self.name = name
        self.age = age


class InterviewWithStrFunction:
    def __init__(self, name, age):
        self.name = name
        self.age = age

    def __str__(self):
        return f"{self.name}{self.age}"

# Creating an object of InterviewWithoutStrFunction
int_without = InterviewWithoutStrFunction("Manoj", 26)

# Creating an object of InterviewWithStrFunction
int_with = InterviewWithStrFunction("Drew Mcintyre", 45)

# Calling out InterviewWithoutStrFunction
print(int_without)

# Calling out InterviewWithStrFunction
print(int_with)