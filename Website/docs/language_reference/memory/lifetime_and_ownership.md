---
sidebar_position: 1
---

# Lifetime And Ownership

:::info[Under Construction]
:::

As part of the Abstract's philosophy, eficiency during memory management is one
of the main focus of the language. To help the user to do not get bothered with
the tiny details, as default, abstract uses a system based in lifetime and
ownership to determinate when data explicitly or implicitly allcated on the heap
can be safetly and automatically deallocated.

:::info
Don't confuse "lifetime and ownership" with "ownership and borrowing". The abstract
language do not include any kind of borrowing or a borrow checking.
:::

---
## Understanding Lifetime

In a procedural language like abstract, every program beggins in a certain defined
point (the entry point function) and expands it process in a linear stack, usually
finishing at the same scope that it beggins. The same way as the language knows
where a method starts, ends or a data is sent in or out a function, it can understand
where these data is being used and where it is being discarted.

let's take the following code as an example:
```abs
func !void main() {
    const message1 = "Hello, World!"
    sayMessage(message1)
    let message2 = "Today is a good day."
    sayMessage(message2)
    message2 = "How are you going?"
    sayMessage(message2)
}

func void sayMessage(string msg) {
    Std.Console.writeln(msg)
}
```

With a fast analysis, is not hard to understand when a data reference becomes
inaccessible:

```abs
func !void main() {
    const message1 = "Hello, World!"
    sayMessage(message1)
    let message2 = "Today is a good day."
    sayMessage(message2)
    message2 = "How are you going?"
    sayMessage(message2)
    # `message1` and `message2` becomes
    # out of scope after here
}

func void sayMessage(string msg) {
    Std.Console.writeln(msg)
    # `msg` becomes out of scope
    # after here
}
```

Also it is possible to go more further and identify when a reference is no
more used or it value has changed:

```abs
func !void main() {
    const message1 = "Hello, World!"
    sayMessage(message1)
    # `message1` is not used anymore
    let message2 = "Today is a good day."
    sayMessage(message2)
    # `message2` current value is lost here
    message2 = "How are you going?"
    sayMessage(message2)
    # `message2` is not more used
    # and becomes out of scope
    # after here
}

func void sayMessage(string msg) {
    Std.Console.writeln(msg)
    # `msg` is not more used
    # and becomes out of scope
    # after here
}
```

Knowing where variables are lost or get out of scope,
the best practice is aways request the data destruction
to make sure that any heap-allocated data from it is
well deallocated:

```abs
func !void main() {
    const message1 = "Hello, World!"
    sayMessage(message1)
    destroy message1 # `message1` is not used anymore

    let message2 = "Today is a good day."
    sayMessage(message2)
    destroy message2 # `message2` current value is lost here

    message2 = "How are you going?"
    sayMessage(message2)
    destroy message2

    # `message2` is not more used
    # and becomes out of scope
    # after here
}

func void sayMessage(string msg) {
    Std.Console.writeln(msg)
    # `msg` is not more used
    # and becomes out of scope
    # after here
}
```

---
## `TODO`

as the same way as Abstract implicitly allocate on heap,
it have a simple system of lifetime and ownershiping to know
when to try to automatically deallocate these allocations made.

Knowing as every struct can implement a destructor, the language
will follow the use of variables inside functions.

When a variable is created inside a function, it data is owned by this function.
When a variable is returned by the function, it data is owned by the caller too.

When a function returns (dies), it will, before of return the execution
to the caller, call the destructor of every structure that is owned ONLY
by the current function. after the function die, the references that was owned
but do not got deallocated will lost their ownership of this function and be
deallocated only when the ownership count of it be 0.

Instance data also have a lifetime, but thacked by the ownership of the
instance. When the instance dies and it destructor is called, it should
also call the destructor of it owned data.

-- lumi
