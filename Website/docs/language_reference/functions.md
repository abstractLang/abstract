---
sidebar_position: 3
---

:::info[Under Construction]
:::

# Functions

Functions are simple ways to define subroutines or common and repetitive tasks.

The basic concept of a function is a block of code that can maybe accept arguments and can maybe
return data.
This block can easily be called by other functions in any moment or order.

---
## Declaring and Invoking

A example of function declaration and call in abstract is
```abs
func void foo() {
    Std.Console.writeln("foo called!")
}

foo()
```
```text title="Console Output"
foo called!
```

the syntax for declarate a function is:
```abs
func <type> <name>(...) { ... }
```

where `<type>` is the type that the function returns and `<name>` is the identifier for
reffer to the function.

A function can be invoked by it reference followed by a opening and closing parenthesis `()` as follows:
```abs
FunctionReference()
```

---
## Parameters and arguments


Some functions can ask for arguments to return some operated value or behave diferently depending
on how it is needed.

During the function declaration, parameters can be included as *typed identifiers* to identify their
type and allow them to be refered inside the function block.

```abs
# the function `foo` will ask for 2 arguments to be invoked.
# - The first can be a value of any type that will be refered as `any`.
# - The seccond is a 32 bit integer that will be refered as `number`.
func void foo(anytype any, i32 number) { ... }
```


If the function ask for arguments, the values should be declarated, in order, inside the parenthesis
```abs
@public func void foo(i32 a, i8 b, i128 c) { ... }

const i32 myInt = 100
const myByte = 255
const i128 myLonger = 2 ** 100

# correct call!
foo(myInt, myByte, myLonger) 

# /!\ Compilation error!
# There's no function 'foo' with this parameter type order!
###
foo(myByte, myInt, myLonger)
###

# /!\ Compilation error!
# There's no function 'foo' that accepts only a byte!
###
foo(myByte)
###
```

---
## Function Overloading

Two or more functions can have the same identifier if they have different types.
When a function is declarated with the same name, but with a diferent tipe, it's called overload.

:::info[Good Practice]
The Abstract Language emphasizes the language readability and understanding over abstraction.
As a good practice, make sure to only use function overloading when the result will be the same
for the same equivalent values. In some cases could be a good practice overload a function to ommit
a repetitive or optional value.

<details>
<summary>Examples</summary>

```abs title="Good Practice"
# Different results are named diferently

func void writeText(string value) {
    Std.Console.writeLn("My string is: " + value)
}
func void writeText([]char value) {
    Std.Console.writeLn("My string is: " + string.join(value))
}
func void writeNumber(i32 value) {
    Std.Console.writeLn("My number is: " + value)
}
```

```abs title="Bad Practice"
# Different results with the same name can result in a
# harder understanding of the code

func void writeText(string value) {
    Std.Console.writeLn("My string is:" + value)
}
func void writeText([]char value) {
    Std.Console.lowriteLng("My string is:" + string.join(value))
}
func void writeText(i32 value) {
    Std.Console.writeLn("My number is:" + value)
}
```
</details>
:::
