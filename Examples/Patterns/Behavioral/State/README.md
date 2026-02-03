## State Pattern

1. Intent

   Allows an object to alter its behavior when its internal state changes. The object will appear to change its class.

2. The Context (Problem)

   Imagine a Vending Machine. It behaves differently depending on its current status:
   - If it has No Coin: Pressing the button does nothing.

   - If it has a Coin: Pressing the button dispenses an item.

   - If it is Out of Stock: It rejects coins and buttons.
