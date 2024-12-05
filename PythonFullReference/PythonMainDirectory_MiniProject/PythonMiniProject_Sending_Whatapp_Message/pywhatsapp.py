from datetime import datetime

# Importing the module
import pywhatkit

# using exception handling to avoid unprecedented errors
try:
    # sending messages to receiver using pywhatkit

    # 21 represents 9 PM (21:00 in 24-hour format),

    # 23 represents 11 PM (23:00 in 24-hour format).

    # pywhatkit.sendwhatmsg("+918217097131", "Hello Manoj! Sent from python", 21, 23, 60)
    # print("Successfully sent!")

    # Example 2:
    # Current Time

    # Getting current time
    now = datetime.now()
    current_hour = now.hour
    current_minute = now.minute

    pywhatkit.sendwhatmsg("+9972549000",
                          "Congratulations! You have won medical insurance of 5.5 crore!...",
                          current_hour,
                          current_minute + 1
                          )
    print("Successfully sent!")
except:
    # handling exception and printing error message
    print("Unexpected error!..")
