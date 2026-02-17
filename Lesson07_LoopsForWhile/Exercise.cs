// ============================================
// Lesson 7 Exercise: for and while Loops
// ============================================

using System;

namespace Lesson07
{
    public class Exercise
    {
        public static void Run()
        {
            Console.WriteLine("=== LESSON 7 EXERCISE ===\n");

            // ============================================
            // EXERCISE 1: Count Up
            // ============================================
            Console.WriteLine("--- Exercise 1: Count Up ---");
            // TODO: Use for loop to print numbers 1 to 10


            // ============================================
            // EXERCISE 2: Count Down
            // ============================================
            Console.WriteLine("\n--- Exercise 2: Count Down ---");
            // TODO: Use for loop to print 10 to 1


            // ============================================
            // EXERCISE 3: Even Numbers
            // ============================================
            Console.WriteLine("\n--- Exercise 3: Even Numbers ---");
            // TODO: Print even numbers from 2 to 20


            // ============================================
            // EXERCISE 4: Sum of Numbers
            // ============================================
            Console.WriteLine("\n--- Exercise 4: Sum of Numbers ---");
            // TODO: Calculate and print sum of 1 to 100


            // ============================================
            // EXERCISE 5: Factorial
            // ============================================
            Console.WriteLine("\n--- Exercise 5: Factorial ---");
            int n = 5;
            // TODO: Calculate factorial of n (5! = 5*4*3*2*1 = 120)


            // ============================================
            // EXERCISE 6: Array Sum
            // ============================================
            Console.WriteLine("\n--- Exercise 6: Array Sum ---");
            int[] numbers = { 10, 20, 30, 40, 50 };
            // TODO: Calculate sum of all elements using for loop


            // ============================================
            // EXERCISE 7: Find Maximum
            // ============================================
            Console.WriteLine("\n--- Exercise 7: Find Maximum ---");
            int[] values = { 23, 67, 12, 89, 45, 34 };
            // TODO: Find and print the maximum value


            // ============================================
            // EXERCISE 8: Reverse String
            // ============================================
            Console.WriteLine("\n--- Exercise 8: Reverse String ---");
            string original = "Hello";
            // TODO: Print the string reversed (olleH)


            // ============================================
            // EXERCISE 9: Multiplication Table
            // ============================================
            Console.WriteLine("\n--- Exercise 9: Multiplication Table ---");
            int num = 7;
            // TODO: Print multiplication table for 7 (7x1=7, 7x2=14, ... 7x10=70)


            // ============================================
            // EXERCISE 10: while Loop - Divide
            // ============================================
            Console.WriteLine("\n--- Exercise 10: Divide Until Small ---");
            double value = 1000;
            // TODO: Keep dividing by 2 until value < 1, count iterations


            // ============================================
            // EXERCISE 11: do-while - Guess Number
            // ============================================
            Console.WriteLine("\n--- Exercise 11: Guessing Game (Simulation) ---");
            int secretNumber = 7;
            int guess = 0;
            int attempts = 0;
            // TODO: Use do-while to simulate guessing
            // Increment guess each iteration until it equals secretNumber


            // ============================================
            // EXERCISE 12: Nested Loop - Rectangle
            // ============================================
            Console.WriteLine("\n--- Exercise 12: Rectangle Pattern ---");
            int width = 5, height = 3;
            // TODO: Print a rectangle of asterisks
            // *****
            // *****
            // *****


            // ============================================
            // BONUS: Triangle Pattern
            // ============================================
            Console.WriteLine("\n--- BONUS: Triangle Pattern ---");
            int rows = 5;
            // TODO: Print a right triangle
            // *
            // **
            // ***
            // ****
            // *****


            // ============================================
            // CHALLENGE: Prime Number Checker
            // ============================================
            Console.WriteLine("\n--- CHALLENGE: Prime Numbers ---");
            // TODO: Print all prime numbers between 2 and 50
            // A prime number is only divisible by 1 and itself


            // ============================================
            // CHALLENGE: FizzBuzz
            // ============================================
            Console.WriteLine("\n--- CHALLENGE: FizzBuzz ---");
            // TODO: Print numbers 1-30, but:
            // - If divisible by 3, print "Fizz"
            // - If divisible by 5, print "Buzz"
            // - If divisible by both, print "FizzBuzz"


            Console.WriteLine("\n=== End of Exercise 7 ===");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
