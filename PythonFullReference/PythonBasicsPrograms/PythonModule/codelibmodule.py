def nameToUpper(innername):
    return "Greetings, !.." + innername.upper()

def greeting(name):
    print("Please wait, while your name is processed to make it uppercase!....")
    formatted_name = nameToUpper(name)
    return formatted_name

person1 = {
  "name": "John",
  "age": 36,
  "country": "Norway"
}