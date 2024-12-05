def recur(k):
    if k > 0:
        res = k + recur(k - 1)
        print(res)
    else:
        return 0
    return res

print("Recursion Example")
recur(36)