// ============================================
// Quick Reference: for and while Loops
// ============================================

namespace Lesson07
{
    public static class LoopsReference
    {
        /*
=== FOR LOOP ===

for (initializer; condition; iterator)
{
    // code to repeat
}

// Count 1 to 5
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

// Count down
for (int i = 10; i >= 1; i--)

// Step by 2
for (int i = 0; i <= 10; i += 2)

// Array iteration
for (int i = 0; i < array.Length; i++)


=== WHILE LOOP ===

while (condition)
{
    // code to repeat
}

// Example
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}


=== DO-WHILE LOOP ===

do
{
    // code (runs at least once!)
} while (condition);

// Example
int choice;
do
{
    choice = GetUserInput();
} while (choice != 0);


=== NESTED LOOPS ===

for (int row = 0; row < 3; row++)
{
    for (int col = 0; col < 3; col++)
    {
        Console.Write($"({row},{col}) ");
    }
    Console.WriteLine();
}


=== INFINITE LOOPS ===

// Be careful!
while (true) { }   // Infinite
for (;;) { }       // Also infinite

// Always have an exit condition!
while (true)
{
    if (shouldExit) break;
}


=== COMMON PATTERNS ===

// Sum of numbers
int sum = 0;
for (int i = 1; i <= n; i++)
    sum += i;

// Find max
int max = arr[0];
for (int i = 1; i < arr.Length; i++)
    if (arr[i] > max) max = arr[i];

// Count occurrences
int count = 0;
for (int i = 0; i < str.Length; i++)
    if (str[i] == target) count++;

// Factorial
int fact = 1;
for (int i = 1; i <= n; i++)
    fact *= i;


=== FOR VS WHILE ===

Use FOR when:
- Known number of iterations
- Array/collection iteration
- Counter-based loops

Use WHILE when:
- Unknown iterations
- Waiting for condition
- Reading until EOF

Use DO-WHILE when:
- Must run at least once
- Menu loops
- Input validation


=== LOOP VARIABLE SCOPE ===

// i only exists inside loop
for (int i = 0; i < 5; i++) { }
// i not accessible here

// To use after loop:
int j;
for (j = 0; j < 5; j++) { }
// j is accessible here
        */
    }
}
