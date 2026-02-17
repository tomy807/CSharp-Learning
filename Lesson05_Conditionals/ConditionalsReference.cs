// ============================================
// Quick Reference: Conditional Statements
// ============================================

namespace Lesson05
{
    public static class ConditionalsReference
    {
        /*
=== BASIC IF ===

if (condition)
{
    // code if true
}


=== IF-ELSE ===

if (condition)
{
    // code if true
}
else
{
    // code if false
}


=== IF-ELSE IF-ELSE ===

if (condition1)
{
    // code if condition1 true
}
else if (condition2)
{
    // code if condition2 true
}
else
{
    // code if all false
}


=== LOGICAL OPERATORS ===

&&  AND   Both must be true
||  OR    At least one must be true
!   NOT   Inverts the condition

Examples:
  if (age >= 18 && hasID) { }      // Both required
  if (isVIP || hasCoupon) { }      // Either works
  if (!isBlocked) { }              // Not blocked


=== COMPARISON OPERATORS ===

==   Equal
!=   Not equal
>    Greater than
<    Less than
>=   Greater or equal
<=   Less or equal


=== TERNARY OPERATOR ===

condition ? valueIfTrue : valueIfFalse

string result = age >= 18 ? "Adult" : "Minor";


=== NULL OPERATORS ===

??   Null-coalescing: value ?? defaultValue
??=  Null-coalescing assignment: value ??= default

string name = userName ?? "Guest";
userName ??= "DefaultUser";


=== STRING COMPARISON ===

// Case-sensitive
if (str1 == str2) { }

// Case-insensitive
if (str1.Equals(str2, StringComparison.OrdinalIgnoreCase)) { }

// Null/Empty check
if (string.IsNullOrEmpty(str)) { }
if (string.IsNullOrWhiteSpace(str)) { }


=== COMMON PATTERNS ===

// Range check
if (value >= min && value <= max) { }

// Multiple values
if (day == "Sat" || day == "Sun") { }

// Guard clause (early return)
if (input == null) return;

// Nested ternary (use sparingly)
string size = x < 10 ? "S" : x < 20 ? "M" : "L";


=== BEST PRACTICES ===

1. Always use braces {} even for single lines
2. Keep conditions simple - extract complex logic to variables
3. Use early returns to reduce nesting
4. Consider switch for multiple equality checks
5. Avoid deep nesting (max 2-3 levels)
        */
    }
}
