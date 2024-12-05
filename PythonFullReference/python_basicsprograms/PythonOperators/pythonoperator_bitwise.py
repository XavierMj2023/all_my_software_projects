#Python Bitwise Operators

#AND - & - compares each bit and set it to 1 if both are 1, otherwise it is set to 0.(16 bytes)
print(6 & 3)

#OR - | -  compares each bit and set it to 1 if one or both is 1, otherwise it is set to 0.(16 bytes)
print(6 | 3)

#NOT - ~ - inverts each bit (0 becomes 1 and 1 becomes 0).(16 bytes)
print(~ 3)

#XOR - ^ - compares each bit and set it to 1 if only one is 1, otherwise (if both are 1 or both are 0)
#          it is set to 0. (16 bit)
print(6 ^ 3)

# >>   -   Shift right by pushing copies of the leftmost bit in from the left, and let the rightmost
#          bits fall off. (16 bit)
print(8 >> 2)