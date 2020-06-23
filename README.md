# KECCAK_WINDOWS-FORMS

Keccak hash algorithm on C# as windows app based on my c++ alogoritm. This program uses Keccak algorithm from my sha3.cpp program, with some changes due to lack of pointers in C# (I did not use unsafe code):
- To store encoding message's bytes stack was used instead of queue
- All methods were made as static to avoid creating class instances
- Casting methods were added (char to UInt64 matrix, UInt64 array to hex string)

You can download the attached .rar archieve to use this program. All you have to do after downloading is run KeccakHash.exe. Note that this app only works on windows 10. There is how to use this program:
1) Choose the hash length in bits using scrolling window near the "Keccak-"
2) Input some text in the first form
3) Click on "Закодировать"
4) Get your hash in the second form

You can also mark the box "авто обновление хэш-значения" to let hash update with every single change of incoming message.
