// ============================================
// C# Learning - Main Menu
// ============================================

using System;

namespace CSharpLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════════════════╗");
                Console.WriteLine("║           C# Learning - Main Menu                ║");
                Console.WriteLine("╠══════════════════════════════════════════════════╣");
                Console.WriteLine("║  Phase 1: C# Fundamentals                        ║");
                Console.WriteLine("║  ─────────────────────────────────────────────── ║");
                Console.WriteLine("║  1.  Lesson 01: Hello World & Basics             ║");
                Console.WriteLine("║  2.  Lesson 02: Variables and Data Types         ║");
                Console.WriteLine("║  3.  Lesson 03: Operators                        ║");
                Console.WriteLine("║  4.  Lesson 04: Type Conversion (Coming Soon)    ║");
                Console.WriteLine("║  ─────────────────────────────────────────────── ║");
                Console.WriteLine("║  Exercises:                                      ║");
                Console.WriteLine("║  E1. Exercise 01: Hello World Practice           ║");
                Console.WriteLine("║  E2. Exercise 02: Variables Practice             ║");
                Console.WriteLine("║  E3. Exercise 03: Operators Practice             ║");
                Console.WriteLine("║  ─────────────────────────────────────────────── ║");
                Console.WriteLine("║  0.  Exit                                        ║");
                Console.WriteLine("╚══════════════════════════════════════════════════╝");
                Console.Write("\nSelect an option: ");

                string? input = Console.ReadLine()?.Trim().ToUpper();

                Console.Clear();

                switch (input)
                {
                    case "1":
                        Lesson01.Lesson.Run();
                        break;
                    case "2":
                        Lesson02.Lesson.Run();
                        break;
                    case "3":
                        Lesson03.Lesson.Run();
                        break;
                    case "4":
                        Console.WriteLine("Lesson 04 is coming soon!");
                        WaitForKey();
                        break;
                    case "E1":
                        Lesson01.Exercise.Run();
                        break;
                    case "E2":
                        Lesson02.Exercise.Run();
                        break;
                    case "E3":
                        Lesson03.Exercise.Run();
                        break;
                    case "0":
                        Console.WriteLine("Goodbye! Happy coding!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        WaitForKey();
                        break;
                }
            }
        }

        static void WaitForKey()
        {
            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
}
