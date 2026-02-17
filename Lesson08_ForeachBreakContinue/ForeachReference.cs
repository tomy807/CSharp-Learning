// ============================================
// Quick Reference: foreach and Loop Control
// ============================================

namespace Lesson08
{
    public static class ForeachReference
    {
        /*
=== FOREACH LOOP ===

foreach (type item in collection)
{
    // use item
}

// Array
foreach (string name in names)
    Console.WriteLine(name);

// List
foreach (int num in numberList)
    sum += num;

// Dictionary
foreach (var pair in dictionary)
    Console.WriteLine($"{pair.Key}: {pair.Value}");

// String (characters)
foreach (char c in "Hello")
    Console.Write(c);


=== BREAK ===

Exits the loop immediately.

foreach (int n in numbers)
{
    if (n < 0)
        break;  // Exit loop
    Console.WriteLine(n);
}

Use cases:
- Found what you're looking for
- Error condition
- Early termination


=== CONTINUE ===

Skips current iteration, moves to next.

foreach (int n in numbers)
{
    if (n < 0)
        continue;  // Skip negative
    Console.WriteLine(n);
}

Use cases:
- Skip invalid items
- Filter during iteration
- Skip special cases


=== BREAK VS CONTINUE ===

break:    Stops the entire loop
continue: Skips to next iteration

for (i = 1 to 10):
    if (i == 5) break;    -> prints 1,2,3,4
    if (i == 5) continue; -> prints 1,2,3,4,6,7,8,9,10


=== NESTED LOOPS ===

break/continue only affect the innermost loop.

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (j == 1) break;  // Only breaks inner loop
    }
}


=== FOREACH VS FOR ===

Use foreach:
- Don't need index
- Not modifying collection
- Reading all elements

Use for:
- Need index
- Modifying elements
- Iterate backwards
- Skip by index


=== FOREACH LIMITATIONS ===

// Cannot modify collection during iteration
foreach (var item in list)
    list.Remove(item);  // ERROR!

// Cannot modify value types
foreach (int n in array)
    n = n * 2;  // n is a copy!

// Solution: use for loop
for (int i = 0; i < array.Length; i++)
    array[i] = array[i] * 2;


=== COMMON PATTERNS ===

// Find first match
foreach (var item in items)
{
    if (condition) { found = item; break; }
}

// Filter with continue
foreach (var item in items)
{
    if (!isValid(item)) continue;
    process(item);
}

// Sum/Aggregate
int sum = 0;
foreach (int n in numbers)
    sum += n;

// Count matches
int count = 0;
foreach (var item in items)
    if (condition) count++;
        */
    }
}
