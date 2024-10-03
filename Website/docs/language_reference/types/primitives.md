---
sidebar_position: 2
---

:::info[Under Construction]
:::

# Other Primitive Types

Abstract also have some other primitive types that can't be considerated numbers.
Some of then exists to create some abstractions with complex collections of
numerical values or create type encapsulation.

---
## Booleans

Booleans are types that can only represent the binary values `true` or `false`.
These two values are extremely important to handle conditionals or hold simple
states without messing the values.

|abstract | alias | Equivalent in C | Size in bits |
|---------|:-----:|:---------------:|:------------:|
| bool    | n/a   | bool            | 8            |

```abs
let bool cake = false

if cake => Std.Console.log("Yammy!")
else => Std.Console.log("The cake is a lie!")
```
```text title="Console Output"
The cake is a lie!
```

---
## Strings

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
in memory, being able to hold every possible character of the UTF-8 char set.

|abstract | alias | Equivalent in C | Size in bits |
|---------|:-----:|:---------------:|:------------:|
| char    | n/a   | n/a             | 32           |

```abs
const string myString = "Hello, World!"

let char myChar = 'U'
myChar = myString[7] # 'W'

```

---
## Flags

:::warning[Not Implemented!]
:::


Flags are collections of packad booleans. \
While 8 boolean variables needs a total of 8 bytes to be stored in memory,
flags will be compressed into bits, making the same length coast only 1 byte
in memory.

```abs
# Declaration of a flag type!
Flag MyFlags {
    HaveFork,
    HaveKnife,
    HavePlate
}

let MyFlags stuff = (false, true, false)

if !stuff.HaveFork => Std.Console.log("Bro need a fork!")
if !stuff.HaveKnife => Std.Console.log("Bro need a knife!")
if !stuff.HavePlate => Std.Console.log("Bro need a plate!")

Std.Console.log("stuff have only " + Std.Type.sizeof(stuff) + "byte(s) in memory!");
```
```text title="Console Output"
Bro need a fork!
Bro need a plate!
stuff have only 1 byte(s) in memory!
```

---
## Enums
:::warning[Not Implemented!]
:::
