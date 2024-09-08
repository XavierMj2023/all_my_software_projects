# Python Library automation
import pyautogui

# Moving the Mouse
pyautogui.moveTo(100, 100)

pyautogui.moveRel(50, 25)

# Clicking the mouse
pyautogui.click(clicks=3, interval=1)

# Scrolling the mouse - Not working
pyautogui.scroll(5000)

# Typing text
pyautogui.typewrite("Mere", interval=0.5)