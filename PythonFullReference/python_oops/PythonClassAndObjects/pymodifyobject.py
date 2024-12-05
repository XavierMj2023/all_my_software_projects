class ModifyObject:
    def __init__(self, empid, age):
        self.empid = empid
        self.age = age

    def ModObject(self):
        print("Emp Id is : " + self.empid + " and age is : " + self.age)


modObj1 = ModifyObject("1A1", 26)
modObj1str = "Current age is : {age}"
print(modObj1str.format(age=modObj1.age))

# Modifying the Object
modObj1.age = 35
modObj1str = "Modified age is  : {age}"
print(modObj1str.format(age=modObj1.age))
