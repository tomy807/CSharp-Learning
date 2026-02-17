// ============================================
// Lesson 3 Exercise: Operators Practice
// ============================================

using System;

namespace Lesson03
{
    public class Exercise
    {
        public static void Run()
        {
            Console.WriteLine("=== LESSON 3 EXERCISE ===\n");

            // ============================================
            // EXERCISE 1: Basic Arithmetic
            // ============================================
            Console.WriteLine("--- Exercise 1: Basic Arithmetic ---");
            // TODO: Calculate and print:
            // - Sum of 25 and 17
            // - Product of 8 and 12
            // - Remainder of 50 divided by 8


            // ============================================
            // EXERCISE 2: Division Types
            // ============================================
            Console.WriteLine("\n--- Exercise 2: Division Types ---");
            int num1 = 7, num2 = 2;
            // TODO: Print integer division result
            // TODO: Print floating-point division result (get 3.5)


            // ============================================
            // EXERCISE 3: Comparison
            // ============================================
            Console.WriteLine("\n--- Exercise 3: Comparison ---");
            int a = 15, b = 20;
            // TODO: Print if a == b
            // TODO: Print if a > b
            // TODO: Print if a <= b


            // ============================================
            // EXERCISE 4: Logical Operators
            // ============================================
            Console.WriteLine("\n--- Exercise 4: Voting Eligibility ---");
            // A person can vote if: age >= 18 AND isCitizen == true
            // TODO: Check these cases:
            // Person 1: age = 25, citizen = true
            // Person 2: age = 16, citizen = true
            // Person 3: age = 30, citizen = false


            // ============================================
            // EXERCISE 5: Assignment Operators
            // ============================================
            Console.WriteLine("\n--- Exercise 5: Score Calculation ---");
            // TODO: Start with score = 100
            // Apply: += 50, -= 30, *= 2, /= 4
            // Print after each operation


            // ============================================
            // EXERCISE 6: Pre vs Post Increment
            // ============================================
            Console.WriteLine("\n--- Exercise 6: Increment ---");
            // TODO: Predict then verify:
            // int x = 10;
            // Console.WriteLine(x++);  // ?
            // Console.WriteLine(++x);  // ?


            // ============================================
            // EXERCISE 7: Ternary Operator
            // ============================================
            Console.WriteLine("\n--- Exercise 7: Ternary ---");
            // TODO: Use ternary to:
            // 1. Print "Positive" or "Negative" for number = -5
            // 2. Find max of two numbers (8 and 12)


            // ============================================
            // EXERCISE 8: Precedence
            // ============================================
            Console.WriteLine("\n--- Exercise 8: Precedence Quiz ---");
            // TODO: Calculate WITHOUT running first, then verify:
            // 2 + 3 * 4 = ?
            // (2 + 3) * 4 = ?
            // true || false && false = ?


            // ============================================
            // BONUS: Grade Calculator
            // ============================================
            Console.WriteLine("\n--- BONUS: Grade Calculator ---");
            // TODO: Given score (0-100), determine grade using ternary:
            // A: 90+, B: 80+, C: 70+, D: 60+, F: below 60
            int testScore = 85;
            // string grade = ...


            Console.WriteLine("\n=== End of Exercise 3 ===");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
