# Python DataTypes

# Text Type - str
setTypeForString1 = "MakolaKota"
setTypeForString2 = 'MakolaKotaI'

print("--------------------")
print("Single quote type is : ")
print(type(setTypeForString1))

print("--------------------")
print("Double quote type is : ")
print(type(setTypeForString1))

print("--------------------")
# Numeric type - int
intType = 20
print("The int type is : ")
print(type(intType))

print("--------------------")
# Numeric Type - float
floatType = 20.36
print("The float type is : ")
print(type(floatType))

print("--------------------")
# Numeric Type - complex
complexType = 1j
print("The complex type is : ")
print(type(complexType))

print("--------------------")
# Sequence Type - list
sequenceType_list = ["apple", "banana", "cherry"]
print("The list type is : ")
print(type(sequenceType_list))

print("--------------------")
# Sequence Type - tuple
sequenceType_tuple = ("apple", "banana", "cherry")
print("The tuple type is : ")
print(type(sequenceType_tuple))

print("--------------------")
# Sequence Type - range
sequenceType_range = range(6)
print(sequenceType_range)
print("The range type is : ")
print(type(sequenceType_range))

print("--------------------")
# Mapping Type - dict
mappingType = {"name": "John", "age": 36}
print("The dict type is : ")
print(type(mappingType))

print("--------------------")
# Set Type - set
setType = {"apple", "banana", "cherry"}
print("The set type is : ")
print(type(setType))

print("--------------------")
# Set Type - frozenset
frozensetType = frozenset({"apple", "banana", "cherry"})
print("The frozenset type is : ")
print(type(frozensetType))

print("--------------------")
# Boolean Type - true/false
boolType1 = True
print("The bool type is : ")
print(type(boolType1))

print("--------------------")
# None Type - None
noneType = None
print("The none type is : ")
print(type(noneType))

print("--------------------")
# Binary Type - bytes
binaryType1 = b"Hello"
print("The Data for the data type  is :")
print(binaryType1)
print("The Binary type is : ")
print(type(binaryType1))

print("--------------------")
# Binary Type - bytesarray
binaryType2 = bytearray(8)
print("The Data for the data type  is :")
print(binaryType2)
print("The Binary type is : ")
print(type(binaryType2))

print("--------------------")
# Binary Type - memoryview
binaryType3 = memoryview(bytes(8))
print("The Data for the data type  is :")
print(binaryType3)
print("The Binary type is : ")
print(type(binaryType3))