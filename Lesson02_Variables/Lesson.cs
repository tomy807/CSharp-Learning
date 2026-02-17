// ============================================
// Lesson 2: Variables and Data Types
// ============================================

using System;

namespace Lesson02
{
    public class Lesson
    {
        public static void Run()
        {
            Console.WriteLine("=== LESSON 2: Variables and Data Types ===\n");

            // ============================================
            // SECTION 1: Integer Types (Whole Numbers)
            // ============================================
            Console.WriteLine("--- Integer Types ---");

            byte smallNumber = 255;
            sbyte signedByte = -128;
            short shortNumber = 32767;
            int number = 2147483647;
            long bigNumber = 9223372036854775807L;

            Console.WriteLine($"byte: {smallNumber}");
            Console.WriteLine($"sbyte: {signedByte}");
            Console.WriteLine($"short: {shortNumber}");
            Console.WriteLine($"int: {number}");
            Console.WriteLine($"long: {bigNumber}");

            // ============================================
            // SECTION 2: Floating-Point Types (Decimals)
            // ============================================
            Console.WriteLine("\n--- Floating-Point Types ---");

            float floatNum = 3.14159f;
            double doubleNum = 3.14159265359;
            decimal money = 19.99m;

            Console.WriteLine($"float: {floatNum}");
            Console.WriteLine($"double: {doubleNum}");
            Console.WriteLine($"decimal: {money}");

            // Why decimal for money?
            Console.WriteLine("\n--- Why Decimal for Money? ---");
            double badMoney = 0.1 + 0.2;
            decimal goodMoney = 0.1m + 0.2m;
            Console.WriteLine($"double: 0.1 + 0.2 = {badMoney}");
            Console.WriteLine($"decimal: 0.1 + 0.2 = {goodMoney}");

            // ============================================
            // SECTION 3: Boolean Type
            // ============================================
            Console.WriteLine("\n--- Boolean Type ---");

            bool isActive = true;
            bool isCompleted = false;
            bool isGreater = 10 > 5;

            Console.WriteLine($"isActive: {isActive}");
            Console.WriteLine($"isCompleted: {isCompleted}");
            Console.WriteLine($"10 > 5 is: {isGreater}");

            // ============================================
            // SECTION 4: Character Type
            // ============================================
            Console.WriteLine("\n--- Character Type ---");

            char letter = 'A';
            char symbol = '@';
            char unicode = '\u0041';

            Console.WriteLine($"letter: {letter}");
            Console.WriteLine($"symbol: {symbol}");
            Console.WriteLine($"unicode \\u0041: {unicode}");

            // ============================================
            // SECTION 5: String Type
            // ============================================
            Console.WriteLine("\n--- String Type ---");

            string name = "Alice";
            string greeting = "Hello, " + name;

            Console.WriteLine($"name: {name}");
            Console.WriteLine($"greeting: {greeting}");

            // Escape sequences
            Console.WriteLine("\n--- Escape Sequences ---");
            Console.WriteLine("Tab:\tHello");
            Console.WriteLine("Quote: \"Hello\"");
            Console.WriteLine("Backslash: C:\\Users\\Name");

            // Verbatim string
            string path = @"C:\Users\Name\Documents";
            Console.WriteLine($"Verbatim path: {path}");

            // ============================================
            // SECTION 6: var Keyword
            // ============================================
            Console.WriteLine("\n--- Type Inference (var) ---");

            var playerName = "Hero";
            var playerScore = 1000;
            var pi = 3.14159;

            Console.WriteLine($"playerName: {playerName} ({playerName.GetType().Name})");
            Console.WriteLine($"playerScore: {playerScore} ({playerScore.GetType().Name})");
            Console.WriteLine($"pi: {pi} ({pi.GetType().Name})");

            // ============================================
            // SECTION 7: Constants
            // ============================================
            Console.WriteLine("\n--- Constants ---");

            const double PI = 3.14159265359;
            const int MAX_PLAYERS = 100;

            Console.WriteLine($"PI: {PI}");
            Console.WriteLine($"MAX_PLAYERS: {MAX_PLAYERS}");

            Console.WriteLine("\n=== End of Lesson 2 ===");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
