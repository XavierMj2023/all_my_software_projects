# What about classes with child classes with the same name? Can we use polymorphism there?

class PolyCommon:
    def __init__(self, brand, model):
        self.brand = brand
        self.model = model

    def polyexecute(self):
        print("Poly 1!...")


class Poly1(PolyCommon):
    pass


class Poly2(PolyCommon):
    def polyexecute(self):
        print("Poly 2!...")


class Poly3(PolyCommon):
    def polyexecute(self):
        print("Poly 3!...")


# Create an object of all Classes
po1 = Poly1("Volvo", "34B")
po2 = Poly2("Volvi", "35C")
po3 = Poly3("Volta", "46H")

for p in (po1, po2, po3):
    print(p.brand, p.model)
    p.polyexecute()
