// ============================================
// Lesson 8: foreach and Loop Control
// ============================================

using System;
using System.Collections.Generic;

namespace Lesson08
{
    public class Lesson
    {
        public static void Run()
        {
            Console.WriteLine("=== LESSON 8: foreach and Loop Control ===\n");

            // ============================================
            // SECTION 1: foreach Loop
            // ============================================
            Console.WriteLine("--- foreach Loop ---");

            string[] colors = { "Red", "Green", "Blue", "Yellow" };

            Console.WriteLine("Colors:");
            foreach (string color in colors)
            {
                Console.WriteLine($"  {color}");
            }

            // foreach with numbers
            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"Sum: {sum}");

            // ============================================
            // SECTION 2: foreach with Different Collections
            // ============================================
            Console.WriteLine("\n--- foreach with Collections ---");

            // List
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
            Console.WriteLine("Fruits (List):");
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"  {fruit}");
            }

            // Dictionary
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                { "Alice", 25 },
                { "Bob", 30 },
                { "Charlie", 35 }
            };
            Console.WriteLine("Ages (Dictionary):");
            foreach (KeyValuePair<string, int> pair in ages)
            {
                Console.WriteLine($"  {pair.Key}: {pair.Value}");
            }

            // With var (type inference)
            Console.WriteLine("Using var:");
            foreach (var pair in ages)
            {
                Console.WriteLine($"  {pair.Key} is {pair.Value} years old");
            }

            // ============================================
            // SECTION 3: foreach with Strings
            // ============================================
            Console.WriteLine("\n--- foreach with Strings ---");

            string word = "Hello";
            Console.Write("Characters: ");
            foreach (char c in word)
            {
                Console.Write($"'{c}' ");
            }
            Console.WriteLine();

            // Count vowels
            string text = "Programming is fun";
            int vowelCount = 0;
            foreach (char c in text.ToLower())
            {
                if ("aeiou".Contains(c))
                    vowelCount++;
            }
            Console.WriteLine($"Vowels in \"{text}\": {vowelCount}");

            // ============================================
            // SECTION 4: break Statement
            // ============================================
            Console.WriteLine("\n--- break Statement ---");
            Console.WriteLine("Exits the loop immediately");

            // Find first negative
            int[] values = { 5, 3, 8, -2, 9, -5, 1 };
            Console.Write("Array: ");
            foreach (int v in values) Console.Write($"{v} ");
            Console.WriteLine();

            foreach (int v in values)
            {
                if (v < 0)
                {
                    Console.WriteLine($"First negative found: {v}");
                    break;  // Exit loop immediately
                }
            }

            // Search example
            string[] names = { "Alice", "Bob", "Charlie", "David" };
            string target = "Charlie";
            bool found = false;
            foreach (string name in names)
            {
                if (name == target)
                {
                    found = true;
                    Console.WriteLine($"Found '{target}'!");
                    break;
                }
            }
            if (!found) Console.WriteLine($"'{target}' not found");

            // ============================================
            // SECTION 5: continue Statement
            // ============================================
            Console.WriteLine("\n--- continue Statement ---");
            Console.WriteLine("Skips current iteration, continues to next");

            // Skip negative numbers
            int[] mixedNumbers = { 1, -2, 3, -4, 5, -6, 7 };
            Console.Write("Positive only: ");
            foreach (int n in mixedNumbers)
            {
                if (n < 0)
                    continue;  // Skip this iteration
                Console.Write($"{n} ");
            }
            Console.WriteLine();

            // Skip even numbers
            Console.Write("Odd numbers 1-10: ");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // ============================================
            // SECTION 6: break vs continue
            // ============================================
            Console.WriteLine("\n--- break vs continue ---");

            Console.WriteLine("With break (stops at 5):");
            Console.Write("  ");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5) break;
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("With continue (skips 5):");
            Console.Write("  ");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5) continue;
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // ============================================
            // SECTION 7: Nested Loops with break/continue
            // ============================================
            Console.WriteLine("\n--- Nested Loops ---");

            // break only exits innermost loop
            Console.WriteLine("break in nested loop:");
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"  i={i}: ");
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 3) break;  // Only breaks inner loop
                    Console.Write($"j={j} ");
                }
                Console.WriteLine();
            }

            // ============================================
            // SECTION 8: return in Loops
            // ============================================
            Console.WriteLine("\n--- return in Loops ---");
            Console.WriteLine("return exits the entire method, not just the loop");
            Console.WriteLine("See FindFirst example in code comments");
            // static int FindFirst(int[] arr, int target)
            // {
            //     foreach (int item in arr)
            //         if (item == target) return item;  // Exits method
            //     return -1;
            // }

            // ============================================
            // SECTION 9: foreach vs for
            // ============================================
            Console.WriteLine("\n--- foreach vs for ---");
            Console.WriteLine("Use foreach when:");
            Console.WriteLine("  - You don't need the index");
            Console.WriteLine("  - You're not modifying the collection");
            Console.WriteLine("  - Reading all elements in order");
            Console.WriteLine("\nUse for when:");
            Console.WriteLine("  - You need the index");
            Console.WriteLine("  - You need to modify elements");
            Console.WriteLine("  - You need to iterate backwards");
            Console.WriteLine("  - You need to skip elements by index");

            // ============================================
            // SECTION 10: foreach Limitations
            // ============================================
            Console.WriteLine("\n--- foreach Limitations ---");

            // Cannot modify collection while iterating
            Console.WriteLine("Cannot modify collection during foreach!");
            Console.WriteLine("// foreach (var item in list)");
            Console.WriteLine("//     list.Remove(item);  // RUNTIME ERROR!");

            // Cannot modify value types
            Console.WriteLine("\nCannot modify value in foreach:");
            Console.WriteLine("// foreach (int n in numbers)");
            Console.WriteLine("//     n = n * 2;  // n is a copy, original unchanged");

            // Solution: use for loop or create new collection
            int[] original = { 1, 2, 3, 4, 5 };
            int[] doubled = new int[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                doubled[i] = original[i] * 2;
            }
            Console.Write("Doubled array: ");
            foreach (int n in doubled) Console.Write($"{n} ");
            Console.WriteLine();

            Console.WriteLine("\n=== End of Lesson 8 ===");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
