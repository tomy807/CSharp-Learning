// ============================================
// Quick Reference: C# Operators
// ============================================

namespace Lesson03
{
    // Reference class - contains only documentation
    public static class OperatorsReference
    {
        /*
=== ARITHMETIC OPERATORS ===
+----+----------------+-------------+----------+
| Op | Name           | Example     | Result   |
+----+----------------+-------------+----------+
| +  | Addition       | 10 + 3      | 13       |
| -  | Subtraction    | 10 - 3      | 7        |
| *  | Multiplication | 10 * 3      | 30       |
| /  | Division       | 10 / 3      | 3 (int!) |
| %  | Modulus        | 10 % 3      | 1        |
+----+----------------+-------------+----------+

=== COMPARISON OPERATORS ===
+----+-------------------+-------------+--------+
| Op | Name              | Example     | Result |
+----+-------------------+-------------+--------+
| == | Equal             | 5 == 5      | true   |
| != | Not Equal         | 5 != 3      | true   |
| >  | Greater Than      | 5 > 3       | true   |
| <  | Less Than         | 5 < 3       | false  |
| >= | Greater or Equal  | 5 >= 5      | true   |
| <= | Less or Equal     | 5 <= 3      | false  |
+----+-------------------+-------------+--------+

=== LOGICAL OPERATORS ===
+----+------+---------------------------+--------+
| Op | Name | Example                   | Result |
+----+------+---------------------------+--------+
| && | AND  | true && false             | false  |
| || | OR   | true || false             | true   |
| !  | NOT  | !true                     | false  |
+----+------+---------------------------+--------+

=== ASSIGNMENT OPERATORS ===
+----+------------------+-------------+
| Op | Equivalent       | Example     |
+----+------------------+-------------+
| =  | Assign           | x = 10      |
| += | x = x + value    | x += 5      |
| -= | x = x - value    | x -= 3      |
| *= | x = x * value    | x *= 2      |
| /= | x = x / value    | x /= 4      |
| %= | x = x % value    | x %= 4      |
+----+------------------+-------------+

=== INCREMENT / DECREMENT ===
+-----+-------------+----------------------------------+
| Op  | Name        | Description                      |
+-----+-------------+----------------------------------+
| x++ | Post-inc    | Use x, then increment            |
| ++x | Pre-inc     | Increment, then use x            |
| x-- | Post-dec    | Use x, then decrement            |
| --x | Pre-dec     | Decrement, then use x            |
+-----+-------------+----------------------------------+

=== TERNARY OPERATOR ===
condition ? valueIfTrue : valueIfFalse

=== NULL OPERATORS ===
+-----+-------------------------+---------------------------+
| Op  | Name                    | Example                   |
+-----+-------------------------+---------------------------+
| ??  | Null-coalescing         | name ?? "Guest"           |
| ??= | Null-coalescing assign  | name ??= "Default"        |
+-----+-------------------------+---------------------------+

=== OPERATOR PRECEDENCE (Highest to Lowest) ===
1. ()               - Parentheses
2. !, ++, --        - Unary
3. *, /, %          - Multiplicative
4. +, -             - Additive
5. <, >, <=, >=     - Relational
6. ==, !=           - Equality
7. &&               - Logical AND
8. ||               - Logical OR
9. ?:               - Ternary
10. =, +=, etc.     - Assignment
        */
    }
}
