# Session Summary - Lesson 8

**Date**: 2026-02-18
**Lesson**: foreach and Loop Control (break, continue)
**Status**: Completed

---

## What You Learned Today

### 1. foreach Loop
```csharp
foreach (string item in collection)
{
    Console.WriteLine(item);
}
```

### 2. foreach with Different Collections
```csharp
// Array
foreach (int n in numbers) { }

// List
foreach (var item in list) { }

// Dictionary
foreach (var pair in dict)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

// String (characters)
foreach (char c in "Hello") { }
```

### 3. break Statement
Exits the loop immediately.
```csharp
foreach (int n in numbers)
{
    if (n < 0) break;  // Exit loop
    Console.WriteLine(n);
}
```

### 4. continue Statement
Skips to next iteration.
```csharp
foreach (int n in numbers)
{
    if (n < 0) continue;  // Skip negatives
    Console.WriteLine(n);
}
```

### 5. break vs continue

| Statement | Effect |
|-----------|--------|
| `break` | Stops entire loop |
| `continue` | Skips to next iteration |

---

## foreach vs for

| Use foreach | Use for |
|-------------|---------|
| Don't need index | Need index |
| Not modifying | Modifying elements |
| Read all elements | Iterate backwards |

---

## Key Takeaways

1. foreach is cleaner for reading collections
2. break exits immediately
3. continue skips current iteration
4. Cannot modify collection during foreach

---

*Module 2 Complete! Next: Module 3 - Methods and Functions*
