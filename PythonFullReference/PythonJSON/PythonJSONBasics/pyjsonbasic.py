# JSON is a syntax for storing and exchanging data.
# JSON is text, written with JavaScript object notation.
# Python has a built-in package called json, which can be used to work with JSON data.
import json

# Parse JSON - Convert from JSON to Python
# If you have a JSON string, you can parse it by using the json.loads() method.
# The result will be a Python dictionary.
jsonbasic = '{ "name":"John", "age":30, "city":"New York"}'
jsonparse = json.loads(jsonbasic)
print(jsonparse)
print(jsonparse['age'])

print("---------------------------------------")

# If you have a Python object, you can convert it into a JSON string by using the json.dumps() method.
todayinterview310 = {
    "ilog": 6001,
    "address": "18, 4th Floor, Guava Garden, KHB Colony, 5th Block, Koramangala, Bengaluru, "
               "Karnataka 560095",
    "build_name": "Enzyme JNC Business Center",
}
pytojson = json.dumps(todayinterview310)
print(pytojson)
