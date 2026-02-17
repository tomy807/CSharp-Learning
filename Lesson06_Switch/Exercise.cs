// ============================================
// Lesson 6 Exercise: Switch Statements
// ============================================

using System;

namespace Lesson06
{
    public class Exercise
    {
        public static void Run()
        {
            Console.WriteLine("=== LESSON 6 EXERCISE ===\n");

            // ============================================
            // EXERCISE 1: Day of Week
            // ============================================
            Console.WriteLine("--- Exercise 1: Day of Week ---");
            int day = 5;
            // TODO: Use switch to print day name (1=Monday, 7=Sunday)


            // ============================================
            // EXERCISE 2: Month Days
            // ============================================
            Console.WriteLine("\n--- Exercise 2: Month Days ---");
            int month = 2;
            // TODO: Use switch to print number of days in month
            // (Assume non-leap year: Feb = 28)


            // ============================================
            // EXERCISE 3: Grade Calculator (Switch Expression)
            // ============================================
            Console.WriteLine("\n--- Exercise 3: Grade Calculator ---");
            int score = 85;
            // TODO: Use switch expression to get grade
            // A: 90+, B: 80+, C: 70+, D: 60+, F: below 60


            // ============================================
            // EXERCISE 4: Season Finder
            // ============================================
            Console.WriteLine("\n--- Exercise 4: Season Finder ---");
            int monthNum = 7;
            // TODO: Use switch expression with 'or' pattern
            // Winter: 12,1,2  Spring: 3,4,5  Summer: 6,7,8  Fall: 9,10,11


            // ============================================
            // EXERCISE 5: Calculator
            // ============================================
            Console.WriteLine("\n--- Exercise 5: Calculator ---");
            double num1 = 20, num2 = 4;
            char operation = '/';
            // TODO: Use switch expression to calculate result
            // Support: +, -, *, /, %
            // Handle division by zero


            // ============================================
            // EXERCISE 6: Traffic Light
            // ============================================
            Console.WriteLine("\n--- Exercise 6: Traffic Light ---");
            string light = "yellow";
            // TODO: Use switch to print action
            // "red" -> "Stop", "yellow" -> "Caution", "green" -> "Go"


            // ============================================
            // EXERCISE 7: Temperature Range
            // ============================================
            Console.WriteLine("\n--- Exercise 7: Temperature Range ---");
            int temp = 22;
            // TODO: Use switch expression with relational patterns
            // < 0: Freezing, 0-15: Cold, 16-25: Comfortable, > 25: Hot


            // ============================================
            // EXERCISE 8: Type Checker
            // ============================================
            Console.WriteLine("\n--- Exercise 8: Type Checker ---");
            object value = 3.14;
            // TODO: Use type pattern matching to identify the type
            // Print "Integer: {value}" or "String: {value}" etc.


            // ============================================
            // EXERCISE 9: HTTP Status
            // ============================================
            Console.WriteLine("\n--- Exercise 9: HTTP Status ---");
            int status = 201;
            // TODO: Use switch expression to get status category
            // 200-299: "Success", 300-399: "Redirect"
            // 400-499: "Client Error", 500-599: "Server Error"


            // ============================================
            // EXERCISE 10: Command Parser
            // ============================================
            Console.WriteLine("\n--- Exercise 10: Command Parser ---");
            string command = "HELP";
            // TODO: Use switch with ToLower() to handle commands
            // "help" -> show help, "exit" -> exit message
            // "version" -> show version, default -> unknown command


            // ============================================
            // BONUS: Rock Paper Scissors
            // ============================================
            Console.WriteLine("\n--- BONUS: Rock Paper Scissors ---");
            string player = "rock";
            string computer = "scissors";
            // TODO: Use switch to determine winner
            // rock beats scissors, scissors beats paper, paper beats rock


            // ============================================
            // CHALLENGE: Tuple Pattern Matching
            // ============================================
            Console.WriteLine("\n--- CHALLENGE: Point Classifier ---");
            int x = 0, y = 5;
            // TODO: Use tuple pattern matching to classify point
            // (0,0) -> "Origin"
            // (0,_) -> "Y-axis"
            // (_,0) -> "X-axis"
            // (x,y) where x==y -> "Diagonal"
            // _ -> "Other"


            Console.WriteLine("\n=== End of Exercise 6 ===");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
