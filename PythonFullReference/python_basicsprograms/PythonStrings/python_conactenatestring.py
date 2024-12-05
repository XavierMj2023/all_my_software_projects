# Concatenation Strings

# To concatenate, or combine, two strings you can use the + operator.
word1 = "Manoj"
word2 = "Deshpande"
print(word1 + " " + word2)


# format() - Takes the passed arguments, formats them, and places them in the string where the
#            placeholders {} are
#            It takes unlimited number of arguments, and are placed into the respective placeholders.
#            You can use index numbers {0} to be sure the arguments are placed in the correct
#            placeholders
age = 25
txt = "My name is Manoj and my age is {}"
print(txt.format(age))

quantity = 3
item_no = 567
price = 49.95
order = "I want {} pieces of item {} for {} dollars."
print(order.format(quantity, item_no, price))


quantity2 = 3
item_no2 = 567
price2 = 49.95
order2 = "I want {2} pieces of item {0} for {1} dollars."
print(order2.format(quantity2, item_no2, price2))
