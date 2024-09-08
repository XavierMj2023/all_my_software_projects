# All classes have a function called __init__(), which is always executed when the class is being
# initiated.

# Use the __init__() function to assign values to object properties, or other operations that are
# necessary to do when the object is being created.

# The __init__() function is called automatically every time the class is being used to create a
# new object.

class Interview:
    def __init__(self, recruiter, id):
        self.recruiter = recruiter
        self.id = id

intern1 = Interview("Hazam Abdul", 12678)

#Named argument
interstr = "For today's interview, it is conducted by {recruiter} and his employee id is {id}."
print(interstr.format(recruiter=intern1.recruiter, id=intern1.id))