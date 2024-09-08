# Python also has a super() function that will make the child class inherit all
# the methods and properties from its parent.

# Add property to the class.

# Parent Class
class Parent:
    def __init__(self, interviewloc, interviewpos):
        self.interviewloc = interviewloc
        self.interviewpos = interviewpos

    def interviewFunc(self):
        print("Parent Class called..!")
        print(self.interviewloc, self.interviewpos)


# Child Class
class Child(Parent):
    print("Child Class called..!")

    def __init__(self, interviewloc, interviewpos):
        super().__init__(interviewloc, interviewpos)
        self.intername = "Desar Renald"


parent1 = Child("Electronic City", "Data Entry")
print(parent1.intername)
