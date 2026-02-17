# Session Summary - Lesson 6

**Date**: 2026-02-18
**Lesson**: Switch Statements and Pattern Matching
**Status**: Completed

---

## What You Learned Today

### 1. Basic Switch Statement
```csharp
switch (value)
{
    case 1:
        Console.WriteLine("One");
        break;
    case 2:
    case 3:  // Fall-through
        Console.WriteLine("Two or Three");
        break;
    default:
        Console.WriteLine("Other");
        break;
}
```

### 2. Switch Expression (C# 8+)
```csharp
string result = value switch
{
    1 => "One",
    2 or 3 => "Two or Three",
    _ => "Other"  // _ is default
};
```

### 3. Relational Patterns
```csharp
string grade = score switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    _ => "F"
};
```

### 4. Type Pattern Matching
```csharp
string result = obj switch
{
    int n => $"Integer: {n}",
    string s => $"String: {s}",
    null => "Null",
    _ => "Unknown"
};
```

### 5. Tuple Patterns
```csharp
var result = (x, y) switch
{
    (0, 0) => "Origin",
    (0, _) => "Y-axis",
    (_, 0) => "X-axis",
    _ => "Other"
};
```

---

## Key Takeaways

1. Use switch for multiple equality checks
2. Switch expressions are more concise (C# 8+)
3. Pattern matching makes complex conditions readable
4. Don't forget `break` in traditional switch

---

*Next: Lesson 7 - Loops (for, while)*
