# Python Module - A file containing a set of functions you want to include in your application
# Consider a module to be the same as a code library.
# Now we can use the module we just created, by using the import statement.
# When using a function from a module, use the syntax: module_name.function_name.

# In Python, when a function doesn't explicitly return a value, it implicitly returns None.
# This is likely the reason why you're seeing None printed at the end.

import codelibmodule
import codelibmodule as colib

#Import method in Module
codelibmodule.greeting("manoj khawala")

#Import variable in module
age = codelibmodule.person1["age"]
print(age)

# In your module, the nameToUpper function prints the formatted name instead of returning it.
# Therefore, when you call colib.greeting("Sagr Khandalwa"), it will indeed print the
# formatted greeting but will implicitly return None,
# as there is no explicit return statement.
# If you want the greeting function to return the formatted name, you should modify it to return
# the formatted name instead of printing it


#Renaming a module - You can create an alias when you import a module, by using the as keyword.
print("--------------------------------")
greetMe = colib.greeting("Sagr Khandalwa")
print(greetMe)