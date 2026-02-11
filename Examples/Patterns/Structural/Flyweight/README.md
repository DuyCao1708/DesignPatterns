# Flyweight Pattern

1. Intent

   Lets you fit more objects into the available amount of RAM by sharing common parts of state between multiple objects instead of keeping all of the data in each object.

2. The Context (Problem)
   Imagine you are developing a real-time strategy (RTS) game like StarCraft or Age of Empires. You need to render 100,000 Soldiers on the screen.

    The Problem: Each Soldier object has:

    - Coordinates (x,y): Unique to every soldier.

    - Health: Changes per soldier.

    - 3D Model & Textures: Massive data (e.g., 5MB per soldier).

    If you create 100,000 objects, each holding its own 5MB texture:

        100,000×5MB=500,000MB≈500GB of RAM!

    Your game will crash instantly.
