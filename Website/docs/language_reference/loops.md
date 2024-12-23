---
sidebar_position: 5
---

# Loops

:::info[Under Construction]
:::
:::warning[Not Implemented!]
:::

While loops
```abs
let index = 0

while index++ < 10 => Std.Console.log("Hello, World!")

while index >= 0 => {
    index -= 2
    Std.Console.log("Hello, Scopped World!")
}
```

For loops
```abs
# Looping from 0 to 49
for i in 50 => Std.Console.log(i)

# Looping from 0 to 50 in steps of 10
for i in 50 by 10 => Std.Console.log(i)

# Looping though each element of a array
let []byte numbers = [22, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43]
for i in numbers => Std.Console.log(i + " is a prime number!")

```
