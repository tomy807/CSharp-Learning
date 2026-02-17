// ============================================
// Lesson 3: Operators
// ============================================

using System;

namespace Lesson03
{
    public class Lesson
    {
        public static void Run()
        {
            Console.WriteLine("=== LESSON 3: Operators ===\n");

            // ============================================
            // SECTION 1: Arithmetic Operators
            // ============================================
            Console.WriteLine("--- Arithmetic Operators ---");

            int a = 10;
            int b = 3;

            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");   // Integer division!
            Console.WriteLine($"a % b = {a % b}");

            Console.WriteLine("\n--- Integer vs Floating-Point Division ---");
            Console.WriteLine($"10 / 3 = {10 / 3}");
            Console.WriteLine($"10.0 / 3 = {10.0 / 3}");

            // ============================================
            // SECTION 2: Comparison Operators
            // ============================================
            Console.WriteLine("\n--- Comparison Operators ---");

            int x = 10;
            int y = 5;

            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine($"x == y: {x == y}");
            Console.WriteLine($"x != y: {x != y}");
            Console.WriteLine($"x > y: {x > y}");
            Console.WriteLine($"x < y: {x < y}");
            Console.WriteLine($"x >= y: {x >= y}");
            Console.WriteLine($"x <= y: {x <= y}");

            // ============================================
            // SECTION 3: Logical Operators
            // ============================================
            Console.WriteLine("\n--- Logical Operators ---");

            bool isAdult = true;
            bool hasLicense = false;

            Console.WriteLine($"isAdult = {isAdult}, hasLicense = {hasLicense}");
            Console.WriteLine($"isAdult && hasLicense: {isAdult && hasLicense}");
            Console.WriteLine($"isAdult || hasLicense: {isAdult || hasLicense}");
            Console.WriteLine($"!isAdult: {!isAdult}");

            // ============================================
            // SECTION 4: Assignment Operators
            // ============================================
            Console.WriteLine("\n--- Assignment Operators ---");

            int score = 100;
            Console.WriteLine($"Initial score: {score}");

            score += 10;
            Console.WriteLine($"score += 10: {score}");

            score -= 5;
            Console.WriteLine($"score -= 5: {score}");

            score *= 2;
            Console.WriteLine($"score *= 2: {score}");

            score /= 3;
            Console.WriteLine($"score /= 3: {score}");

            // ============================================
            // SECTION 5: Increment and Decrement
            // ============================================
            Console.WriteLine("\n--- Increment (++) and Decrement (--) ---");

            int n = 5;
            Console.WriteLine($"n = {n}");
            Console.WriteLine($"n++: {n++}");  // Post: prints 5, then n becomes 6
            Console.WriteLine($"n is now: {n}");
            Console.WriteLine($"++n: {++n}");  // Pre: n becomes 7, then prints 7

            // ============================================
            // SECTION 6: Ternary Operator
            // ============================================
            Console.WriteLine("\n--- Ternary Operator (? :) ---");

            int age = 17;
            string status = age >= 18 ? "Adult" : "Minor";
            Console.WriteLine($"Age {age}: {status}");

            // ============================================
            // SECTION 7: Null Operators
            // ============================================
            Console.WriteLine("\n--- Null Operators ---");

            string? userName = null;
            string displayName = userName ?? "Guest";
            Console.WriteLine($"userName is null, displayName: {displayName}");

            // ============================================
            // SECTION 8: Operator Precedence
            // ============================================
            Console.WriteLine("\n--- Operator Precedence ---");

            int result1 = 5 + 3 * 2;
            int result2 = (5 + 3) * 2;
            Console.WriteLine($"5 + 3 * 2 = {result1}");
            Console.WriteLine($"(5 + 3) * 2 = {result2}");

            Console.WriteLine("\n=== End of Lesson 3 ===");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
