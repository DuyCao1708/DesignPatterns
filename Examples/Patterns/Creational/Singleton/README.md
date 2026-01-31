## Singleton Pattern

1. Intent

Ensure that a class has only one instance and provide a global point of access to it.

2. The Context (Problem)

In a high-performance application, opening a new database connection for every request is expensive and slow. You need a DatabaseContext object that:

    Is shared across the entire application.

    Prevents multiple instances from exhausting database resources.

    Is initialized only when needed (Lazy Loading).
