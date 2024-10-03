---
sidebar_position: 3
---

# Data Collections

Data collections are important components of a program, easily handling huge amounts of data. \
In abstract, are considerated data collections Arrays, Linked Lists, Queues, Stacks and Dictionaries, all of these
built-in data types or structures.

---
## Arrays

Array lists are one of the most basic collection type in programming. They are made based on the concept of a contiguous
sequence of data in the memory that can be indexed by it position on the list

```C
// In C and and in most programming languages, this is a example
// of how the user can create a sequence of integers in the memory.
int[10] myArray = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

// The array sintax allows the user to acess the 10 elements of the
// array using only it position
printf("%i, ", myArray[3]);
printf("%i, ", myArray[5]);
printf("%i ", myArray[7]);
// out: 3, 5, 7
```

In abstract, array types are delcared as follows:
```
[]AnyType
```
`[]` being a type modifier, indicating a array list of the following type

| abstract | Equivalent in C | Size in bits     |
|----------|:---------------:|:----------------:|
| [i]t     | t[i]            | bitSizeOf(t) * i |

*`t` - Any type \
*`i` - Array list size

As ArrayLists are not dinamically alocated in memory, needing to be allocated with a predefined size and cannot being resized
after it, the array initialization syntax allows the input of the prealocated length of the array betwen the array type modifier
`[length]`.

As sometimes is more convenient to don't pre-initialize the array with a number, but calculate it length based on a more verbose
declarated list, arrays also aceept the following syntax for initialization:
```abs
# pay attention on the empty type modifier!
[]AnyType = [values..]
```

Using the `[values...]` syntax is possible to initialize a generic ordered collection that will be used by the compiler to
calculate the array's desired length.

If the developer want to specify a array length but define only some of the elements, both syntaxes can be mixed.

Some ways of delcaring a array in Abstract are:
```abs
let [10]i32 myArray
const []string fruits = ["orange", "mango", "strawberry", "tomato"]
const [20]i8 myBytes = [255, 254, 253]
```

### The Index Operator
To handle single values inside a array, it's used the Index operator `[]`.

The index operator is delcared putting a number srounded by square brackets after the array indentifier.
The declarated number is the indexer, the position of the desired element on the list, starting by zero.

The index operator will return a element of the element type of the array, on the specified index, as follows:
```abs
let []i32 myArray = [10, 20, 30, 40, 50]
let i32 my1rtElement = myArray[1] # my1rtElement = 20
let i32 my2ndElement = myArray[2] # my2rtElement = 30

# The indexer also works with variables
let i8 myIndex = 0
Std.Console.log(myArray[myIndex]) # out: 10
myIndex = 4
Std.Console.log(myArray[myIndex]) # out: 50
```


---
## Linked Lists
:::warning[Not Implemented!]
:::

---
## Queues
:::warning[Not Implemented!]
:::

---
## Stacks
:::warning[Not Implemented!]
:::

---
## Dictionaries
:::warning[Not Implemented!]
:::
