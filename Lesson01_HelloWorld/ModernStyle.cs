// ============================================
// Lesson 1: Modern C# Style (Reference Only)
// ============================================
// This file shows top-level statements (C# 9+)
// It's commented out since we can only have one entry point.
// ============================================

namespace Lesson01
{
    // This class exists just to hold reference comments
    // about modern C# top-level statement syntax
    public static class ModernStyleReference
    {
        /*
        In modern C# (9+), you can write code without:
        - using System; (auto-imported with ImplicitUsings)
        - namespace declaration
        - class declaration
        - Main method declaration

        Example - a complete program in just 3 lines:

        Console.WriteLine("Hello, World!");
        Console.Write("What is your name? ");
        Console.WriteLine($"Nice to meet you, {Console.ReadLine()}!");

        The compiler generates the boilerplate automatically!
        This is called "top-level statements".
        */
    }
}
