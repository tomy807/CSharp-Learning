// ============================================
// Quick Reference: Type Conversion
// ============================================

namespace Lesson04
{
    public static class ConversionReference
    {
        /*
=== IMPLICIT CONVERSION (Automatic, Safe) ===

No data loss, compiler does it automatically:

byte -> short -> int -> long -> float -> double
              \
               -> decimal (from int/long only)

char -> int -> long -> float -> double

Examples:
  int i = 100;
  long l = i;      // OK
  double d = i;    // OK


=== EXPLICIT CASTING (Manual, May Lose Data) ===

Syntax: (targetType)value

double -> float -> long -> int -> short -> byte

Examples:
  double d = 99.9;
  int i = (int)d;      // i = 99 (truncated!)

  int big = 300;
  byte b = (byte)big;  // b = 44 (overflow!)


=== PARSE METHODS ===

string -> number (throws exception on failure)

int.Parse("123")       -> 123
double.Parse("3.14")   -> 3.14
bool.Parse("true")     -> true

DANGER: Throws FormatException on invalid input!


=== TRYPARSE (Safe Parsing) ===

Returns bool, outputs value via 'out' parameter

if (int.TryParse("123", out int result))
{
    // Success: use result
}
else
{
    // Failed: result = 0 (default)
}


=== CONVERT CLASS ===

More flexible, handles null, rounds doubles

Convert.ToInt32("123")    -> 123
Convert.ToInt32(99.5)     -> 100 (rounded!)
Convert.ToInt32(99.4)     -> 99  (rounded!)
Convert.ToInt32(null)     -> 0   (no exception)
Convert.ToBoolean(1)      -> true
Convert.ToBoolean(0)      -> false


=== TOSTRING() ===

Any type -> string

(123).ToString()          -> "123"
(3.14).ToString()         -> "3.14"
(true).ToString()         -> "True"

Format Specifiers:
  "C"  - Currency:    $1,234.56
  "F2" - Fixed 2:     1234.56
  "N0" - Number:      1,235
  "P"  - Percent:     50.00%
  "X"  - Hex:         FF


=== COMPARISON TABLE ===

╔════════════════╦══════════════════════════════════════╗
║ Method         ║ Behavior                             ║
╠════════════════╬══════════════════════════════════════╣
║ (int)99.9      ║ 99 - Truncates decimal               ║
║ Convert(99.9)  ║ 100 - Rounds to nearest              ║
║ int.Parse      ║ Throws on invalid                    ║
║ int.TryParse   ║ Returns false on invalid             ║
╚════════════════╩══════════════════════════════════════╝


=== CHECKED / UNCHECKED ===

unchecked (default):
  int.MaxValue + 1 -> wraps to int.MinValue

checked:
  int.MaxValue + 1 -> throws OverflowException


=== COMMON PATTERNS ===

// Safe string to int
if (int.TryParse(input, out int value))
{
    // use value
}

// String to int with default
int num = int.TryParse(input, out int n) ? n : 0;

// Null-safe ToString
string s = obj?.ToString() ?? "";

// Round to int
int rounded = (int)Math.Round(3.7);  // 4

// Truncate to int
int truncated = (int)3.7;  // 3
        */
    }
}
