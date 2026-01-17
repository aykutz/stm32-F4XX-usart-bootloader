The project consists of four parts.

-> F4_application (main.c and main.h):
This is the application that runs on the MCU in Sectors 2 to 7. It contains the main functions of the MCU. In this project, a LED blink operation is implemented.
In real applications, tasks such as motor control and sensor data reading are handled here.

-> F4_bootloader (bootloader.c and bootloader.h):
This is the bootloader that runs in Sector 0 and Sector 1. In this project, the bootloader works via USART. All bootloader-related code is located here.

-> stm32F4programmer (UI):
This contains the files of the user interface developed in Visual Studio. Operations such as memory write, memory read, write protection, and read protection can be performed through this interface.

-> programSetup:
This folder provides access to the Visual Studio application. The executable (.exe) file of the application is located here.
