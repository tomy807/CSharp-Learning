// ============================================
// Lesson 6: Switch Statements and Pattern Matching
// ============================================

using System;

namespace Lesson06
{
    public class Lesson
    {
        public static void Run()
        {
            Console.WriteLine("=== LESSON 6: Switch Statements & Pattern Matching ===\n");

            // ============================================
            // SECTION 1: Basic Switch Statement
            // ============================================
            Console.WriteLine("--- Basic Switch Statement ---");

            int dayNumber = 3;

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                case 7:  // Fall-through: multiple cases, same code
                    Console.WriteLine("Weekend!");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            // ============================================
            // SECTION 2: Switch with Strings
            // ============================================
            Console.WriteLine("\n--- Switch with Strings ---");

            string command = "start";

            switch (command.ToLower())
            {
                case "start":
                    Console.WriteLine("Starting the application...");
                    break;
                case "stop":
                    Console.WriteLine("Stopping the application...");
                    break;
                case "restart":
                    Console.WriteLine("Restarting...");
                    break;
                default:
                    Console.WriteLine($"Unknown command: {command}");
                    break;
            }

            // ============================================
            // SECTION 3: Switch Expression (C# 8+)
            // ============================================
            Console.WriteLine("\n--- Switch Expression (Modern) ---");

            int month = 4;
            string season = month switch
            {
                12 or 1 or 2 => "Winter",
                3 or 4 or 5 => "Spring",
                6 or 7 or 8 => "Summer",
                9 or 10 or 11 => "Fall",
                _ => "Invalid month"  // _ is the default/discard pattern
            };
            Console.WriteLine($"Month {month} is in {season}");

            // Grade example
            int score = 85;
            string grade = score switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };
            Console.WriteLine($"Score {score} = Grade {grade}");

            // ============================================
            // SECTION 4: Pattern Matching with when
            // ============================================
            Console.WriteLine("\n--- Pattern Matching with 'when' ---");

            int temperature = 25;

            string weather = temperature switch
            {
                < 0 => "Freezing",
                >= 0 and < 10 => "Cold",
                >= 10 and < 20 => "Cool",
                >= 20 and < 30 => "Warm",
                _ => "Hot"  // >= 30
            };
            Console.WriteLine($"{temperature}°C is {weather}");

            // with 'when' clause
            int value = 15;
            switch (value)
            {
                case int n when n < 0:
                    Console.WriteLine("Negative");
                    break;
                case int n when n == 0:
                    Console.WriteLine("Zero");
                    break;
                case int n when n > 0 && n <= 10:
                    Console.WriteLine("Small positive");
                    break;
                case int n when n > 10:
                    Console.WriteLine("Large positive");
                    break;
            }

            // ============================================
            // SECTION 5: Type Pattern Matching
            // ============================================
            Console.WriteLine("\n--- Type Pattern Matching ---");

            object obj = "Hello, World!";

            switch (obj)
            {
                case int i:
                    Console.WriteLine($"It's an int: {i}");
                    break;
                case string s:
                    Console.WriteLine($"It's a string: {s}");
                    break;
                case double d:
                    Console.WriteLine($"It's a double: {d}");
                    break;
                case null:
                    Console.WriteLine("It's null");
                    break;
                default:
                    Console.WriteLine($"Unknown type: {obj.GetType().Name}");
                    break;
            }

            // Type pattern with switch expression
            object data = 42;
            string description = data switch
            {
                int n => $"Integer: {n}",
                string s => $"String: {s}",
                double d => $"Double: {d}",
                null => "Null value",
                _ => $"Other: {data}"
            };
            Console.WriteLine(description);

            // ============================================
            // SECTION 6: Property Pattern
            // ============================================
            Console.WriteLine("\n--- Property Pattern ---");

            var point = (X: 0, Y: 5);

            string position = point switch
            {
                (0, 0) => "Origin",
                (0, _) => "On Y-axis",
                (_, 0) => "On X-axis",
                (var x, var y) when x == y => "On diagonal",
                _ => "Somewhere else"
            };
            Console.WriteLine($"Point ({point.X}, {point.Y}) is: {position}");

            // ============================================
            // SECTION 7: List/Array Patterns (C# 11+)
            // ============================================
            Console.WriteLine("\n--- List Patterns (C# 11+) ---");

            int[] numbers = { 1, 2, 3 };

            string arrayDesc = numbers switch
            {
                [] => "Empty array",
                [var single] => $"Single element: {single}",
                [var first, var second] => $"Two elements: {first}, {second}",
                [var first, .., var last] => $"First: {first}, Last: {last}",
            };
            Console.WriteLine(arrayDesc);

            // ============================================
            // SECTION 8: Practical Examples
            // ============================================
            Console.WriteLine("\n--- Practical Examples ---");

            // HTTP Status Code
            int statusCode = 404;
            string statusMessage = statusCode switch
            {
                200 => "OK",
                201 => "Created",
                400 => "Bad Request",
                401 => "Unauthorized",
                403 => "Forbidden",
                404 => "Not Found",
                500 => "Internal Server Error",
                _ => $"Unknown status: {statusCode}"
            };
            Console.WriteLine($"HTTP {statusCode}: {statusMessage}");

            // Calculator operation
            char op = '+';
            double a = 10, b = 3;
            double result = op switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => b != 0 ? a / b : double.NaN,
                '%' => a % b,
                _ => double.NaN
            };
            Console.WriteLine($"{a} {op} {b} = {result}");

            // ============================================
            // SECTION 9: Switch vs If-Else
            // ============================================
            Console.WriteLine("\n--- When to Use Switch vs If-Else ---");
            Console.WriteLine("Use SWITCH when:");
            Console.WriteLine("  - Comparing one value against many constants");
            Console.WriteLine("  - Pattern matching on types");
            Console.WriteLine("  - Clean, readable multiple-choice logic");
            Console.WriteLine("\nUse IF-ELSE when:");
            Console.WriteLine("  - Complex conditions with multiple variables");
            Console.WriteLine("  - Range checks (though switch expressions work too)");
            Console.WriteLine("  - Boolean logic with AND/OR");

            Console.WriteLine("\n=== End of Lesson 6 ===");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
