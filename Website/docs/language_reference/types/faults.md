---
sidebar_position: 9
---

# Faults
:::info[Under Construction]
:::
:::warning[Not Implemented!]
:::

All programmers needs to accept that in some moment, their code will, somehow, fail.
Failing is normal and acceptable. Sometimes, inevitable.

To make the coding process less stressing, abstrat presents ways to handle errors, solve
and clean data and adjust the process routine as the program needs.

---
## Handling Faults

In abstract, any error, exception or invalid operation is handled as a Fault. \
Falts are data sructures that can be raised during runtime to indicate when and
where a certain subroutine identified a problem in the execution. It can store
data about where the error happened, what happened and aditional data do debug
the error as the programmer needs.

```abs
func !void tryToDoSomething()
func !u32 tryToReturnSomething()
```

The `tryToDoSomething` and `tryToReturnSomething` functions are being typed as `!void` and
`!u32`, respectively.
It means it will return nothing (void) and a integer (u32), with the error wrapper (`!`)
before it, that means that somehow the execution of this subroutine can fail and be aborted.

Aborting a subroutine is not a bad thing when it is handled at the right way. A aborted
function execution means no return value, so the caller needs to be notified when it happens
and handle a simple alternative routine to allow the execution to continue running without
the desired value.

To make sure that the fault will not be a problem to the process, abstract will not allow
a failable function to be invoked as usually:

```abs
# Try to invoke the function this way will result in a compilation error!
tryToDoSomething()
let u32 foo = tryToReturnSomething()
```

Instead, you need to unwrap the result or handle the fault somehow.

The first way of doing it is, as simply as this is, ignore the error with 
the `.ignored()` call or the `!` operator after the resulted failable value.

Pay attention that the ignored result will return a nullable value that will
be null in case of an error, so if you have sure about the sucess of the
operation, you can also unwrap the nullable value:

```abs
# This will invoke the function, allowing it to abort without changing the
# current process state.
tryToDoSomething()!
let u32 foo = tryToReturnSomething()!?           # nullable unwrapping

# You can do as well
tryToDoSomething().ignored()
let ?u32 bar = tryToReturnSomething().ignored()  # not unwrapped
```

---
If the error cannnot be just ignored and need a specific process branching to
handle it, the fault wrapper provide the `.onCatch()` call and the `catch` operator:

```abs
# If the invoke get aborted, the catch block will be executed before
# the execution continue
tryToDoSomething() catch(fault err)
    Std.Console.writeln("A fault of type \{err.name} has occurred!")
tryToReturnSomething() catch {
    Std.Console.writeln("Aborting due internal error!")
    throw
}

# As well
tryToDoSomething().onCatch((fault err) => {
    Std.Console.writeln("A fault of type \{err.name} has occurred!") })
tryToReturnSomething().onCatch(() => {
    Std.Console.writeln("The process could not be completed,")
    Std.Console.writeln("aborting due internal error!")
    throw
})
```

---
And finally, if the error cannot be handled by the current call and is better to
be handled by the caller, it's possible to use the `try` operator.

See that using the `try` operator will also make the function abort in case
of an error.

```abs
# If `tryToDoSomething` return a error, the function will abort and
# the fault will be raised to the caller
try tryToDoSomething()
let u32 foo = try tryToReturnSomething() 

# The same as
tryToDoSomething() catch throw
let u32 foo = tryToReturnSomething() catch throw
```

---
## Raising a Fault

To allow a function to raise faults and alert any caller about a process error,
the function need to be typed with the Fault Wrapper `Std.Types.Fault(type T)`.
To make life easier, the compiler allows a type to be automatically weapped by
using tha bang character (`!`) before the desired to wrap type:

```abs
func !void foo()        # A failable function that returns nothing
func !i32 foo()         # A failable function that returns a integer
func !float foo()       # A failable function that returns a floating
func !?bool foo()       # A failable function that returns a nullable boolean
func ![]string foo()    # A failable function that returns a array of strings
```

Inside this function, we create a condition to verify the error as follows:

```abs
func !f32 safeDivide(f32 numerator, f32 denominator)
{
    if (denominator == 0) {
        # Raise a fault here!
    }

    return numerator / denominator
}
```

And we can use the `throw` statement to raise the exception,
passing after it the exception that we want to raise.
The fault is declarated when it is required to be created
and the same name will aways refer to the same fault.

:::info
We strongly reccomend to follow the pattern of fault names
writing them aways in pascal case (`PascalCase`) and aways
finish the name aways with `Fault`.
:::

```abs
func !f32 safeDivide(f32 numerator, f32 denominator)
{
    if (denominator == 0) {
        # Use the `new` operator to create a
        # fresh instance
        throw new DenominatorCannotBeZeroFault()
    }

    return numerator / denominator
}
```

In reality, the fault object is a tuple, so we can add some arguments
on it. \
Keep in mind that you cannot have faults with the same name and
different parameter types in the same scope!

```abs
func !f32 safeDivide(f32 numerator, f32 denominator)
{
    if (denominator == 0) {
        throw new DenominatorCannotBeZeroFault(
            "Denominator value cannot be 0!", numerator, denominator)
    }

    return numerator / denominator
}
```
