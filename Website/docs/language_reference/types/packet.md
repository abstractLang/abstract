---
sidebar_position: 5
---

# Packet
:::info[Under Construction]
:::
:::warning[Not Implemented!]
:::

While a `struct` may reorganize it layout on memory in unexpected ways, packets are made to be a exact
1:1 map of it implementation to memory.

Packets are designed to not just have total precision on it size in memory as too allow the user to
have full controll of the layout of all the bits stored on it.

---
## Implementation and Usage

Packets can be implemented by the following:
```abs
packet(8) MyDinner {
    bool hasFork
    bool hasSpoon
    bool hasKnife
    bool hasPlate
    u4 hungerLevel
}
```

The parameter x in `packet(x)` indicates the total size, in bits, of the object in memory.
The parameter is, however, optional and will be automatically calculated by the compiler if
not provided. \
Inside the packet, you can include primitives, other packets or references to most complex
types.

However, the primitives declarated on a packet aren't the same as the usual Abstract primitives!
You can see more about packet exclusive types in [Packet Types](#types-and-layout-modifiers)

To use a packet, declarate a variable as the packet's identifier and fill, manually, it's data
as follows:
```abs
let MyDinner dinner = MyDinner {
    hasFork: true,
    hasSpoon: true,
    hasKnife: true,
    hasPlate: false,
    hungerLevel: 10
}
```

and you can use the dot operator (`.`) to acess it fields:
```abs
    if !dinner.hasFork => Std.Console.log("Comrade doesn't have a fork!");
    if !dinner.hasSpoon => Std.Console.log("Comrade doesn't have a spoon!");
    if !dinner.hasKnife => Std.Console.log("Comrade doesn't have a knife!");
    if !dinner.hasPlate => Std.Console.log("Comrade doesn't have a plate!");

    if !dinner.hungerLevel > 10 => Std.Console.log("Starving!");
    else if !dinner.hungerLevel > 5 => Std.Console.log("Hungry!");
```

```text title="Console Output"
Comrade doesn't have a plate!
Hungry!
```

---
## Extending Packets

As packets doesn't allow any method implementation inside them, if you want to manipulate packets,
you will need to use a static function for this:

```abs
packet(8) Character {
    i4 level,
    u4 exp
}

@static func Character NewChar() {
    return Character {
        level: 0,
        exp: 0
    }
}

@static func void addExp(*FixedPoint _self, u8 e) {
    _self.exp += e
    if Assembly.flagsRegister.Overflow => level++
}

let Character jake = NewChar()
let Character sam = NewChar()

addExp(&jake, 10)
addExp(&sam, 5)
```

Or using the extensor attribute to extends the packet's symbol with static functions:
```abs
@static @extensor func void addExp(*FixedPoint _self, u8 e) {
    _self.exp += e
    if Assembly.flagsRegister.Overflow => level++
}

...
jake.addExp(10)
sam.addExp(5)
```

the extensor attribute can also be used in structs to build packets with complex behaviors:
```abs
packet(8) Character {
    i4 level,
    u4 exp
}
# to make the link between the packet and the structure,
# the structure should be marked with @static and @extensor.
@static @extensor struct Character {

    @static @extensor func Character NewChar() {
        return Character {
        level: 0,
        exp: 0
    } 

    @static @extensor func void addExp(*FixedPoint _self, u8 e) {
        _self.exp += e
        if Assembly.flagsRegister.Overflow => level++
    }

}

let Character jake = Character.NewChar()
let Character sam = Character.NewChar()

jake.addExp(10)
sam.addExp(5)
```

---
## Types and Layout Modifiers

### Integers

Integer types follows the same format as the [default integers](../types/numeric), but can have
any number greater than zero of bits to represent it on memory.

```abs
# unsigned integers
u[bit length]
# signed integers
i[bit length]

## examples: ##
u1      # 1 bit unsigned integer
i100    # 100 bit signed integer
i5      # 5 bit signed integer
u4      # 4 bit unsigned integer
```

### Floats

Floats are very limitated do manipulate with the CPU. because of this, you can only use the default
`f32` or `f64`.

```abs
# 32 bit floating point representation (or singles)
f32
float

# 64 bit floating point representation (or doubles)
f64
double
```

### Booleans

Booleans are, as default, of 1 bit length.
```abs
# 1 bit boolean
bool
```

### Strings

In packets, strings are limited to a certain ammount of characters.
This ammount is based on it predefined byte count, where one byte is
aways reservated to the null character `\0` and some characters can
expend more than one byte if they're not limitated to the ASCII table
range.
```abs
# A string with N bytes
string[N]

# Examples:
string[500] # A string with max. 499 characters
string[20 + 1] # A string with max. 20 characters
string[1] # A string with 0 characters
```

### Packets

Packets references can be included inside other packets.

```abs
packet NullableInteger32 {
    bool isNull,
    u32 address
}

packet Attributes {
    NullableInteger32 stength,
    NullableInteger32 magic,
    NullableInteger32 stealth,
}
```

### Structures and References
TODO

### Offset

In some cases, where some structures can use reserved or ignored bits,
it's possible to use Offsets to jump these.

```abs
packet MyPack {
    bool firstBit,
    offset(6),     # Jumps 6 bits
    bool lastBit,
}
```

