---
title: Process
---

# Std.Process

:::under-construction
:::
:::not-implemented
:::

```abs
namespace Std.Process
```

`Std.Process` abstracts the management of the current process,
parallel tasks and threads.

---

## Functions

::::funcdoc[exit_isize]
```abs
@public func noreturn exit(isize error)
```
Aborts the current process execution.

:::funcdoc-params[isize error]
The error status code.
:::
::::
