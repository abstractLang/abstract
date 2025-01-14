---
sidebar_position: 1
---

# Attributes

:::info[Under Construction]
:::

Attributes are a metaprogramming resource that allow the user to
link generic functions to be executed above program members, allowing
them to change the behavior of the program.

---

## Attributes from the Std Library

The Abstract's Starndard Library offers the implementation of some
usefefull attributes for generic use. These are all of them:

### Access attributes

These attributes controlls the access of the reference of the member.

| Attribute | Used in | Description |
|-----------|:-------:|-------------|
| `@public`                 | any program member | Allows any other member to access the reference |
| `@internal`               | any program member | Allows only members of the same project to access the reference |
| `@private`                | any program member | Allows only parent and sibling members to access the reference |
| `@allowAcessTo(string)`   | any program member | Allows the access of the member to a certain reference |
| `@allowAcessTo([]string)` | any program member | Allows the access of the member to a certain collection of references |
| `@denyAcessTo(string)`    | any program member | Denies the access of the member to a certain reference |
| `@denyAcessTo([]string)`  | any program member | Denies the access of the member to a certain collection of references |
| `@static`                 | any program member | Forces the member to be stored and accessed stactically |
| `@defineGlobal(string)`   | any program member | Creates a named reference for the member in the root of the program |
| `@defineGlobal([]string)` | any program member | Creates a collection of named references for the member in the root of the program |

### OOP attributes

These attributes controlls the Object-Oriented behavior of structures.

| Attribute | Used in | Description |
|-----------|:-------:|-------------|
| `@final`                  | Structures         | Denies acces of inheritance of other structures |
| `@abstract`               | Structures         | Marks a structure as abstract |
| `@interface`              | Structures         | Marks a structure as a interface |
| `@externInterface`        | Structures         | Marks a structure that will be implemented by a extern source |
| `@valueOnly`              | Structures         | Marks a structure as never alllowed to be alone in the heap |
| `@referenceOnly`          | Structures         | Marks a structure as never allowed to be allocated in the stack |
| `@virtual`                | Functions (with structure as parent) | Allows a function to be override in a structure that inherits it parent |
| `@override`               | Functions (with structure as parent) | Overrides a reference to a function of the inherited parent |

### Function attributes

These attributes modifies how functions are handled by the compiler.

| Attribute | Used in | Description |
|-----------|:-------:|-------------|
| `@inline`                          | Functions    | Force a function to be implemented instead of invoked when called |
| `@noInline`                        | Functions    | Force a function to be not inlined during optimization |
| `@comptime`                        | Functions    | Force a function to be executed during compilation |
| `@runtime`                         | Functions    | Force a function to be executed only during runtime |
| `@callConv(Std.Compilation.Abi)`   | Functions    | Declarate the convention used for the calling on binary targets that support different ABIs |

### Overloading attributes

Attributes that changes how references behaves when acessed or writed to.

| Attribute | Used in | Description |
|-----------|:-------:|-------------|
| `@get(string)` | Functions | Creates or modifies the nammed field in the parent function, using this function and it getter |
| `@set(string)` | Functions | Creates or modifies the nammed field in the parent function, using this function and it setter |
| `@indexerGet`  | Functions | Overloads the indexer operator for the parent function, using this function and it getter |
| `@indexerSet`  | Functions | Overloads the indexer operator for the parent function, using this function and it setter |
| `@implicitConvert`  | Functions | Registers a implicit conversion of the type in the first parameter of the function to the return type of the function |
| `@explicitConvert`  | Functions | Overloads the `as` operator to convert the type in the first parameter of the function to the return type of the function |
| `@overrideOperator` | Functions | Overloads the action of the specified operator |
| `@defineAttribute(string)`  | Functions | Register the function as a new attribute with the specified name |

---
## Creating your own attribute

TODO
