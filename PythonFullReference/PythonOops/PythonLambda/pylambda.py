# A lambda function is a small anonymous function.
# A lambda function can take any number of arguments, but can only have one expression.
# -------------------------
# Syntax
# -------------------------
# lambda arguments : expression
# -------------------------
# The expression is executed and the result is returned.
# Use lambda functions when an anonymous function is required for a short period of time.

# Lambda Function With One Argument
lamb = lambda num: num + 10
print(lamb(10))

# Lambda Function With Multiple Argument
lamb2 = lambda num1, num2: num1 + num2
print(lamb2(10, 34))


# Lambda Function With Function Defination
def lambfunc(no):
    return lambda res: res * no  # 24 * 5

lb = lambfunc(5)
print(lb(24))