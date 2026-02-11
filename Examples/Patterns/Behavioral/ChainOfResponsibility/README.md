# Chain of Responsibility Pattern

1. Intent

    Allows you to pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.

2. The Context (Problem)

    Imagine a customer calls a support line:

    - Level 1 (Bot/Junior): Handles basic password resets. If it's more complex, it passes to...

    - Level 2 (Senior): Handles software configuration. If it's a hardware bug, it passes to...

    - Level 3 (Engineer): Handles deep code bugs or hardware replacement.

    The Problem: If the Client (the caller) has to manually check: if (isHardware) engineer.Fix() it becomes a mess. The Client shouldn't know who fixes the problem; they just hand it to the "Front Desk" and the chain takes care of the rest.
