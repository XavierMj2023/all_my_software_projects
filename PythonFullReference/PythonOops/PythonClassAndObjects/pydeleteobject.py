# You can delete properties on objects by using the del keyword.

class ModifyObject:
    def __init__(self, empid, age):
        self.empid = empid
        self.age = age

    def ModObject(self):
        print("Emp Id is : " + self.empid + " and age is : " + self.age)


modobj = ModifyObject("4501G", 34)

# Deleting the object using del keyword
del modobj.empid

print("Id of the employee is : "+modobj.empid)
