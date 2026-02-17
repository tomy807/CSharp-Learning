# Session Summary - Lesson 7

**Date**: 2026-02-18
**Lesson**: Loops - for and while
**Status**: Completed

---

## What You Learned Today

### 1. for Loop
```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

### 2. while Loop
```csharp
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
```

### 3. do-while Loop
```csharp
do
{
    // Runs at least once!
} while (condition);
```

### 4. Nested Loops
```csharp
for (int row = 0; row < 3; row++)
{
    for (int col = 0; col < 3; col++)
    {
        Console.Write($"({row},{col}) ");
    }
    Console.WriteLine();
}
```

### 5. Common Patterns

| Pattern | Code |
|---------|------|
| Sum | `sum += i;` |
| Find max | `if (arr[i] > max) max = arr[i];` |
| Count | `if (condition) count++;` |
| Factorial | `fact *= i;` |

---

## for vs while

| Use FOR | Use WHILE |
|---------|-----------|
| Known iterations | Unknown iterations |
| Array iteration | Waiting for condition |
| Counter-based | Until EOF/event |

---

*Next: Lesson 8 - foreach and Loop Control*
