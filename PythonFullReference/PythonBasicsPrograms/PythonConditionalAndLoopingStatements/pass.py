# if statements cannot be empty, but if you for some reason have an if statement with no
# content, put in the pass statement to avoid getting an error.
a = "Manoj"
num1 = 10
num2 = 20

if a == "Manoj" or a == "manoj":
    print("Authenticated")
    print("Let us start executing : !..")
    if num1 < num2:
        pass
    else:
        print("20 is greather than 10")

print("Success!..")
