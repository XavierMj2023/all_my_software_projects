# Polymorphism is often used in Class methods, where we can have multiple classes with the
# same method name.

class Poly1:
    def __init__(self, brand, model):
        self.brand = brand
        self.model = model

    def poly1execute(self):
        print("Poly 1!...")

class Poly2:
    def __init__(self, brand, model):
        self.brand = brand
        self.model = model

    def poly1execute(self):
        print("Poly 2!...")

class Poly3:
    def __init__(self, brand, model):
        self.brand = brand
        self.model = model

    def poly1execute(self):
        print("Poly 3!...")

# Create an object of all Classes
po1 = Poly1("Volvo", "34B")
po2 = Poly2("Volvi", "35C")
po3 = Poly3("Volta", "46H")

for p in (po1, po2, po3):
    p.poly1execute()