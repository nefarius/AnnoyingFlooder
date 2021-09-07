Description
===========
The AnnoyingFlooder (sorry for this misleading name) allows you to fill any existing and new files with a defined amount of junk-zero bytes. What's so special about this task you had to write an extra program for it, you ask? It is not just written to the "original" file, but in an (also arbitrary) alternate data stream. This makes it possible - without damaging the existing file with valid content - to virtually hide large amounts of data "beneath" a visible file. Tools like the built-in Windows Explorer or other 3rd party tools won't calculate the used space correctly but the operating system itself will report a full hard drive.

Maybe this program is completely useless for you, someone may use it to prank one of his colleagues 😁

Design by Teyhouse.

Dependencies
============
 * .NET Framework 3.5
 * Windows XP onwards with a NTFS partition
