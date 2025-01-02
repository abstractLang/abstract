---
sidebar_position: 4
---

# Conditionals

:::info[Under Construction]
:::
:::warning[Not Implemented!]
:::

Conditionals are a important aspect of a program, allowing it to do specific behaviors with specific inputs.

Abstract have 3 main kinds of conditional checking: `if`, `elif` and `else`, match and
switch statements.

---
## if, elif and else blocks

`if`, `elif` and `else` are the most basic conditional statement.

These statements allows the formation of conditional cascades, checking one
condition after another until one of them is true or the cascade ends.

The condition expression evaluated after the `if` and `elif` keywords needs to be or result in
a `Boolean` type.

If false, the code will jump the next declarated statement and continue the process in the seccond statement
after the condition.

```abs
let bool sayHello = false

if sayHello
    Std.Console.writeln("Hello, World!")
# This statement is outside the condition!
Std.Console.writeln("Goodbie, World!")
```
```text title="Console Output"
Goodbie, World!
```

If a `elif` statement is declarated after a `if` or another `elif`, the condition
will be verified only if the conditions above are evaluated as false.

If a `else` statement is declarated after a `if` or `elif`, the statement will be
executed only when all the above conditions are evaluated as false.

As the condition chain is evaluated from top to bottom, sometimes is possible to
end up with unreachable conditions.

```abs
let i32 value = 10

# First condition evaluated.
# as 10 != 0, it will fall to the next elif
if value == 0
    Std.Console.writeln("value is exactly 0!")

# as 10 != 1, it will fall to the next elif
elif value == 1
    Std.Console.writeln("value is exactly 1!")

# as 10 > 5, it will fall to the next elif
elif value < 5
    Std.Console.writeln("Value is lower than 5 but greater than 1!")

# as 10 == 10, the next statement will be processed
elif value >= 10
    Std.Console.writeln("Value is equal or greater than 10!")

# It's impossible to a number to be greater than 11
# and not be greater than 10. This condition is unreachable.
elif value > 11
    Std.Console.writeln("Value is greater than 11!")

# A new if keyword will start a new cascade
if value == 11
    Std.Console.writeln("Value is exactly 11!")

# If all conditions in the cascade evaluate to false
# the else statement will aways be processed
else
    Std.Console.writeln("Value is not 11")

```

if more than a statement needs to be executed in case of a condition, it's possible to
open a conde block with brackets (`{...}`).

```abs
let i32 value

#...

if (value > 30) Std.Console.writeln("Value is greater than 30!")
elif (value < 30) Std.Console.writeln("Value is lesser than 30!")
else {
    # Here, this entire code block will be executed in case of the
    # value be exactly 30.
    Std.Console.writeln("Certainly,")
    Std.Console.writeln("the value is")
    Std.Console.writeln("exactly 30!")
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
     10 => Std.Console.writeln("value is 10!"),
     20 => Std.Console.writeln("value is 20!"),
     30 => Std.Console.writeln("value is 30!"),

     _ => Std.Console.writeln("Value is neither 10, 20 or 30!")
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
    case < 10 and > 0 => Std.Console.writeln(manaPoints + " - mana points") # breaks here!

    case 0 => Std.Console.writeln("No mana!")
}

```

```text title="Console Output"
####### - life points
3 - mana points
```
