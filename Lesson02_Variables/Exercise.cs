// ============================================
// Lesson 2 Exercise: Variables and Data Types
// ============================================

using System;

namespace Lesson02
{
    public class Exercise
    {
        public static void Run()
        {
            Console.WriteLine("=== LESSON 2 EXERCISE ===\n");

            // ============================================
            // EXERCISE 1: Declare Variables
            // ============================================
            Console.WriteLine("--- Exercise 1: Basic Variables ---");

            // TODO: Declare an int variable named 'age' with value 25


            // TODO: Declare a double variable named 'height' with value 1.75


            // TODO: Declare a string variable named 'city' with your city name


            // TODO: Declare a bool variable named 'isStudent' with value true


            // TODO: Print all variables using string interpolation
            // Console.WriteLine($"Age: {age}, Height: {height}m, City: {city}, Student: {isStudent}");


            // ============================================
            // EXERCISE 2: Choose the Right Type
            // ============================================
            Console.WriteLine("\n--- Exercise 2: Choose the Right Type ---");

            // TODO: Declare a variable for storing someone's first name


            // TODO: Declare a variable for storing a product price ($19.99)
            // Hint: What type is best for money?


            // TODO: Declare a variable for storing the number of items in a cart


            // TODO: Declare a variable for storing whether a user is logged in


            // TODO: Declare a variable for storing a single letter grade ('A', 'B', 'C', etc.)


            // ============================================
            // EXERCISE 3: Constants
            // ============================================
            Console.WriteLine("\n--- Exercise 3: Constants ---");

            // TODO: Declare a constant for PI (3.14159)


            // TODO: Calculate the area of a circle with radius 5
            // Formula: area = PI * radius * radius


            // ============================================
            // EXERCISE 4: String Practice
            // ============================================
            Console.WriteLine("\n--- Exercise 4: String Practice ---");

            string firstName = "John";
            string lastName = "Doe";

            // TODO: Create a 'fullName' variable by concatenating firstName and lastName


            // TODO: Print the full name and its length


            // TODO: Create a file path using a verbatim string (@"...")


            // ============================================
            // EXERCISE 5: Using var
            // ============================================
            Console.WriteLine("\n--- Exercise 5: Using var ---");

            // TODO: Rewrite these using 'var' instead of explicit types
            // int count = 10;
            // double price = 29.99;
            // string message = "Hello";


            Console.WriteLine("\n=== End of Exercise 2 ===");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
