// ============================================
// Quick Reference: C# Data Types
// ============================================

namespace Lesson02
{
    // Reference class - contains only documentation
    public static class DataTypesReference
    {
        /*
╔═══════════════════════════════════════════════════════════════════════════════╗
║                           INTEGER TYPES (Whole Numbers)                        ║
╠═══════════╦═══════════╦══════════════════════════════════════╦════════════════╣
║ Type      ║ Size      ║ Range                                ║ Example        ║
╠═══════════╬═══════════╬══════════════════════════════════════╬════════════════╣
║ byte      ║ 8-bit     ║ 0 to 255                             ║ byte b = 255;  ║
║ sbyte     ║ 8-bit     ║ -128 to 127                          ║ sbyte s = -1;  ║
║ short     ║ 16-bit    ║ -32,768 to 32,767                    ║ short s = 100; ║
║ int       ║ 32-bit    ║ -2.1 billion to 2.1 billion          ║ int i = 42;    ║  ★ MOST USED
║ long      ║ 64-bit    ║ ±9.2 quintillion                     ║ long l = 42L;  ║
╚═══════════╩═══════════╩══════════════════════════════════════╩════════════════╝

╔═══════════════════════════════════════════════════════════════════════════════╗
║                       FLOATING-POINT TYPES (Decimals)                          ║
╠═══════════╦═══════════╦══════════════════════════════════════╦════════════════╣
║ Type      ║ Size      ║ Precision                            ║ Example        ║
╠═══════════╬═══════════╬══════════════════════════════════════╬════════════════╣
║ float     ║ 32-bit    ║ ~7 digits                            ║ float f = 3.14f║
║ double    ║ 64-bit    ║ ~15-16 digits                        ║ double d = 3.14║  ★ MOST USED
║ decimal   ║ 128-bit   ║ ~28-29 digits                        ║ decimal m=9.99m║  ★ FOR MONEY
╚═══════════╩═══════════╩══════════════════════════════════════╩════════════════╝

╔═══════════════════════════════════════════════════════════════════════════════╗
║                              OTHER TYPES                                       ║
╠═══════════╦═══════════╦══════════════════════════════════════╦════════════════╣
║ bool      ║ 1 byte    ║ true or false                        ║ bool b = true; ║
║ char      ║ 16-bit    ║ Single Unicode character             ║ char c = 'A';  ║
║ string    ║ Variable  ║ Sequence of characters               ║ string s="Hi"; ║
╚═══════════╩═══════════╩══════════════════════════════════════╩════════════════╝

TIPS:
1. Use 'int' for most whole numbers
2. Use 'double' for most decimals
3. Use 'decimal' for money/financial calculations
4. Use 'var' when the type is obvious
5. Use meaningful, descriptive variable names
        */
    }
}
