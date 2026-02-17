# Session Summary - Lesson 4

**Date**: 2026-02-18
**Lesson**: Type Conversion and Casting
**Status**: Completed

---

## What You Learned Today

### 1. Implicit Conversion (Automatic)

Smaller type -> Larger type (no data loss)

```
byte -> short -> int -> long -> float -> double
char -> int -> long -> float -> double
```

```csharp
int myInt = 100;
long myLong = myInt;    // Automatic, safe
double myDouble = myInt; // Automatic, safe
```

### 2. Explicit Casting (Manual)

Larger type -> Smaller type (may lose data!)

```csharp
double price = 19.99;
int wholePrice = (int)price;  // 19 (decimal truncated!)

int big = 300;
byte small = (byte)big;       // 44 (overflow! 300-256)
```

### 3. Parse Methods

String -> Number (throws exception on failure)

```csharp
int num = int.Parse("123");        // 123
double d = double.Parse("3.14");   // 3.14
bool b = bool.Parse("true");       // true

// DANGER: Invalid input throws FormatException!
```

### 4. TryParse (Safe Parsing)

Returns bool, no exceptions

```csharp
if (int.TryParse("123", out int result))
{
    Console.WriteLine(result);  // Success
}
else
{
    Console.WriteLine("Invalid input");
}
```

### 5. Convert Class

More flexible, handles null, **rounds** doubles

```csharp
Convert.ToInt32("123");     // 123
Convert.ToInt32(99.5);      // 100 (rounded!)
Convert.ToInt32(99.4);      // 99 (rounded!)
Convert.ToInt32(null);      // 0 (no exception)
Convert.ToBoolean(1);       // true
Convert.ToBoolean(0);       // false
```

### 6. ToString()

Any type -> String

```csharp
int num = 42;
string s = num.ToString();  // "42"

// Format specifiers
double money = 1234.5;
money.ToString("C");   // $1,234.50 (Currency)
money.ToString("F2");  // 1234.50 (Fixed 2)
money.ToString("N0");  // 1,235 (Number, no decimals)
```

### 7. Checked/Unchecked

```csharp
unchecked  // Default - silent overflow
{
    int max = int.MaxValue;
    int overflow = max + 1;  // Wraps to int.MinValue
}

checked  // Throws OverflowException on overflow
{
    int max = int.MaxValue;
    int overflow = max + 1;  // Throws!
}
```

---

## Key Comparison

| Method | (int)99.9 | Convert(99.9) | On Invalid |
|--------|-----------|---------------|------------|
| Result | 99 | 100 | - |
| Behavior | Truncates | Rounds | - |
| int.Parse | - | - | Exception |
| int.TryParse | - | - | Returns false |

---

## Key Takeaways

1. **Implicit** = safe (small -> large)
2. **Explicit casting** = may lose data (large -> small)
3. **Casting truncates**, Convert **rounds**
4. **Use TryParse** for user input (no exceptions)
5. **Parse throws** on invalid input
6. **Convert handles null** (returns 0)

---

## Files Created

| File | Purpose |
|------|---------|
| `Lesson.cs` | Main lesson with all examples |
| `Exercise.cs` | Practice exercises |
| `ConversionReference.cs` | Quick reference |

---

## Practice Exercises

- [ ] Exercise 1: Implicit Conversion
- [ ] Exercise 2: Explicit Casting
- [ ] Exercise 3: Parse Methods
- [ ] Exercise 4: TryParse Validation
- [ ] Exercise 5: Convert Class
- [ ] Exercise 6: Cast vs Convert
- [ ] Exercise 7: ToString Formats
- [ ] Exercise 8: Input Validation
- [ ] Bonus: Temperature Converter
- [ ] Challenge: Safe Calculator

---

## Next Lesson

**Lesson 5: Conditional Statements (if, else, else if)**
- if statement
- else and else if
- Nested conditions
- Logical operators in conditions

---

## Quick Reference

```csharp
// Implicit (auto)
int i = 100;
double d = i;

// Explicit (cast)
double d = 99.9;
int i = (int)d;  // 99

// Parse (may throw)
int n = int.Parse("123");

// TryParse (safe)
if (int.TryParse(input, out int result)) { }

// Convert (rounds, null-safe)
int n = Convert.ToInt32(99.5);  // 100

// ToString
string s = (123).ToString();
string money = (99.99).ToString("C");
```

---

*Next session: Continue with Lesson 5 - Conditional Statements*
