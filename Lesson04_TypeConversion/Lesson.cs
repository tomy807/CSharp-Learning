// ============================================
// Lesson 4: Type Conversion and Casting
// ============================================

using System;

namespace Lesson04
{
    public class Lesson
    {
        public static void Run()
        {
            Console.WriteLine("=== LESSON 4: Type Conversion and Casting ===\n");

            // ============================================
            // SECTION 1: Implicit Conversion (Automatic)
            // ============================================
            Console.WriteLine("--- Implicit Conversion (Automatic) ---");
            Console.WriteLine("Smaller type -> Larger type (safe, no data loss)\n");

            // int -> long (32-bit to 64-bit)
            int myInt = 100;
            long myLong = myInt;  // Automatic conversion
            Console.WriteLine($"int {myInt} -> long {myLong}");

            // int -> double
            int number = 42;
            double myDouble = number;  // Automatic
            Console.WriteLine($"int {number} -> double {myDouble}");

            // float -> double
            float myFloat = 3.14f;
            double fromFloat = myFloat;
            Console.WriteLine($"float {myFloat} -> double {fromFloat}");

            // char -> int (gets ASCII/Unicode value)
            char letter = 'A';
            int charCode = letter;
            Console.WriteLine($"char '{letter}' -> int {charCode} (ASCII code)");

            // Implicit conversion hierarchy
            Console.WriteLine("\n[Implicit Conversion Path]");
            Console.WriteLine("byte -> short -> int -> long -> float -> double");
            Console.WriteLine("char -> int -> long -> float -> double");

            // ============================================
            // SECTION 2: Explicit Conversion (Casting)
            // ============================================
            Console.WriteLine("\n--- Explicit Conversion (Casting) ---");
            Console.WriteLine("Larger type -> Smaller type (may lose data!)\n");

            // double -> int (truncates decimal)
            double price = 19.99;
            int wholePrice = (int)price;  // Cast with (type)
            Console.WriteLine($"double {price} -> int {wholePrice} (decimal truncated!)");

            // double -> float
            double bigDecimal = 3.14159265359;
            float smallFloat = (float)bigDecimal;
            Console.WriteLine($"double {bigDecimal} -> float {smallFloat} (precision lost)");

            // long -> int (may overflow)
            long bigNumber = 100;
            int smallNumber = (int)bigNumber;
            Console.WriteLine($"long {bigNumber} -> int {smallNumber}");

            // int -> char
            int code = 66;
            char fromCode = (char)code;
            Console.WriteLine($"int {code} -> char '{fromCode}'");

            // WARNING: Data loss example
            Console.WriteLine("\n[WARNING: Data Loss Examples]");
            double largeDouble = 123.789;
            int truncated = (int)largeDouble;
            Console.WriteLine($"(int)123.789 = {truncated} (not rounded, truncated!)");

            int overflow = 300;
            byte smallByte = (byte)overflow;  // 300 > 255!
            Console.WriteLine($"(byte)300 = {smallByte} (overflow! 300 - 256 = 44)");

            // ============================================
            // SECTION 3: Parse Methods (String to Number)
            // ============================================
            Console.WriteLine("\n--- Parse Methods (String -> Number) ---");

            string numberText = "123";
            string decimalText = "45.67";
            string boolText = "true";

            int parsedInt = int.Parse(numberText);
            double parsedDouble = double.Parse(decimalText);
            bool parsedBool = bool.Parse(boolText);

            Console.WriteLine($"int.Parse(\"123\") = {parsedInt}");
            Console.WriteLine($"double.Parse(\"45.67\") = {parsedDouble}");
            Console.WriteLine($"bool.Parse(\"true\") = {parsedBool}");

            // Parse throws exception on invalid input!
            Console.WriteLine("\n[WARNING] Parse throws exception on invalid input:");
            Console.WriteLine("int.Parse(\"abc\") -> FormatException!");
            Console.WriteLine("int.Parse(\"\") -> FormatException!");
            Console.WriteLine("int.Parse(null) -> ArgumentNullException!");

            // ============================================
            // SECTION 4: TryParse (Safe Parsing)
            // ============================================
            Console.WriteLine("\n--- TryParse (Safe Parsing) ---");
            Console.WriteLine("Returns true/false, no exceptions!\n");

            string validNumber = "456";
            string invalidNumber = "abc";

            // TryParse returns bool, outputs result via 'out' parameter
            if (int.TryParse(validNumber, out int result1))
            {
                Console.WriteLine($"TryParse(\"{validNumber}\") succeeded: {result1}");
            }

            if (int.TryParse(invalidNumber, out int result2))
            {
                Console.WriteLine($"TryParse(\"{invalidNumber}\") succeeded: {result2}");
            }
            else
            {
                Console.WriteLine($"TryParse(\"{invalidNumber}\") failed! result2 = {result2} (default)");
            }

            // Practical example: User input
            Console.WriteLine("\n[Practical: Validating User Input]");
            string userInput = "25";
            if (int.TryParse(userInput, out int age) && age > 0 && age < 150)
            {
                Console.WriteLine($"Valid age: {age}");
            }
            else
            {
                Console.WriteLine("Invalid age input!");
            }

            // ============================================
            // SECTION 5: Convert Class
            // ============================================
            Console.WriteLine("\n--- Convert Class ---");
            Console.WriteLine("More flexible conversion with null handling\n");

            // Convert.ToInt32
            string numStr = "789";
            int converted = Convert.ToInt32(numStr);
            Console.WriteLine($"Convert.ToInt32(\"789\") = {converted}");

            // Convert handles different types
            double dbl = 99.9;
            int fromDouble = Convert.ToInt32(dbl);  // Rounds! (not truncates)
            Console.WriteLine($"Convert.ToInt32(99.9) = {fromDouble} (rounded!)");

            // Compare with casting
            Console.WriteLine($"(int)99.9 = {(int)99.9} (truncated)");
            Console.WriteLine($"Convert.ToInt32(99.9) = {Convert.ToInt32(99.9)} (rounded)");

            // Convert.ToBoolean
            Console.WriteLine($"\nConvert.ToBoolean(1) = {Convert.ToBoolean(1)}");
            Console.WriteLine($"Convert.ToBoolean(0) = {Convert.ToBoolean(0)}");

            // Convert with null (returns default, doesn't throw)
            string? nullStr = null;
            int fromNull = Convert.ToInt32(nullStr);
            Console.WriteLine($"Convert.ToInt32(null) = {fromNull} (returns 0)");

            // ============================================
            // SECTION 6: ToString()
            // ============================================
            Console.WriteLine("\n--- ToString() ---");

            int num = 42;
            double pi = 3.14159;
            bool flag = true;

            Console.WriteLine($"(42).ToString() = \"{num.ToString()}\"");
            Console.WriteLine($"(3.14159).ToString() = \"{pi.ToString()}\"");
            Console.WriteLine($"(true).ToString() = \"{flag.ToString()}\"");

            // Format specifiers
            Console.WriteLine("\n[Format Specifiers]");
            double money = 1234.5;
            Console.WriteLine($"Currency: {money.ToString("C")}");     // $1,234.50
            Console.WriteLine($"Fixed 2: {money.ToString("F2")}");     // 1234.50
            Console.WriteLine($"Number: {money.ToString("N0")}");      // 1,235

            int hex = 255;
            Console.WriteLine($"Hex: {hex.ToString("X")}");            // FF

            // ============================================
            // SECTION 7: Checked and Unchecked
            // ============================================
            Console.WriteLine("\n--- Checked and Unchecked ---");

            // Unchecked (default): Silent overflow
            unchecked
            {
                int max = int.MaxValue;
                int overflow2 = max + 1;
                Console.WriteLine($"[unchecked] int.MaxValue + 1 = {overflow2}");
            }

            // Checked: Throws OverflowException
            Console.WriteLine("[checked] Would throw OverflowException on overflow");
            // checked
            // {
            //     int max = int.MaxValue;
            //     int overflow = max + 1;  // Throws!
            // }

            // ============================================
            // SECTION 8: Type Conversion Summary
            // ============================================
            Console.WriteLine("\n--- Conversion Method Comparison ---");
            Console.WriteLine("╔═══════════════╦═══════════════════════════════════════╗");
            Console.WriteLine("║ Method        ║ Behavior                              ║");
            Console.WriteLine("╠═══════════════╬═══════════════════════════════════════╣");
            Console.WriteLine("║ (int)         ║ Truncates, may overflow silently      ║");
            Console.WriteLine("║ int.Parse     ║ Throws exception on invalid input     ║");
            Console.WriteLine("║ int.TryParse  ║ Returns false on invalid, no throw    ║");
            Console.WriteLine("║ Convert.ToInt ║ Rounds, handles null (returns 0)      ║");
            Console.WriteLine("╚═══════════════╩═══════════════════════════════════════╝");

            Console.WriteLine("\n=== End of Lesson 4 ===");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
