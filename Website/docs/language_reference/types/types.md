# Data and Types

Abstract is a strictly-typed language. It means that in abstract, every
data or object that holds data need to have its data structure explicitly
declared by the user.

:::note

`Data structures` refers to any kind of binary data stored by the machine, being
primitive or not. Some examples are `bytes` that, in memory, uses a space of 8
contiguous bits to represent a numerical value.

Sometimes, types can use the same data structures to represent diferent values.
As an example, a `char` have the same struct as a numerical `i32`, but is not
handled as a number when declared as it.

:::

Like in C, C# or Java, all input, output and storage of data needs to be declared
with a specific type to make sure any binary data will be read or written accordingly. \
Type strictness (AKA static typing) is an important resource in a program language as
it can be used to define complex structures, non-numerical data, lists, references
and alike.

An example on the use of types:
```abs
import from Std.Console

# The function main will ask for a list of strings
# to be called. It also declares a return type
# 'void', meaning it will not return any valid data.
@public func void main([]string args) {

    # Let's declare 3 variable data spaces in program's
    # memory, one for a signed byte, short and integer.
    let i8 myByte = 8
    let i16 myShort = 16
    let i32 myInt = 32

    # Now, let's pass these variables in a function 'foo'
    # which is an overloaded to accept multiple types as
    # shown below.

    # The first call is receiving an 'i8' as its argument.
    # As the function is declared to accept 'i8', this
    # code will be executed.
    foo(myByte) # foo(i8) -> void

    # The second call is receiving a 'i32' as its argument.
    # The function has an overload that accepts a 'i32'.
    # Hence, this code will be executed.
    foo(myInt) # foo(i32) -> void

    # The third call is receiving an 'i16' as its argument.
    # It can be seen below, that we don't have any overload
    # of 'foo' that accepts a value of the type 'i16'.
    # However, as the type 'i16' is implicitly convertible
    # to the type 'i32', the program will implicitly
    # convert the argument to i32 and call the right
    # overload.
    foo(myShort) # foo(i32) -> void

}

# Overloads of the function 'foo'
@public func void foo(i8 value) {
    writeln("The value is a byte and it is \{value}!")
}
@public func void foo(i32 value) {
    writeln("The value is a int32 and it is \{value}!")
}

```
```text title="Console Output"
The value is a byte and it is 8!
The value is a int32 and it is 32!
The value is a int32 and it is 16!
```
