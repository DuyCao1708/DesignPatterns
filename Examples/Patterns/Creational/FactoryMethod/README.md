## Factory Method Pattern

1. Intent

   Provide an interface for creating objects in a superclass, but allow subclasses to alter the type of objects that will be created.

2. The Context (Problem)

   You are building a Notification System for a bank. When a transaction occurs, the system must notify the user.
   - Some users prefer Email.

   - Some users prefer SMS.

   - Future users might want Push Notifications or Telegram.
