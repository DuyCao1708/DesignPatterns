# Bridge Pattern

1. Intent

   Lets you split a large class or a set of closely related classes into two separate hierarchies—Abstraction and Implementation—which can be developed independently.

2. The Context (Problem)

    Imagine you are building a File Downloader system.

    - You have different Types of Downloads: SimpleDownload, SecureDownload (with encryption).

    - You support different Operating Systems: Windows, Linux.

    If you use inheritance, you quickly get overwhelmed:

    - WindowsSimpleDownload

    - LinuxSimpleDownload

    - WindowsSecureDownload

    - LinuxSecureDownload

    If you add a Mac version, you have to create 2 more classes. If you add a CloudDownload type, you have to create 3 more. This is a nightmare to maintain.
