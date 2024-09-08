# A function is a block of code which only runs when it is called.
# You can pass data, known as parameters, into a function.
# A function can return data as a result.
# In Python a function is defined using the def keyword.

# Function Declaration
def manFunc():
    print("This is a Function Called")
#To call a function, use the function name followed by parenthesis
manFunc()

# Arguments are specified after the function name, inside the parentheses.
# You can add as many arguments as you want,just separate them with a comma.
# Arguments are often shortened to args in Python documentations.
def myfunc_name(name):
    print(name + " Desar")

myfunc_name("Reginald")
myfunc_name("Somali")
myfunc_name("Tiga")

# A parameter is the variable listed inside the parentheses in the function definition.
# An argument is the value that is sent to the function when it is called.
def argdemo_multiple(f1, f2):
    print("Car model is "+f1 + " "+"and it was manufactured by "+f2)
argdemo_multiple("Volvo", "Toyota")