---
sidebar_position: 4
---

# Conditionals

:::info[Under Construction]
:::
:::warning[Not Implemented!]
:::

if, elif, else
```abs
let i32 value

...

if value > 30 => Std.Console.log("Value is greater than 30!")
else if value < 30 => Std.Console.log("Value is lesser than 30!")
else => {
    Std.Console.log("Certainly,")
    Std.Console.log("the value is")
    Std.Console.log("exactly 30!")
}

```

---
## Match

A easier way to do collections of if - elif's

It can only check equality \
It cannot fall though other cases

It can run statements or return values \
Each case have it own scope

```abs
let i32 value

# ...

match value {
     10 => Std.Console.log("value is 10!"),
     20 => Std.Console.log("value is 20!"),
     30 => Std.Console.log("value is 30!"),

     _ => Std.Console.log("Value is neither 10, 20 or 30!")
}

# Match blocks can return values too!
let i32 by2 = match value {
    10 => 5,
    20 => 10,
    30 => 15,
    40 => 20,

    _ => value / 2
}

```

---
## Switch

Most complex way of controll of code process \
switches manipulates groups of cases and conditions

Switches allows any condition evaluation \
Switches allows to fall though cases, allowing to
continue executing if a minimum condition is achived.

```abs
let i32 lifePoints = 7
let i32 manaPoints = 3

# Switchs will fall though bellow cases when the
# arow operator is after the case statement!

switch lifePoints {
    case 10 => Std.Console.write("2x") =>
    case 9 => Std.Console.write("#") =>
    case 8 => Std.Console.write("#") =>
    case 7 => Std.Console.write("#") =>
    case 6 => Std.Console.write("#") =>
    case 5 => Std.Console.write("#") =>
    case 4 => Std.Console.write("#") =>
    case 3 => Std.Console.write("#") =>
    case 2 => Std.Console.write("#") =>
    case 1 => Std.Console.write("#") =>

    default => Std.Console.write(" - life points")
}

# Without the arow operator, the process will not
# fall through the next case and the switch will
# break!

switch manaPoints {
    case > 10 => Std.Console.write("Mana bonus! ") =>
    case < 10 and > 0 => Std.Console.log(manaPoints + " - mana points") # breaks here!

    case 0 => Std.Console.log("No mana!")
}

```

```text title="Console Output"
####### - life points
3 - mana points
```
