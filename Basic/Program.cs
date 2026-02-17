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
                Console.WriteLine("║  4.  Lesson 04: Type Conversion                  ║");
                Console.WriteLine("║  5.  Lesson 05: Conditional Statements           ║");
                Console.WriteLine("║  6.  Lesson 06: Switch & Pattern Matching        ║");
                Console.WriteLine("║  7.  Lesson 07: Loops (for, while)               ║");
                Console.WriteLine("║  8.  Lesson 08: foreach & Loop Control           ║");
                Console.WriteLine("║  ─────────────────────────────────────────────── ║");
                Console.WriteLine("║  Exercises: E1-E8                                ║");
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
                        Lesson04.Lesson.Run();
                        break;
                    case "5":
                        Lesson05.Lesson.Run();
                        break;
                    case "6":
                        Lesson06.Lesson.Run();
                        break;
                    case "7":
                        Lesson07.Lesson.Run();
                        break;
                    case "8":
                        Lesson08.Lesson.Run();
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
                    case "E4":
                        Lesson04.Exercise.Run();
                        break;
                    case "E5":
                        Lesson05.Exercise.Run();
                        break;
                    case "E6":
                        Lesson06.Exercise.Run();
                        break;
                    case "E7":
                        Lesson07.Exercise.Run();
                        break;
                    case "E8":
                        Lesson08.Exercise.Run();
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
