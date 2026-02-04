## Builder Pattern

1. Intent

   Lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.

2. The Context (Problem)

   You are building a PC order system. A PC is a complex object with many parts: CPU, GPU, RAM,....
   - Not every PC needs a high-end GPU (some use integrated graphics).

   - Some need 4 sticks of RAM, others need 2.
