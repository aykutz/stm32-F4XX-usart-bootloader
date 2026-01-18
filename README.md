

Silicon Room Project Video -> https://youtu.be/f3KqPAi_-bY


You can reach me through my YouTube channel.



# Don't pass without reading

-> F4_application (main.c and main.h):
This is the application that runs on the MCU in Sectors 2 to 7. It contains the main functions of the MCU. In this project, a LED blink operation is implemented.
In real applications, tasks such as motor control and sensor data reading are handled here.

-> F4_bootloader (bootloader.c and bootloader.h):
This is the bootloader that runs in Sector 0 and Sector 1. In this project, the bootloader works via USART. All bootloader-related code is located here.

-> stm32F4programmer (UI):
This contains the files of the user interface developed in Visual Studio. Operations such as memory write, memory read, write protection, and read protection can be performed through this interface.

-> Download to stm32F4Programmer.exe: 
You can access the program from the ‘Tags’ section above. When you click on v1.0.0, the .exe and .pdb files will be visible.


<img width="856" height="503" alt="program" src="https://github.com/user-attachments/assets/3f84b02c-bdde-4688-a46a-62443031a148" />





# Problems encountered during the project

In this project, I am using the F401RE Nucleo board.
If you are using a different board, do not start writing the bootloader without checking the documents related to the board you are using.

For example, if you were using the F407 Discovery board, you need to solder a jumper to SB19 and pull BOOT1 to GND in order to put the board into boot mode.
Otherwise, the PB2 pin is connected to VDD by default and reads a logic 1. That means if you do not solder SB19, you cannot pull BOOT1 to GND and you cannot put the board into boot mode.
These pins or jumpers (for example SB19) change from board to board.
For the F401RE Nucleo, there is no need to do such an operation. You must access the schematic drawings and datasheets of the board and start the project only after doing the necessary checks.

To be able to write to the board using the stm32F4Programmer software, make sure that the write protections are disabled.
Otherwise, you will always see 1F in the output section, which means “NACK”. This means that you cannot write the program into memory. To remove write protections, if none of the boxes are checked and you press the Write P/UP button, the write protections on the sectors will be removed and you can continue writing. Because I did not notice this, I received 1F output for hours :D do not make the same mistake.

79 means “ACK”. If you perform any operation correctly, you will see 79 on the screen.
For example, if you select Full Chip Erase and press the Erase button, and the operation is completed successfully, you will see 79 on the screen. This shows that the operation has been completed.
