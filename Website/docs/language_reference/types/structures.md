---
sidebar_position: 4
---

# Data structures and OOP
:::info[Under Construction]
:::

Data structures, also known as complex data types, are type abstractions o manipulate data in expecific ways that the
primitive data types don't allow.

Data structures can hold a huge ammount of primmitives, other data structures and even functinons, allowing it to be a
powerfull and rich tool for data storage, organization and encapsulation.

---
## Structures

Structures are the way of how you can declarate a new data type in the Abstract language. In it, you can organize collections
of primitives, privatize certain variables in closed scopes, abstract the management of huge amonts of data, and go on.

A example of a structure being declarated and used in Abstract is:
```abs
struct Biography {
    @public let u8 myAge
    @public let string myName
    @public let string myGithub
}

# this is creating a new variable of type Biography!
let Biography myBio = new Biography();

myBio.myAge = 17
myBio.myName = "Camila"
myBio.myGithub = "lumi2021"
```

the structure `Biography` on the example have 3 fields, an integer `myAge` and two strings `myName` and `myGithub`.
The resulting size of this structure, in memory, will be, *in most cases*, the sum of all fields  plus a aditional
constant pointer that indicates it type in a global type table. This implicit data is important to allow the program
to know the type of the structure anywhere during runtime.
---
### Constructors

Sometimes, is usefull to have a single function to abstract complex initialization of data.
for instance, take the following structure declaration example:
```abs
struct Biography {
    @public let string name
    @public let string github

    @public let u8 birthYear
    @public let u8 age
}
```

To initialize this structure, the following code:
```abs
# Declarating the variable and creating the instance...
let Biography myBio = new Biography();
# Defining the initial data ...
myBio.name = "Camila"
myBio.github = "lumi2021"
myBio.age = 17
myBio.birthYear = 2007
```

To make life easyer, the language allows to declarate a special function that will be called automatically
when the structure is initialized, called constructor. The constructor can accept parameters, read and set
variables and run code as any function can do.

A constructor can be declarated as follows:
```abs
struct Biography {
    ...
    constructor() {
        # This will run when the structure is instantiated!
    }
}
```

As it need some input data, the constructor will ask for some arguments:
```abs
struct Biography {
    ...
    constructor(string name, string gh, string age) {
        # This will run when the structure is instantiated!
    }
}
```

:::info
When a constructor is declarated on the structure, to instantiate it, will be required to match the parameters of one of the
declarated constructors (it includes empty constructors).
:::


after that, we can process the data how we want:
```abs
struct Biography {
    ...
    constructor(string name, string gh, string age) {
        # `this` is used to get the current instance.
        # it should be used in case of naming conflict.
        # Oterwise, it's unecessary.
        this.name = name;
        github = gh;
        this.age = age;
        birthday = 2024 - age;
    }
}
```

---
### Static Functions and Methods
:::warning[Not Implemented!]
:::

---
## Object-Oriented Programming
:::warning[Not Implemented!]
:::

Object-Oriended Programming in a programming paradigm that uses objects concept to develop programs.
Even Abstract being mainly based on procedural programming paradigm, Object-Orientation can be implemented
using structures.

In OOP, a object is refered as a structure that includes fields and precesses, like functions. Also,
the object-orientation have 3 important concepts that objects need to be able to follow.

---
### Structures and Classes
:::warning[Not Implemented!]
:::

---
### Manipulating Structures as References
:::warning[Not Implemented!]
:::

---
### Structure Inheritance
:::warning[Not Implemented!]
:::

---
### Structure Encapsulation
:::warning[Not Implemented!]
:::

---
### Structure Polymorfism
:::warning[Not Implemented!]
:::
