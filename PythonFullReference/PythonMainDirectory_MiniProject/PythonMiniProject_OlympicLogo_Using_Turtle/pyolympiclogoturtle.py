import turtle as t

t.speed(5)
t.width(10)

t.penup()
t.goto(-170, -100)
t.pendown()

x = -170
tokyo1 = ["blue", "black", "red"]
for i in tokyo1:
    t.color(i)
    t.circle(80)

    t.penup()
    t.goto(x+195, -100)
    x = x + 195
    t.pendown()

# For Yellow color
t.penup()
t.goto(-70, -170)
t.pendown()
t.color("yellow")
t.circle(80)

# For Green color
t.penup()
t.goto(130, -170)
t.pendown()
t.color("green")
t.circle(80)

# Finish touch
t.penup()
t.goto(-220, 170)
t.pendown()

t.hideturtle()
t.done()
