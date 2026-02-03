## Adapter Pattern

1. Intent

   Act as a bridge between two incompatible interfaces. It converts the interface of a class into another interface that the client expects.

2. The Context (Problem)
   Your modern computer system expects all printers to use a USB-C connection, but you found an old, high-quality Legacy Serial Printer in the warehouse that uses an ancient Serial Port.
   - Your Computer: Has a method SendUsbRequest(string data). It only talks to devices that implement IUsbDevice.

   - Legacy Printer: Only understands a method called PrintViaSerialPort(string data)
