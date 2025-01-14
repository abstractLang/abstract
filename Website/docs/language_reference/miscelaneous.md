---
sidebar_position: 1
---


# Miscelaneous

## Comments

Comments are a special syntax resource that allows a section in the script
to not be included as executeable code. \
Most of it uses includes documentation or fast activation/deactivation of
lines or blocks of code.

---
### Single line comments

To declare the right section of a line as a comment, use the `#` character
to start a single-line comment.
```abs
IAm.executeable() # I am a comment!
```

---
### Multi line comments

To declare one section in the middle of a line or more than one line as comment,
use `###` to open and close the range.
```abs
IAm.executeable()
###
    I am a comment!
    Me too!
###
```
