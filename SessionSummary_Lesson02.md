# Session Summary - Lesson 2

**Date**: 2026-02-02
**Lesson**: Variables and Data Types
**Status**: Completed

---

## What You Learned Today

### 1. What is a Variable?
A named container that stores data in memory.
```csharp
int age = 25;  // 'age' is the name, 25 is the value
```

### 2. Integer Types (Whole Numbers)

| Type | Size | Range | Use Case |
|------|------|-------|----------|
| `byte` | 8-bit | 0 to 255 | Small positive numbers |
| `short` | 16-bit | ±32,767 | Small numbers |
| `int` | 32-bit | ±2.1 billion | **Most common** |
| `long` | 64-bit | ±9.2 quintillion | Very large numbers |

### 3. Floating-Point Types (Decimals)

| Type | Precision | Suffix | Use Case |
|------|-----------|--------|----------|
| `float` | 7 digits | `f` | Graphics, games |
| `double` | 15-16 digits | none | **Most common** |
| `decimal` | 28-29 digits | `m` | **Money/Finance** |

### 4. Other Essential Types

| Type | Description | Example |
|------|-------------|---------|
| `bool` | True/False | `bool isActive = true;` |
| `char` | Single character | `char grade = 'A';` |
| `string` | Text | `string name = "Alice";` |

### 5. Variable Declaration Styles
```csharp
int score = 100;           // Declare and initialize
int health; health = 50;   // Declare, then assign
int x = 1, y = 2, z = 3;   // Multiple same-type
var name = "Hero";         // Type inference
```

### 6. Constants
```csharp
const double PI = 3.14159;     // Cannot be changed
const int MAX_LIVES = 3;
```

### 7. Escape Sequences
| Sequence | Meaning |
|----------|---------|
| `\n` | New line |
| `\t` | Tab |
| `\\` | Backslash |
| `\"` | Double quote |

### 8. Verbatim Strings
```csharp
string path = @"C:\Users\Name";  // @ ignores escapes
```

### 9. Naming Conventions
- Variables: `camelCase` → `playerScore`
- Constants: `PascalCase` → `MaxHealth`
- Classes: `PascalCase` → `PlayerCharacter`

---

## Key Takeaways

1. **Use `int`** for most whole numbers
2. **Use `double`** for most decimals
3. **Use `decimal`** for money (avoids floating-point errors)
4. **Use `var`** when the type is obvious
5. **Use meaningful names** - `playerHealth` not `x`

---

## Files Created

| File | Purpose |
|------|---------|
| `Program.cs` | Main lesson with all examples |
| `DataTypesReference.cs` | Quick reference chart |
| `Exercise02.cs` | Practice exercises |

---

## Practice Exercises

- [ ] Complete Exercise 1: Basic Variables
- [ ] Complete Exercise 2: Choose the Right Type
- [ ] Complete Exercise 3: Constants
- [ ] Complete Exercise 4: String Practice
- [ ] Complete Exercise 5: Using var
- [ ] Complete Bonus: Mini Calculator

---

## Next Lesson

**Lesson 3: Operators (Arithmetic, Comparison, Logical)**
- Arithmetic: `+`, `-`, `*`, `/`, `%`
- Comparison: `==`, `!=`, `>`, `<`, `>=`, `<=`
- Logical: `&&`, `||`, `!`
- Assignment: `=`, `+=`, `-=`, `*=`, `/=`
- Increment/Decrement: `++`, `--`

---

## Quick Reference

```csharp
// Most commonly used types
int count = 10;              // Whole numbers
double price = 19.99;        // Decimals
decimal money = 99.99m;      // Money
bool isActive = true;        // True/False
char grade = 'A';            // Single character
string name = "Alice";       // Text

// Constants (unchangeable)
const double PI = 3.14159;

// Type inference
var message = "Hello";       // Compiler knows it's string
```

---

*Next session: Continue with Lesson 3 - Operators*
