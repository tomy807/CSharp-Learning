// ============================================
// Lesson 4 Exercise: Type Conversion Practice
// ============================================

using System;

namespace Lesson04
{
    public class Exercise
    {
        public static void Run()
        {
            Console.WriteLine("=== LESSON 4 EXERCISE ===\n");

            // ============================================
            // EXERCISE 1: Implicit Conversion
            // ============================================
            Console.WriteLine("--- Exercise 1: Implicit Conversion ---");
            // TODO: Create these conversions (no casting needed)
            // 1. int 100 -> long
            // 2. char 'Z' -> int (get ASCII code)
            // 3. float 2.5f -> double


            // ============================================
            // EXERCISE 2: Explicit Casting
            // ============================================
            Console.WriteLine("\n--- Exercise 2: Explicit Casting ---");
            // TODO: Cast these values
            // 1. double 78.9 -> int (what happens to .9?)
            // 2. int 65 -> char (what letter is this?)
            // 3. int 1000 -> byte (what's the result? why?)


            // ============================================
            // EXERCISE 3: Parse Methods
            // ============================================
            Console.WriteLine("\n--- Exercise 3: Parse Methods ---");
            string strNumber = "42";
            string strDecimal = "3.14";
            string strBool = "False";
            // TODO: Parse each string to its appropriate type
            // and print the results


            // ============================================
            // EXERCISE 4: TryParse Validation
            // ============================================
            Console.WriteLine("\n--- Exercise 4: TryParse Validation ---");
            string[] inputs = { "123", "45.6", "abc", "", "-789" };
            // TODO: Loop through inputs and use int.TryParse
            // Print whether each parse succeeded or failed


            // ============================================
            // EXERCISE 5: Convert Class
            // ============================================
            Console.WriteLine("\n--- Exercise 5: Convert Class ---");
            // TODO: Use Convert class for these:
            // 1. Convert 99.5 to int (note: rounds!)
            // 2. Convert 99.4 to int (note: rounds!)
            // 3. Convert 1 to bool
            // 4. Convert 0 to bool


            // ============================================
            // EXERCISE 6: Cast vs Convert
            // ============================================
            Console.WriteLine("\n--- Exercise 6: Cast vs Convert ---");
            double value = 2.7;
            // TODO: Show the difference:
            // 1. (int)2.7 = ?
            // 2. Convert.ToInt32(2.7) = ?
            // Explain why they're different


            // ============================================
            // EXERCISE 7: ToString with Formats
            // ============================================
            Console.WriteLine("\n--- Exercise 7: ToString Formats ---");
            double price = 1234.567;
            int bigNum = 1000000;
            // TODO: Format and print:
            // 1. price as currency (C)
            // 2. price with 2 decimal places (F2)
            // 3. bigNum with thousands separator (N0)


            // ============================================
            // EXERCISE 8: User Input Validation
            // ============================================
            Console.WriteLine("\n--- Exercise 8: Input Validation ---");
            // TODO: Create a method that:
            // 1. Asks user for their age
            // 2. Uses TryParse to validate
            // 3. Checks if age is between 1 and 120
            // 4. Prints appropriate message


            // ============================================
            // BONUS: Temperature Converter
            // ============================================
            Console.WriteLine("\n--- BONUS: Temperature Converter ---");
            // TODO: Create a temperature converter:
            // 1. Ask user for temperature in Celsius (as string)
            // 2. Parse to double using TryParse
            // 3. If valid, convert to Fahrenheit: F = C * 9/5 + 32
            // 4. Print result with 1 decimal place


            // ============================================
            // CHALLENGE: Safe Calculator
            // ============================================
            Console.WriteLine("\n--- CHALLENGE: Safe Calculator ---");
            // TODO: Create a safe calculator that:
            // 1. Takes two number strings as input
            // 2. Validates both using TryParse
            // 3. If both valid, performs +, -, *, /
            // 4. Handles division by zero
            // 5. Handles invalid input gracefully


            Console.WriteLine("\n=== End of Exercise 4 ===");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
