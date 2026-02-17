# Session Summary - Lesson 5

**Date**: 2026-02-18
**Lesson**: Conditional Statements (if, else, else if)
**Status**: Completed

---

## What You Learned Today

### 1. Basic if Statement
```csharp
if (condition)
{
    // code if true
}
```

### 2. if-else Statement
```csharp
if (age >= 18)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Minor");
}
```

### 3. if-else if-else Chain
```csharp
if (score >= 90) { grade = "A"; }
else if (score >= 80) { grade = "B"; }
else if (score >= 70) { grade = "C"; }
else { grade = "F"; }
```

### 4. Logical Operators in Conditions

| Operator | Name | Example |
|----------|------|---------|
| `&&` | AND | `age >= 18 && hasID` |
| `\|\|` | OR | `isVIP \|\| hasCoupon` |
| `!` | NOT | `!isBlocked` |

### 5. Ternary Operator
```csharp
string result = condition ? "Yes" : "No";
```

### 6. Null Operators
```csharp
string name = userName ?? "Guest";  // If null, use "Guest"
userName ??= "Default";             // Assign if null
```

---

## Key Takeaways

1. Always use braces `{}` even for single lines
2. Keep conditions simple and readable
3. Use early returns to reduce nesting
4. Consider switch for multiple equality checks

---

*Next: Lesson 6 - Switch Statements and Pattern Matching*
