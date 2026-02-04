## Template Method Pattern

1. Intent

   Defines the skeleton of an algorithm in a superclass but lets subclasses override specific steps of the algorithm without changing its structure.

2. The Context (Problem)

   Every invoice in your system must follow a strict legal sequence:
   - Calculate Subtotal: Sum the prices of all items.

   - Apply Tax: (Varies: Domestic is 10%, Export is 0%, etc.).

   - Apply Discount: (Varies: Domestic is 5%, Export is 10%).

   - Generate PDF: Format the data into a document.

   - Send Notification: Email the customer.
