---
sidebar_position: 1
---

# Lifetime And Ownership

:::info[Under Construction]
:::

// TODO

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

