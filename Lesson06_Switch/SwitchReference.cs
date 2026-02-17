// ============================================
// Quick Reference: Switch Statements
// ============================================

namespace Lesson06
{
    public static class SwitchReference
    {
        /*
=== BASIC SWITCH STATEMENT ===

switch (value)
{
    case 1:
        // code
        break;
    case 2:
    case 3:  // Fall-through
        // code for 2 or 3
        break;
    default:
        // code if no match
        break;
}


=== SWITCH EXPRESSION (C# 8+) ===

string result = value switch
{
    1 => "One",
    2 => "Two",
    3 or 4 => "Three or Four",
    _ => "Other"  // _ is default
};


=== RELATIONAL PATTERNS ===

string category = score switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    _ => "F"
};


=== LOGICAL PATTERNS ===

string result = value switch
{
    > 0 and < 10 => "Single digit positive",
    >= 10 and <= 99 => "Two digits",
    < 0 or > 99 => "Out of range",
    _ => "Zero"
};


=== TYPE PATTERNS ===

string result = obj switch
{
    int n => $"Integer: {n}",
    string s => $"String: {s}",
    double d => $"Double: {d}",
    null => "Null",
    _ => "Unknown"
};


=== WHEN CLAUSE ===

switch (value)
{
    case int n when n > 0:
        Console.WriteLine("Positive");
        break;
    case int n when n < 0:
        Console.WriteLine("Negative");
        break;
}


=== TUPLE PATTERNS ===

var result = (x, y) switch
{
    (0, 0) => "Origin",
    (0, _) => "Y-axis",
    (_, 0) => "X-axis",
    (var a, var b) when a == b => "Diagonal",
    _ => "Other"
};


=== LIST PATTERNS (C# 11+) ===

var result = array switch
{
    [] => "Empty",
    [var x] => $"Single: {x}",
    [var first, .., var last] => $"First: {first}, Last: {last}",
    _ => "Other"
};


=== PROPERTY PATTERNS ===

var result = person switch
{
    { Age: >= 18, HasLicense: true } => "Can drive",
    { Age: >= 18 } => "Adult without license",
    _ => "Cannot drive"
};


=== SWITCH VS IF-ELSE ===

Use SWITCH when:
- Comparing one value against many constants
- Pattern matching on types
- Clean multiple-choice logic

Use IF-ELSE when:
- Complex conditions with multiple variables
- Boolean logic with AND/OR
- Few conditions (2-3)
        */
    }
}
