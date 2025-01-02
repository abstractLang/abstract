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
```abs
i8   # signed 8-bit (1 byte) integer
u16  # unsigned 16-bit integer
i128 # signed 128-bit integer
```

The following table shows every integer type and it corresponding in the C
programming language:

| Alias     | Equivalent in C | Size                | Range                           | Implementation           |
|-----------|:---------------:|:-------------------:|:-------------------------------:|:------------------------:|
| i8        | int8_t          | 8-bits / 1 byte     | -128 to 127                     | [Std.Types.SignedInteger8](#) |
| i16       | int16_t         | 16-bits / 2 bytes   | -32,768 to 32,767               | [Std.Types.SignedInteger16](#) |
| i32       | int32_t         | 32-bits / 4 bytes   | -2,147,483,648 to 2,147,483,647 | [Std.Types.SignedInteger32](#) |
| i64       | int64_t         | 64-bits / 8 bytes   | -9.2x10¹⁸ to 9.2x10¹⁸           | [Std.Types.SignedInteger64](#) |
| i128      | n/a             | 128-bits / 16 bytes | -1.7x10³⁸ to 1.7x10³⁸           | [Std.Types.SignedInteger128](#) |
| iptr      | intptr_t        | (target dependent)  | (target dependent)              | (target dependent) |
| u8 (byte) | uint8_t         | 8-bits / 1 byte     | 0 to 255                        | [Std.Types.UnsignedInteger8](#) |
| u16       | uint16_t        | 16-bits / 2 bytes   | 0 to 65,535                     | [Std.Types.UnsignedInteger16](#) |
| u32       | uint32_t        | 32-bits / 4 bytes   | 0 to 4,294,967,295              | [Std.Types.UnsignedInteger32](#) |
| u64       | uint64_t        | 64-bits / 8 bytes   | 0 to 1.8x10¹⁹                   | [Std.Types.UnsignedInteger64](#) |
| u128      | n/a             | 128-bits / 16 bytes | 0 to 3.4x10³⁸                   | [Std.Types.UnsignedInteger128](#) |
| uptr      | uintptr_t       | (target dependent)  | (target dependent)              | (target dependent) |

The `iptr` and `uptr` types are special general-purpose integers that are defined
by the target. It is equivalent to the size of a memory pointer on the specific
platform or the biggest native integer that the specified target can process.
E.g.:
If compiling the project to a x86 archtecture based machine, `iptr` will be equivalent
to i32 and

---
## Floating Numbers
:::warning[Not Implemented!]
:::

Floating numbers are more complex numeric values used to reproduce fractions.

As the table above, the abstract floating types are above listed, with their
corresponding type in the C programming language:

| Alias        | Equivalent in C | Implementation                |
|--------------|:---------------:|:-----------------------------:|
| f32 (float)  | float           | [Std.Types.SingleFloating](#) |
| f64 (double) | double          | [Std.Types.DoubleFloating](#) |
