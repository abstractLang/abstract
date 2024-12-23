---
sidebar_position: 2
---

# Other Primitive Types
:::info[Under Construction]
:::

Abstract also have some other primitive types that can't be considerated numbers.
Some of then exists to create some abstractions with complex collections of
numerical values or create type encapsulation.

---
## Booleans
:::warning[Not Implemented!]
:::

Booleans are types that can only represent the binary values `true` or `false`.
These two values are extremely important to handle conditionals or hold simple
states without messing the values.

|abstract | alias | Equivalent in C | Size in bits |
|---------|:-----:|:---------------:|:------------:|
| bool    | n/a   | bool            | 8            |

```abs
let bool cake = false

if cake Std.Console.writeLn("Yammy!")
else Std.Console.writeLn("The cake is a lie!")
```
```text title="Console Output"
The cake is a lie!
```

---
## Strings
:::warning[Not Implemented!]
:::

Strings are a data structure that is able to store text data. A string can be
used to store and reproduce text characters easily. \
In Abstract, every string is coded in UTF-8, with characters variating from 1-4
bytes length.

|abstract | alias | Equivalent in C | Size in bits |
|---------|:-----:|:---------------:|:------------:|
| string  | n/a   | n/a             | variable     |

```abs
let string mySpeek = "Hello, World!"
Std.Console.log(mySpeek)

mySpeek = "Goodbie, World!"
Std.Console.log(mySpeek)
```
```text title="Console Output"
Hello, World!
Goodbie, World!
```

---
## Chars
:::warning[Not Implemented!]
:::

Chars are data structures made to hold a single text character. It can be achived
by manually setting with a character value or getting a character from a index of
a string. \
As every string in Abstract is UTF-8, every character have the same length as a `i32`
in memory, being able to hold every possible character of the Unicode char set.

|abstract | alias | Equivalent in C | Size in bits |
|---------|:-----:|:---------------:|:------------:|
| char    | n/a   | n/a             | 32           |

```abs
const string myString = "Hello, World!"

let char myChar = 'U'
myChar = myString[7] # 'W'

```

---
## Enums
:::warning[Not Implemented!]
:::
