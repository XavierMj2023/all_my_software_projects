# The __init__() function is called automatically every time the class is being used to
# create a new object.

# When you add the __init__() function, the child class will no longer inherit the
# parent's __init__() function

# The child's __init__() function overrides the inheritance of the parent's __init__() function.

# To keep the inheritance of the parent's __init__() function, add a call to the
# parent's __init__() function

# Parent Class
class Parent:
    def __init__(self, interviewloc, interviewpos):
        self.interviewloc = interviewloc
        self.interviewpos = interviewpos

    def interviewFunc(self):
        print("Parent Class called..!")
        print(self.interviewloc,self.interviewpos)

# Child Class
class Child(Parent):
    print("Child Class called..!")

    def __init__(self, interviewloc, interviewpos):
       Parent.__init__(self, interviewloc, interviewpos)

parent1 = Child("HSR Layout", "Voice process")
parent1.interviewFunc()