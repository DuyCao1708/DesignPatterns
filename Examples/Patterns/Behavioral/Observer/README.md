## Observer Pattern

1. Intent

   Define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.

2. The Context (Problem)

   You have a Stock with a price that changes every second. You have various components that need this price:
   - DisplayBoard: To show the current price on the screen.

   - AlertSystem: To send a warning if the price drops below $150.

   - Logger: To save price history for analysis.
