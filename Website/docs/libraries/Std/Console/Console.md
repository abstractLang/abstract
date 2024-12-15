---
title: Console
---

# Std.Console

:::under-construction
:::
:::not-implemented
:::

```abs
namespace Std.Console
```

`Std.Console` abstracts the interaction between the program and the standard input/output
and console window

---

## Functions

::::funcdoc[write_anytype]

```abs
@public func void write(anytype content)
```
Writes the parameter in the configurated output stream. \
If the parameter's type do not implement a `toString()` method,
it will use the type's structure name instead.

:::funcdoc-params[anytype content]
The desired value to be wrote.
:::

::::

::::funcdoc[write_ARRanytype]

```abs
@public func void write([]anytype content)
```
Writes the parameter array in the configurated output stream. \
If the parameter's type do not implement a `toString()` method,
it will use the type's structure name instead.

:::funcdoc-params[[]anytype content]
The desired array to be wrote. 
:::

::::

::::funcdoc[writeln_anytype]

```abs
@public func void writeln(anytype content)
```
Writes the parameter in the configurated output stream. \
At the end, will also write the system's line feed string. \
If the parameter's type do not implement a `toString()` method,
it will use the type's structure name instead.

:::funcdoc-params[anytype content]
The desired value to be wrote.
:::

::::

::::funcdoc[writeln_ARRanytype]

```abs
@public func void writeln([]anytype content)
```
Writes the parameter array in the configurated output stream. \
At the end, will also write the system's line feed string. \
If the parameter's type do not implement a `toString()` method,
it will use the type's structure name instead.

:::funcdoc-params[[]anytype content]
The desired array to be wrote. 
:::

::::

::::funcdoc[read]

```abs
@public func string read()
```
Reads the next value inputed in the configurated input stream
and returns it as a string.

:::funcdoc-params[string !ret]
The inputed value.
:::

::::

