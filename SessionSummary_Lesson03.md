# Session Summary - Lesson 3

**Date**: 2026-02-18
**Lesson**: Operators
**Status**: Completed

---

## What You Learned Today

### 1. Arithmetic Operators

| Operator | Name | Example | Result |
|----------|------|---------|--------|
| `+` | Addition | `10 + 3` | `13` |
| `-` | Subtraction | `10 - 3` | `7` |
| `*` | Multiplication | `10 * 3` | `30` |
| `/` | Division | `10 / 3` | `3` (integer!) |
| `%` | Modulus | `10 % 3` | `1` |

**Important**: `10 / 3 = 3` (integer) vs `10.0 / 3 = 3.333...` (floating-point)

### 2. Comparison Operators

| Operator | Name | Example | Result |
|----------|------|---------|--------|
| `==` | Equal | `5 == 5` | `true` |
| `!=` | Not Equal | `5 != 3` | `true` |
| `>` | Greater Than | `5 > 3` | `true` |
| `<` | Less Than | `5 < 3` | `false` |
| `>=` | Greater or Equal | `5 >= 5` | `true` |
| `<=` | Less or Equal | `5 <= 3` | `false` |

### 3. Logical Operators

| Operator | Name | Example | Result |
|----------|------|---------|--------|
| `&&` | AND | `true && false` | `false` |
| `\|\|` | OR | `true \|\| false` | `true` |
| `!` | NOT | `!true` | `false` |

**Short-circuit evaluation**:
- `false && anything` = `false` (skips `anything`)
- `true || anything` = `true` (skips `anything`)

### 4. Assignment Operators

```csharp
int score = 100;
score += 10;  // score = score + 10 = 110
score -= 5;   // score = score - 5  = 105
score *= 2;   // score = score * 2  = 210
score /= 3;   // score = score / 3  = 70
score %= 10;  // score = score % 10 = 0
```

### 5. Increment / Decrement

```csharp
int n = 5;
Console.WriteLine(n++);  // Prints 5, THEN n becomes 6
Console.WriteLine(++n);  // n becomes 7, THEN prints 7
```

| Operator | Name | Description |
|----------|------|-------------|
| `x++` | Post-increment | Use x, then add 1 |
| `++x` | Pre-increment | Add 1, then use x |
| `x--` | Post-decrement | Use x, then subtract 1 |
| `--x` | Pre-decrement | Subtract 1, then use x |

### 6. Ternary Operator

```csharp
condition ? valueIfTrue : valueIfFalse

// Example:
string status = age >= 18 ? "Adult" : "Minor";
```

### 7. Null Operators

```csharp
// Null-coalescing (??)
string name = userName ?? "Guest";  // If null, use "Guest"

// Null-coalescing assignment (??=)
message ??= "Default";  // Assign only if null
```

### 8. Operator Precedence

| Priority | Operators | Description |
|----------|-----------|-------------|
| 1 (highest) | `()` | Parentheses |
| 2 | `!`, `++`, `--` | Unary |
| 3 | `*`, `/`, `%` | Multiplicative |
| 4 | `+`, `-` | Additive |
| 5 | `<`, `>`, `<=`, `>=` | Relational |
| 6 | `==`, `!=` | Equality |
| 7 | `&&` | Logical AND |
| 8 | `\|\|` | Logical OR |
| 9 | `?:` | Ternary |
| 10 (lowest) | `=`, `+=`, etc. | Assignment |

---

## Key Takeaways

1. **Integer division truncates**: `10 / 3 = 3`, not 3.333
2. **Use modulus `%`** to check even/odd: `n % 2 == 0`
3. **Post vs Pre increment**: `n++` uses then increments, `++n` increments then uses
4. **Use parentheses** when precedence is unclear
5. **`&&` before `||`**: `true || false && false` = `true`
6. **Ternary for simple conditions**: cleaner than if-else for one-liners

---

## Files Created

| File | Purpose |
|------|---------|
| `Program.cs` | Main lesson with all examples |
| `OperatorsReference.cs` | Quick reference chart |
| `Exercise03.cs` | Practice exercises |

---

## Practice Exercises

- [ ] Exercise 1: Basic Arithmetic
- [ ] Exercise 2: Integer vs Float Division
- [ ] Exercise 3: Comparison Operators
- [ ] Exercise 4: Voting Eligibility (Logical)
- [ ] Exercise 5: Assignment Operators
- [ ] Exercise 6: Pre vs Post Increment
- [ ] Exercise 7: Ternary Operator
- [ ] Exercise 8: Null Handling
- [ ] Exercise 9: Operator Precedence
- [ ] Bonus: Simple Calculator
- [ ] Challenge: Grade Calculator

---

## Next Lesson

**Lesson 4: Type Conversion and Casting**
- Implicit conversion
- Explicit casting
- Parse and TryParse
- Convert class
- Overflow handling

---

## Quick Reference

```csharp
// Arithmetic
int result = 10 + 3 - 2 * 4 / 2 % 3;

// Comparison (returns bool)
bool equal = a == b;
bool greater = a > b;

// Logical (combines bools)
bool both = a && b;
bool either = a || b;
bool not = !a;

// Assignment shortcuts
score += 10;  // Add and assign

// Increment
count++;  // Post: use then add
++count;  // Pre: add then use

// Ternary (inline if)
string s = condition ? "yes" : "no";

// Null handling
string name = input ?? "default";
```

---

*Next session: Continue with Lesson 4 - Type Conversion and Casting*
