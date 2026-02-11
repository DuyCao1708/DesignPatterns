# Memento Pattern

1. Intent

    Lets you save and restore the previous state of an object without revealing the details of its implementation (encapsulation).

2. The Context (Problem)

    Imagine you are building a Photo Editor (like Photoshop).

    - You have an image with brightness, contrast, and filter settings.

    - The user applies a "Vintage" filter.

    - Then they change the brightness to 80%.

    - Suddenly, they realize it looks terrible and hit Undo.

    The Problem: If you let the "History Manager" access the private fields of the Editor to save them, you break Encapsulation. If the Editor changes its internal logic, the History Manager breaks too.
