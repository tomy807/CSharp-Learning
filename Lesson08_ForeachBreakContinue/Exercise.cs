// ============================================
// Lesson 8 Exercise: foreach and Loop Control
// ============================================

using System;
using System.Collections.Generic;

namespace Lesson08
{
    public class Exercise
    {
        public static void Run()
        {
            Console.WriteLine("=== LESSON 8 EXERCISE ===\n");

            // ============================================
            // EXERCISE 1: Basic foreach
            // ============================================
            Console.WriteLine("--- Exercise 1: Basic foreach ---");
            string[] animals = { "Dog", "Cat", "Bird", "Fish" };
            // TODO: Print each animal using foreach


            // ============================================
            // EXERCISE 2: Sum with foreach
            // ============================================
            Console.WriteLine("\n--- Exercise 2: Sum with foreach ---");
            int[] scores = { 85, 92, 78, 95, 88 };
            // TODO: Calculate and print the sum using foreach


            // ============================================
            // EXERCISE 3: foreach with String
            // ============================================
            Console.WriteLine("\n--- Exercise 3: Character Count ---");
            string sentence = "Hello World";
            // TODO: Count the number of spaces using foreach


            // ============================================
            // EXERCISE 4: foreach with List
            // ============================================
            Console.WriteLine("\n--- Exercise 4: List Iteration ---");
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            // TODO: Print each number multiplied by 2


            // ============================================
            // EXERCISE 5: foreach with Dictionary
            // ============================================
            Console.WriteLine("\n--- Exercise 5: Dictionary ---");
            Dictionary<string, double> prices = new Dictionary<string, double>
            {
                { "Apple", 1.50 },
                { "Banana", 0.75 },
                { "Orange", 2.00 }
            };
            // TODO: Print each item and its price, then calculate total


            // ============================================
            // EXERCISE 6: break - Find First
            // ============================================
            Console.WriteLine("\n--- Exercise 6: Find First ---");
            int[] values = { 2, 4, 6, 7, 8, 10, 12 };
            // TODO: Find and print the first odd number, then break


            // ============================================
            // EXERCISE 7: break - Search
            // ============================================
            Console.WriteLine("\n--- Exercise 7: Search ---");
            string[] cities = { "Tokyo", "Paris", "London", "Seoul", "Berlin" };
            string searchCity = "Seoul";
            // TODO: Search for the city and print if found
            // Use break to stop searching once found


            // ============================================
            // EXERCISE 8: continue - Skip
            // ============================================
            Console.WriteLine("\n--- Exercise 8: Skip Negatives ---");
            int[] mixed = { 5, -3, 8, -1, 4, -7, 2 };
            // TODO: Print only positive numbers using continue


            // ============================================
            // EXERCISE 9: continue - Filter
            // ============================================
            Console.WriteLine("\n--- Exercise 9: Skip Short Words ---");
            string[] words = { "I", "am", "learning", "C#", "programming" };
            // TODO: Print only words with length > 2


            // ============================================
            // EXERCISE 10: Combined break and continue
            // ============================================
            Console.WriteLine("\n--- Exercise 10: Process Until Zero ---");
            int[] data = { 3, 7, 2, 0, 5, 8, 1 };
            // TODO: Sum positive numbers, skip negatives, stop at zero


            // ============================================
            // EXERCISE 11: Nested Loop with break
            // ============================================
            Console.WriteLine("\n--- Exercise 11: Find in 2D ---");
            int[,] grid = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            int target = 5;
            // TODO: Find the position of target in the grid
            // Print "Found at row X, col Y" and break


            // ============================================
            // BONUS: Count Vowels
            // ============================================
            Console.WriteLine("\n--- BONUS: Count Vowels ---");
            string text = "The quick brown fox jumps over the lazy dog";
            // TODO: Count each vowel (a, e, i, o, u) separately
            // Print count for each vowel


            // ============================================
            // CHALLENGE: Word Finder
            // ============================================
            Console.WriteLine("\n--- CHALLENGE: Word Finder ---");
            string[] dictionary = { "apple", "banana", "cherry", "date", "elderberry" };
            char startsWith = 'c';
            // TODO: Find all words starting with the given letter
            // Use continue to skip non-matching words


            // ============================================
            // CHALLENGE: Prime Filter
            // ============================================
            Console.WriteLine("\n--- CHALLENGE: Prime Filter ---");
            // TODO: Print all prime numbers from 2 to 30
            // Use continue to skip non-prime numbers
            // Hint: A number is prime if it's not divisible by any number
            // from 2 to its square root


            Console.WriteLine("\n=== End of Exercise 8 ===");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
