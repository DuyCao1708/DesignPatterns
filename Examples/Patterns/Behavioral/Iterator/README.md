# Iterator Pattern

1. Intent

    Allows you to traverse elements of a collection (list, stack, tree, etc.) without exposing its underlying representation (the complex nodes, pointers, or array indices).

2. The Context (Problem)

    Imagine a warehouse that stores items in different ways:

    - Small Items: Stored in a simple List.

    - Legacy Items: Stored in an old Fixed Array.

    - Fragile Items: Stored in a Stack (Last-in, First-out).

    The Problem: Your "Inventory Report" tool shouldn't have to care how the items are stored. It just wants to "scan" everything in the building.
