# Inheritance allows us to define a class that inherits all the methods and properties from
# another class.

# Parent class is the class being inherited from, also called base class.
# Child class is the class that inherits from another class, also called derived class.

# Parent Class
class Parent:
    def __init__(self, interviewloc, interviewpos):
        self.interviewloc = interviewloc
        self.interviewpos = interviewpos

    def interviewFunc(self):
        print("Parent Class called..!")
        print(self.interviewloc,self.interviewpos)

# To create a class that inherits the functionality from another class, send the parent class as a
# parameter when creating the child class.

# Use the pass keyword when you do not want to add any other properties or methods to the class.

# Child Class
class Child(Parent):
    print("Child Class called..!")

parent1 = Child("Kadubeesenahalli", "Non-Voice process")
parent1.interviewFunc()