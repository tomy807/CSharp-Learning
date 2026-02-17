// ============================================
// Lesson 1: Your First C# Program
// ============================================

using System;

namespace Lesson01
{
    public class Lesson
    {
        public static void Run()
        {
            Console.WriteLine("=== LESSON 1: Hello World & Basics ===\n");

            // Console.WriteLine prints text to the screen and adds a new line
            Console.WriteLine("Hello, World!");

            // Console.Write prints text WITHOUT a new line
            Console.Write("Welcome to ");
            Console.WriteLine("C# Programming!");

            // Let's make it interactive
            Console.WriteLine();
            Console.Write("What is your name? ");

            // Console.ReadLine() waits for user input
            string? name = Console.ReadLine();

            // String interpolation ($"...")
            Console.WriteLine($"Nice to meet you, {name}!");

            // String concatenation
            Console.WriteLine("Welcome to C#, " + name + "!");

            // Comments
            Console.WriteLine("\n--- Comments ---");
            Console.WriteLine("// Single-line comment");
            Console.WriteLine("/* Multi-line comment */");

            // Empty line
            Console.WriteLine();

            Console.WriteLine("=== End of Lesson 1 ===");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
