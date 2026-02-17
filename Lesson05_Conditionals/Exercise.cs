// ============================================
// Lesson 5 Exercise: Conditional Statements
// ============================================

using System;

namespace Lesson05
{
    public class Exercise
    {
        public static void Run()
        {
            Console.WriteLine("=== LESSON 5 EXERCISE ===\n");

            // ============================================
            // EXERCISE 1: Basic if
            // ============================================
            Console.WriteLine("--- Exercise 1: Basic if ---");
            int number = 15;
            // TODO: Print "Positive" if number > 0


            // ============================================
            // EXERCISE 2: if-else
            // ============================================
            Console.WriteLine("\n--- Exercise 2: if-else ---");
            int age = 16;
            // TODO: Print "Can vote" if age >= 18, else "Cannot vote"


            // ============================================
            // EXERCISE 3: if-else if-else
            // ============================================
            Console.WriteLine("\n--- Exercise 3: Grade Calculator ---");
            int score = 78;
            // TODO: Print grade based on score
            // A: 90+, B: 80+, C: 70+, D: 60+, F: below 60


            // ============================================
            // EXERCISE 4: Logical AND
            // ============================================
            Console.WriteLine("\n--- Exercise 4: Logical AND ---");
            int userAge = 25;
            bool hasTicket = true;
            // TODO: Print "Entry allowed" only if age >= 18 AND hasTicket


            // ============================================
            // EXERCISE 5: Logical OR
            // ============================================
            Console.WriteLine("\n--- Exercise 5: Logical OR ---");
            bool isStudent = true;
            bool isSenior = false;
            // TODO: Print "Discount available" if isStudent OR isSenior


            // ============================================
            // EXERCISE 6: Nested Conditions
            // ============================================
            Console.WriteLine("\n--- Exercise 6: Nested Conditions ---");
            bool isWeekend = true;
            bool isHoliday = false;
            bool hasWork = false;
            // TODO: If weekend or holiday, check if hasWork
            // Print appropriate message for each case


            // ============================================
            // EXERCISE 7: Number Classification
            // ============================================
            Console.WriteLine("\n--- Exercise 7: Number Classification ---");
            int num = -5;
            // TODO: Print "Positive", "Negative", or "Zero"


            // ============================================
            // EXERCISE 8: Ternary Operator
            // ============================================
            Console.WriteLine("\n--- Exercise 8: Ternary Operator ---");
            int temperature = 30;
            // TODO: Use ternary to set weather = "Hot" if temp >= 25, else "Cool"


            // ============================================
            // EXERCISE 9: String Comparison
            // ============================================
            Console.WriteLine("\n--- Exercise 9: String Comparison ---");
            string password = "Secret123";
            string input = "secret123";
            // TODO: Check if input matches password (case-sensitive first, then case-insensitive)


            // ============================================
            // EXERCISE 10: Range Check
            // ============================================
            Console.WriteLine("\n--- Exercise 10: Range Check ---");
            int percentage = 85;
            // TODO: Check if percentage is valid (0-100)
            // If valid, print the percentage; if not, print error


            // ============================================
            // BONUS: Login Validator
            // ============================================
            Console.WriteLine("\n--- BONUS: Login Validator ---");
            string username = "admin";
            string pwd = "pass123";
            // TODO: Check:
            // 1. Username is not empty
            // 2. Password is at least 6 characters
            // 3. Username is not "guest"
            // Print appropriate messages for each validation


            // ============================================
            // CHALLENGE: BMI Calculator
            // ============================================
            Console.WriteLine("\n--- CHALLENGE: BMI Calculator ---");
            double weight = 70; // kg
            double height = 1.75; // meters
            // TODO: Calculate BMI = weight / (height * height)
            // Categories:
            // < 18.5: Underweight
            // 18.5-24.9: Normal
            // 25-29.9: Overweight
            // >= 30: Obese


            Console.WriteLine("\n=== End of Exercise 5 ===");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
