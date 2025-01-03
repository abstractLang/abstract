---
sidebar_position: 8
---

# Nullability
:::info[Under Construction]
:::
:::warning[Not Implemented!]
:::

In abstract, for security reasons, all data and data reference is assumed to exist and
be acessable as default . However, very often is usefull to have a way to identify if a
data, object or reference exists and is acessible or not.

Abstract allows to specify when a data can be expected to be nullable or not, also allowing
a variety of security features to prevent errors when acessing null values.

---
## The nullable wrapper

Abstract allows to declarate nullable types wrapping them with the nullable structure.
This wrapping can be also easily made putting the interrogation (`?`) character right
before the desired type.
```abs
?void    # same as Std.Types.Nullable(void)
?i32     # same as Std.Types.Nullable(i32)
?string  # same as Std.Types.Nullable(i32)
```

---
## Managing wrapped values

The language also provides some features to make the life using nullable types esier.

### Getting the data

The nullable wrapper will not allow you to access the data directly.
```abs
func ?i32 foo() { ... }

# This is a compilation error!
let i32 myNumber = foo()
```

Instead, you have two options to acess the internal data: \
Checking if the value is not null or ignoring the possibility of a null value.

you can easily check the existence of the value using a conditional statement
and use the unrapped value in the condition scope as follows:

```abs
func ?i32 foo() { ... }

let ?i32 myNumber = foo()
if (myNumber) {
    # Inside the if scope, `myNumber` is shadowed
    # to unwrap the value
    let i32 value = myNumber
}

# Compilation Error! `?i32` is not assignable to `i32`
let i32 value = myNumber

```

Or ignore the check and manually unrap the condition using the `.unwrap()` call
or the `?` operator:
```abs
func ?i32 foo() { ... }

let i32 myNumber = foo()?

### is the same as ###

let i32 myNumber = foo().unwrap()
```

If you have a default value to use in case of null, you can use the `??` operator to
try to unwrap the expression and use the next expression if it's null:

```abs
func ?i32 foo() { ... }

let i32 value = foo() ?? 0

### is the same as ###

let i32 value
let ?i32 nullable = foo()
if (nullable) value = nullable
else value = 0

```
