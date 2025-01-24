---
sidebar_position: 3
---

# Data Collections
:::info[Under Construction]
:::

Data collection is an extremely important component of a program for easy and efficient handling of huge amounts of data. \
In abstract, some data collections are Arrays, Linked Lists, Queues, Stacks and Dictionaries, all of these are
built-in data types or structures.

---
## Arrays
:::warning[Not Implemented!]
:::

Array lists are one of the most basic collection type in programming. They are based on the concept of a contiguous
sequence of data in the memory that can be indexed by its position on the list.

```C
// In C and and in most programming languages, this is a example
// of how the user can create a sequence of integers in the memory.
int[10] myArray = {0, 3, 6, 9, 12, 15, 18, 21, 24, 27};

// The array syntax allows the user to access the 10 elements of the
// array using only it position
printf("%i, ", myArray[3]);
printf("%i, ", myArray[5]);
printf("%i ", myArray[7]);
// out: 9, 15, 21
```

In abstract, array types are delcared as follows:
```
[]AnyType
```
`[]` being a type modifier, indicating an array list of the following type

| abstract | Equivalent in C | Size in bits     |
|----------|:---------------:|:----------------:|
| [i]t     | t[i]            | bitSizeOf(t) * i |

*`t` - Type of elements \
*`i` - Array list size

ArrayLists are not dynamically allocated in memory. They need to be allocated with a predefined size and cannot be resized
after creation. 
The array initialization syntax pre-allocated memory based on the length of the array which is
mentioned between the array type modifier `[length]`. e.g. the following code will create an array for
the i32 type with pre-allocated memory to only 5 elements of the i32 type:
```abs
let [5]i32 myArray
```

Sometimes it is more convenient to just assign the elements to an array without counting how many elements it has.
In that case, the Abstract compiler can figure out the length on its own. Hence, the following syntax is also valid:
```abs
# pay attention to the empty type modifier!
let []AnyType = [values..]
```

If the developer want to specify an array length but define only some of the elements, then
both the syntaxes can be mixed.

Some ways of declaring an array in Abstract are:
```abs
let [10]i32 myArray
const []string fruits = ["orange", "mango", "strawberry", "tomato"]
const [20]i8 myBytes = [255, 254, 253]
```

### The Index Operator
To handle single values inside an array, it uses the index operator `[]`.

The index operator is declared putting a number surrounded by square brackets after the array indentifier.
The declared number is the index, the position of the desired element on the list, starting from zero.

The index operator will return an element from the array, at the specified index, as follows:
```abs
let []i32 myArray = [10, 20, 30, 40, 50]
let i32 elementAt1 = myArray[1] # my1rtElement = 20
let i32 elementAt2 = myArray[2] # my2rtElement = 30

# The index also works with variables
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
