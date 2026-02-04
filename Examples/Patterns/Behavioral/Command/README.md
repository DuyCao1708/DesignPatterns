## Command Pattern

1. Intent

   Wrap a specific action (changing text color, making text bold, or typing) into an object. This allows you to treat "actions" as data that can be moved, stored, or reversed.

2. The Context (Problem)

   You are building a Code Editor.
   - A user can: Write Text, Delete Text, and Change Font Style.
   - The Problem:
     - If the user presses Ctrl+Z, you need to know exactly how to reverse the last thing they did.

     - If they deleted a whole paragraph, you need to have stored that paragraph somewhere to bring it back.

     - If you just write functions like DeleteText(), you have no way to "go back in time."
