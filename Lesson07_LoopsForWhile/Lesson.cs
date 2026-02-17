// ============================================
// Lesson 7: Loops - for and while
// ============================================

using System;

namespace Lesson07
{
    public class Lesson
    {
        public static void Run()
        {
            Console.WriteLine("=== LESSON 7: Loops - for and while ===\n");

            // ============================================
            // SECTION 1: Basic for Loop
            // ============================================
            Console.WriteLine("--- Basic for Loop ---");

            // for (initializer; condition; iterator)
            Console.Write("Count 1-5: ");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // Counting down
            Console.Write("Count 5-1: ");
            for (int i = 5; i >= 1; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // Step by 2
            Console.Write("Even numbers 2-10: ");
            for (int i = 2; i <= 10; i += 2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // ============================================
            // SECTION 2: for Loop with Arrays
            // ============================================
            Console.WriteLine("\n--- for Loop with Arrays ---");

            string[] fruits = { "Apple", "Banana", "Cherry", "Date" };

            Console.WriteLine("Fruits:");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"  [{i}] {fruits[i]}");
            }

            // Reverse iteration
            Console.Write("Reversed: ");
            for (int i = fruits.Length - 1; i >= 0; i--)
            {
                Console.Write($"{fruits[i]} ");
            }
            Console.WriteLine();

            // ============================================
            // SECTION 3: Nested for Loops
            // ============================================
            Console.WriteLine("\n--- Nested for Loops ---");

            // Multiplication table (partial)
            Console.WriteLine("Multiplication table (1-3):");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"{i}x{j}={i * j}\t");
                }
                Console.WriteLine();
            }

            // Pattern: Triangle
            Console.WriteLine("\nTriangle pattern:");
            for (int row = 1; row <= 4; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // ============================================
            // SECTION 4: while Loop
            // ============================================
            Console.WriteLine("\n--- while Loop ---");

            // Basic while
            Console.Write("Count 1-5 (while): ");
            int count = 1;
            while (count <= 5)
            {
                Console.Write($"{count} ");
                count++;
            }
            Console.WriteLine();

            // Unknown iterations
            Console.WriteLine("\nDivide by 2 until < 1:");
            double number = 100;
            int iterations = 0;
            while (number >= 1)
            {
                Console.WriteLine($"  {number}");
                number /= 2;
                iterations++;
            }
            Console.WriteLine($"  Took {iterations} iterations");

            // ============================================
            // SECTION 5: do-while Loop
            // ============================================
            Console.WriteLine("\n--- do-while Loop ---");
            Console.WriteLine("(Executes at least once)");

            // do-while always runs at least once
            int x = 10;
            do
            {
                Console.WriteLine($"x = {x}");
                x++;
            } while (x < 10);  // Condition is false, but still ran once!

            Console.WriteLine("(Loop ran once even though x >= 10)");

            // Practical: Menu simulation
            Console.WriteLine("\nMenu simulation (do-while):");
            int choice = 0;
            int menuCount = 0;
            do
            {
                menuCount++;
                Console.WriteLine($"  Iteration {menuCount}: choice = {choice}");
                choice = 3;  // Simulate user selecting exit
            } while (choice != 3 && menuCount < 5);

            // ============================================
            // SECTION 6: Infinite Loops (Careful!)
            // ============================================
            Console.WriteLine("\n--- Infinite Loops ---");
            Console.WriteLine("Be careful with infinite loops!");
            Console.WriteLine("// while (true) { }     // Runs forever!");
            Console.WriteLine("// for (;;) { }         // Also infinite!");
            Console.WriteLine("Always ensure there's a way to exit (break, return, condition)");

            // Safe infinite loop with break
            Console.WriteLine("\nSafe 'infinite' loop with break:");
            int counter = 0;
            while (true)
            {
                Console.WriteLine($"  Counter: {counter}");
                counter++;
                if (counter >= 3)
                {
                    Console.WriteLine("  Breaking out!");
                    break;
                }
            }

            // ============================================
            // SECTION 7: Loop Variable Scope
            // ============================================
            Console.WriteLine("\n--- Loop Variable Scope ---");

            // i is only accessible inside the for loop
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Inside loop: i = {i}");
            }
            // Console.WriteLine(i);  // ERROR! i doesn't exist here

            // To use after loop, declare outside
            int loopVar;
            for (loopVar = 0; loopVar < 3; loopVar++)
            {
                // loop body
            }
            Console.WriteLine($"After loop: loopVar = {loopVar}");

            // ============================================
            // SECTION 8: Common Patterns
            // ============================================
            Console.WriteLine("\n--- Common Patterns ---");

            // Sum of numbers
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of 1-5: {sum}");

            // Find max in array
            int[] nums = { 3, 7, 2, 9, 5 };
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }
            Console.WriteLine($"Max in array: {max}");

            // Count occurrences
            string text = "hello world";
            int countL = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'l')
                    countL++;
            }
            Console.WriteLine($"Count of 'l' in \"{text}\": {countL}");

            // ============================================
            // SECTION 9: for vs while
            // ============================================
            Console.WriteLine("\n--- for vs while ---");
            Console.WriteLine("Use FOR when:");
            Console.WriteLine("  - You know the number of iterations");
            Console.WriteLine("  - Iterating over arrays/collections");
            Console.WriteLine("  - Counter-based loops");
            Console.WriteLine("\nUse WHILE when:");
            Console.WriteLine("  - Unknown number of iterations");
            Console.WriteLine("  - Waiting for a condition");
            Console.WriteLine("  - Reading until end of input");

            Console.WriteLine("\n=== End of Lesson 7 ===");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
