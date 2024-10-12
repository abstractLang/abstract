---
sidebar_position: 1
---

# Numeric Types
:::info[Under Construction]
:::

Numbers are the base of math and needed in every logical process. \
The abstract language allows the user to choose betwen a long list
of numeric types for the best result, performance and memory management
of their application.

---
## Integer Numbers
:::warning[Not Implemented!]
:::

The most simple way of representing numbers is with integers. Integers
represents a aways complete value, never allowing any decimal point.

For historical, computional and memory optimal reasons, the computer gives
a extensive range of possibilities about numeric integer values.

To delcarate a integer type in the Abstract Language, it is used a letter
to declarate the kind of the integer (signed or unsigned) and a number to
declarate the size, in bits, that this data will coast in memory.

examples of valid integer types are:
```
i8   # signed 8-bit (1 byte) integer
u16  # unsigned 16-bit integer
i128 # signed 128-bit integer
```

The following table shows every integer type and it corresponding in the C
programming language:

|abstract | alias | Equivalent in C |
|---------|:-----:|:---------------:|
| i8      | byte  | int8_t          |
| i16     | n/a   | int16_t         |
| i32     | n/a   | int32_t         |
| i64     | n/a   | int64_t         |
| i128    | n/a   | n/a             |
| iptr    | n/a   | intptr_t        |
| u8      | n/a   | uint8_t         |
| u16     | n/a   | uint16_t        |
| u32     | n/a   | uint32_t        |
| u64     | n/a   | uint64_t        |
| u128    | n/a   | n/a             |
| uptr    | n/a   | uintptr_t       |

---
## Floating Numbers
:::warning[Not Implemented!]
:::

Floating numbers are more complex numeric values used to reproduce fractions.

As the table above, the abstract floating types are above listed, with their
corresponding type in the C programming language:

|abstract | alias  | Equivalent in C |
|---------|:------:|:---------------:|
| f32     | float  | float           |
| f64     | double | double          |
