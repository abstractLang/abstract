---
sidebar_position: 2
title: Your First Program
---

# Creating Your First Program
:::info[Under Construction]
:::


This document will help you how to set up Abstract's tools in your
machine as well as how to create, organize and execute your first
program.

---
## Setting up the environment

TODO

To start a new project, begin creating a new directory folder to
organize the project into the same place. For this example, let's
call the folder `MyProgram`;

---
## Writing the program

Inside the `MyProgram` folder, create a script file with the
`.a` extension e.g., `main.a`.

Inside the script file, write the following code:
```abs title="main.a"
import from Std.Console

function !void main() {
    writeln("Hello, World!")
    writeln("I'm coding in abstract!")
}

```

---
## Building

Abstract offers two ways to build the program: Using the command
line to directly call the compiler or use a build script to talk
to the compiler for you.

### Building with the command line

Using the command line, you can invoke the following command to build
and run the scrpt:

```shell
abs run main.a -o bin/
```


### Building with a build script

To use a build script, create a new script with the `.a`
extension like `build.a`.

To use a build script, we recommend you to follow this
directory organization:

```text title="MyProgram/"
Src/
 '- main.a   
build.a
```

TODO

---


