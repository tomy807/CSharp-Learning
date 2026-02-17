// ============================================
// Lesson 5: Conditional Statements
// ============================================

using System;

namespace Lesson05
{
    public class Lesson
    {
        public static void Run()
        {
            Console.WriteLine("=== LESSON 5: Conditional Statements ===\n");

            // ============================================
            // SECTION 1: Basic if Statement
            // ============================================
            Console.WriteLine("--- Basic if Statement ---");

            int age = 20;

            if (age >= 18)
            {
                Console.WriteLine($"Age {age}: You are an adult.");
            }

            // Single line (no braces needed, but recommended)
            int score = 85;
            if (score >= 60)
                Console.WriteLine($"Score {score}: You passed!");

            // ============================================
            // SECTION 2: if-else Statement
            // ============================================
            Console.WriteLine("\n--- if-else Statement ---");

            int temperature = 15;

            if (temperature >= 25)
            {
                Console.WriteLine($"{temperature}°C: It's hot!");
            }
            else
            {
                Console.WriteLine($"{temperature}°C: It's cool.");
            }

            // ============================================
            // SECTION 3: if-else if-else Chain
            // ============================================
            Console.WriteLine("\n--- if-else if-else Chain ---");

            int grade = 75;

            if (grade >= 90)
            {
                Console.WriteLine($"Grade {grade}: A - Excellent!");
            }
            else if (grade >= 80)
            {
                Console.WriteLine($"Grade {grade}: B - Good!");
            }
            else if (grade >= 70)
            {
                Console.WriteLine($"Grade {grade}: C - Average");
            }
            else if (grade >= 60)
            {
                Console.WriteLine($"Grade {grade}: D - Below Average");
            }
            else
            {
                Console.WriteLine($"Grade {grade}: F - Fail");
            }

            // ============================================
            // SECTION 4: Nested if Statements
            // ============================================
            Console.WriteLine("\n--- Nested if Statements ---");

            bool hasLicense = true;
            int driverAge = 18;

            if (driverAge >= 18)
            {
                if (hasLicense)
                {
                    Console.WriteLine("You can drive!");
                }
                else
                {
                    Console.WriteLine("You need a license first.");
                }
            }
            else
            {
                Console.WriteLine("You're too young to drive.");
            }

            // ============================================
            // SECTION 5: Logical Operators in Conditions
            // ============================================
            Console.WriteLine("\n--- Logical Operators in Conditions ---");

            int userAge = 25;
            bool isMember = true;
            decimal balance = 100m;

            // AND (&&) - both must be true
            if (userAge >= 18 && isMember)
            {
                Console.WriteLine("Adult member - full access granted.");
            }

            // OR (||) - at least one must be true
            if (isMember || balance >= 50)
            {
                Console.WriteLine("Discount available!");
            }

            // NOT (!) - inverts the condition
            bool isBlocked = false;
            if (!isBlocked)
            {
                Console.WriteLine("Account is active.");
            }

            // Combined conditions
            if ((userAge >= 18 && isMember) || balance >= 200)
            {
                Console.WriteLine("Premium features unlocked.");
            }

            // ============================================
            // SECTION 6: Comparison with Different Types
            // ============================================
            Console.WriteLine("\n--- Comparing Different Types ---");

            // String comparison
            string name = "Alice";
            if (name == "Alice")
            {
                Console.WriteLine("Hello, Alice!");
            }

            // Case-insensitive comparison
            string input = "YES";
            if (input.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("User confirmed (case-insensitive).");
            }

            // Null check
            string? nullableString = null;
            if (nullableString == null)
            {
                Console.WriteLine("String is null.");
            }

            // Better null check
            if (string.IsNullOrEmpty(nullableString))
            {
                Console.WriteLine("String is null or empty.");
            }

            // ============================================
            // SECTION 7: Ternary Operator (Conditional)
            // ============================================
            Console.WriteLine("\n--- Ternary Operator ---");

            int number = 7;
            string parity = (number % 2 == 0) ? "even" : "odd";
            Console.WriteLine($"{number} is {parity}.");

            // Nested ternary (use sparingly - can be hard to read)
            int value = 15;
            string size = value < 10 ? "small" : value < 20 ? "medium" : "large";
            Console.WriteLine($"{value} is {size}.");

            // ============================================
            // SECTION 8: Null-Conditional and Coalescing
            // ============================================
            Console.WriteLine("\n--- Null-Conditional & Coalescing ---");

            string? userName = null;

            // Null-coalescing operator (??)
            string displayName = userName ?? "Guest";
            Console.WriteLine($"Welcome, {displayName}!");

            // Null-coalescing assignment (??=)
            userName ??= "DefaultUser";
            Console.WriteLine($"Username set to: {userName}");

            // ============================================
            // SECTION 9: Common Patterns
            // ============================================
            Console.WriteLine("\n--- Common Patterns ---");

            // Range check
            int testScore = 85;
            if (testScore >= 0 && testScore <= 100)
            {
                Console.WriteLine($"Valid score: {testScore}");
            }

            // Multiple conditions
            string day = "Saturday";
            if (day == "Saturday" || day == "Sunday")
            {
                Console.WriteLine($"{day} is a weekend!");
            }

            // Guard clause (early return pattern)
            Console.WriteLine("Guard clause example - see code comments");
            // if (input == null) return; // Exit early if invalid

            // ============================================
            // SECTION 10: Best Practices
            // ============================================
            Console.WriteLine("\n--- Best Practices ---");
            Console.WriteLine("1. Always use braces {} even for single lines");
            Console.WriteLine("2. Keep conditions simple and readable");
            Console.WriteLine("3. Use early returns to reduce nesting");
            Console.WriteLine("4. Consider switch for multiple equality checks");
            Console.WriteLine("5. Use meaningful variable names in conditions");

            Console.WriteLine("\n=== End of Lesson 5 ===");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
