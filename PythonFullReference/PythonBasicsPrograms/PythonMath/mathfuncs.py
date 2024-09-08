# Python has also a built-in module called math, which extends the list of mathematical functions.
from math import sqrt, ceil, floor, pi

# Min and Max of the iterable
min_num = [90, 24, 45, 67, 33]
print(min(min_num))
print(max(min_num))

# The abs() function returns the absolute (positive) value of the specified number.
abnum = abs(-90.483)
print(abnum)

# The pow(x, y) function returns the value of x to the power of y (xy).
powe = pow(3, 4)
print(powe)

# sqrt - returns the square root of a number
sqroot = sqrt(64)
print(sqroot)

# ceil - This rounds a number upwards to its nearest integer
ceilnum = ceil(1.4)
print(ceilnum)

# floor - This rounds a number downwards to its nearest integer.
floornum = floor(1.4)
print(floornum)

#pi - returns the value of PI (3.14...).
pivalue = pi
print(pivalue)