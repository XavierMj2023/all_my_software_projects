# First we import Ursina Module
from ursina import *

# Importing functon for First person player
from ursina.prefabs.first_person_controller \
     import FirstPersonController

# Initialize the Game
app = Ursina()

# Creating the player
player = FirstPersonController()

# Creating a ground size of 100 x 100
ground = Entity(
    model='plane',
    texture='grass',
    collider='mesh',
    scale=(100, 1, 100)
)

# To create the animation using FrameAnimation3d() and also use for loop
for i in range(10):
    for j in range(10):
        robot = FrameAnimation3d(

            # 3d Object
            'assets\\robot',

            # Position for the 3d model
            position=(2*i, 0, 2*j),

            # Fps Rate, Scale and Color
            fps=18,
            scale=0.0030,
            color=color.black66
        )

# Let also make standard sky
Sky()

# Run app
app.run()