#A date in Python is not a data type of its own, but we can import a module named datetime
# to work with dates as date objects
import datetime

#To check the present datetime
checkPresentDate = datetime.datetime.now()
print(checkPresentDate)

#Return the year and name of weekday of above date
print(checkPresentDate.year)
print(checkPresentDate.strftime("%A"))

