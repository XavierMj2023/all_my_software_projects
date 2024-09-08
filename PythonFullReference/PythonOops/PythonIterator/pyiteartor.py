# An iterator is an object that contains a countable number of values.

# Technically, in Python, an iterator is an object which implements the iterator protocol,
# which consist of the methods __iter__() and __next__().

# Lists, tuples, dictionaries, and sets are all iterable objects.
# They are iterable containers which you can get an iterator from.
# All these objects have a iter() method which is used to get an iterator.

# Return an iterator from a tuple, and print each value.
mytup = ("Kiwi", "Soromon", "Hulimav")
myit = iter(mytup)
print(next(myit))
print(next(myit))
print(next(myit))

# Even strings are iterable objects, and can return an iterator.
mystr = "Banana"
myit2 = iter(mystr)
print(next(myit2))
print(next(myit2))
print(next(myit2))
print(next(myit2))
print(next(myit2))
print(next(myit2))

# We can also use a for loop to iterate through an iterable object.
for mtup in mytup:
    print(mtup)