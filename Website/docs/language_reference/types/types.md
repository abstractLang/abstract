# Data and Types

Abstract is a strictly-typed language. It means that in abstract, every
data or object that holds data need to have it data structure explicitly
declatated by the user.

:::note

`Data structures` refers to any kind of binary data stored by the machine, being
primitive or not. Some exembles are `bytes` that, in memory, uses a space of 8
contiguous bits to represent a numerical value.

Sometimes, types can use the same data structures to represent diferent values.
As an example, a `char` have the same struct as a numerical `i32`, but is not
handled as a number when declarated as it.

:::

Like in C, C# or Java, all input, output and storage of data need to be declarated
with a specific type to make sure any binary data will be read or wrote wrongly. \
Type strictly is a important resource in a program language as it can be used to
define complex structures, non-numerical based data, lists and references and etc.

As an example of the use of types:
```abs
import { Console } from Std

# The function main will ask for a list of strings
# to be called. It also declarate a return type
# 'void', meaning it will not return any valid data.
@public func void main([]string args) {

    # Let's declarate 3 variable data spaces in program's
    # memory, one for a signed byte, short and integer.
    let i8 myByte = 8
    let i16 myShort = 16
    let i32 myInt = 32

    # The first call is receiving a 'i8' as it argument.
    # As we, more below, already declarated a overload
    # that accepts a 'i8', this code will be executed.
    foo(myByte) # foo(i8) -> void

    # The second call is receiving a 'i32' as it argument.
    # As we, more below, already declarated a overload
    # that accepts a 'i32', this code will be executed.
    foo(myInt) # foo(i32) -> void

    # The third call is receiving a 'i16' as it argument.
    # More bellow, we don't have any overload that accepts
    # a value of the type 'i16'. However, as the type 'i16'
    # is implicitly convertable to the type 'i32', the program
    # will, also implicitly, convert it and call the right
    # overload.
    foo(myShort) # foo(i32) -> void

}

# Overloads of the function 'foo'
@public func void foo(i8 value) {
    log("The value is a byte and it is " + value + "!")
}
@public func void foo(i32 value) {
    log("The value is a int32 and it is " + value + "!")
}

```
```text title="Console Output"
The value is a byte and it is 8!
The value is a int32 and it is 32!
The value is a int32 and it is 16!
```
