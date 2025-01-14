---
sidebar_position: 9
title: Importing
---

# Importing Modules and Namespaces

:::info[Under Construction]
:::
:::warning[Not implemented!]
:::

Importing allows to use references outside the current script
and scope. Abstract offers different ways to import diferent
references as needed for the user and in a way to allow the
readability of the code.

---

## Importing namespaces

simple imports can be done by writing:
```abs
import from <namespace>
```

Being `<namespace>` the relative or global reference to a namespace
that is desired to import.

A example of simple import is:
```abs
import from Std.Console
```

Simple imports will allow the code to directly access references of
the imported namespace is if inside it:

```abs
import from Std.Console

namespace MyProgram {

    func !void main() {
        # `writeln` is not a member of the `MyProgram` namespace,
        # in reality it is being imported from `Std.Console`!
        writeln("Hello, World!")
    }

}
```

---
## Specifiing Imports

Sometimes, is not necessary to import a entire namespace or doing so
can cause a conflict with another member. Because of it, Abstract
allows to specify what is being imported to the current scope with the
syntax:

```abs
import { <ref...> } from <namespace>
```

Being `<namespace>` the parent of the desired imported content and
`<ref...>` the references, separated by comma, of the desired members
of the refered namespace.

Doing it also will not only import the desired content, as well scope
the content of what is being imported inside a reference of the same name.

e. g.:
```abs
import { Console, Memory } from Std
# `Console` and `Memory` is now directly referenceable

namespace MyProgram {
    func !void main() {       
        Console.writeln("Hello, World!")
    }
}
```

```abs
import { write } from Std.Console
# only the `write` function is being imported

namespace MyProgram {

    func !void main() {       
        write("Hello, World, ")
        # Other references still need to be refered
        # from the root!
        Std.Console.writeln("I'm importing references!")
    }

}
```


---
## Import with alias

To avoid reference conflicts or have control about the imported reference,
is still possible to renemed it as desired using the keyword `as` as follows:

```abs
import { write, writeln as writeLine } from Std.Console

namespace MyProgram {

    func !void main() {       
        write("Hello, World, ")
        # Instead of refering as `writeln`, the function is
        # refered as `writeLine`!
        writeLine("I'm importing references!")
    }

}
```
