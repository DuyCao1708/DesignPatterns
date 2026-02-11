# Prototype Pattern

1. Intent

   Lets you copy existing objects without making your code dependent on their classes.

2. The Context (Problem)

    You have a Widget class. Configuring a widget involves:

    - Fetching data from a database.

    - Parsing a complex CSS-like style object.

    Instead of your UI code knowing how to "re-build" a widget from scratch, the widget itself provides a Clone() method.
