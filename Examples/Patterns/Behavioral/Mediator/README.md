# Mediator Pattern

1. Intent

   Reduces chaotic dependencies between objects. It restricts direct communications between the objects and forces them to collaborate only via a mediator object.

2. The Context (Problem)

    You are building a Smart Home Automation System. You have many devices:

    - Alarm Clock

    - Coffee Machine

    - Smart Blinds (Curtains)

    - Smart Lights

    The Problem: You want a "Good Morning" routine.

    - When the Alarm rings, it needs to tell the Coffee Machine to start brewing.

    - The Coffee Machine needs to tell the Blinds to open.

    - The Blinds need to tell the Lights to turn off (to save energy).

    If you hard-code these relationships, your Alarm class will need a reference to the CoffeeMachine, the CoffeeMachine needs the Blinds, and so on. If you remove the Coffee Machine, the whole system breaks!
