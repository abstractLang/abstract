---
sidebar_position: 11
---

# Inlined Assembly

:::info[Under Construction]
:::

// TODO

assembly can be inlyned directly inside a scope by calling the
assembler functions during the final step of the build pipeline.

The target will provide a library with interfaces to allow this
connection.

As a example of use, being targeted to x86_64 assemby:

```abs
import from Std.Console
import { Instructions as opcode, ReferenceOperators as refas } from Std.System.Assembly.x86_64Assembly

func void foo()
{

    let string message = "Hello, World!";

    opcode.MOV(.RDI, refas.memptr(message))
    opcode.CALL(refas.memptr(writeln))

}

```
