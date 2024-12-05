# To convert from complex into int or float
co = 6j
print(co, type(co))

coConv = int(co)
print(coConv)
print(type(coConv))
# TypeError: int() argument must be a string, a bytes-like object or a real number, not 'complex'

coConv2 = float(co)
print(coConv2)
print(type(coConv2))
# TypeError: int() argument must be a string, a bytes-like object or a real number, not 'complex'