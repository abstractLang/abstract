---
sidebar_position: 1
---


# Miscellaneous

## Comments

Comments are a special syntax resource that allows a section in the script
to not be included as executeable code. \
Most of it uses includes documentation or fast activation/deactivation of
lines or blocks of code.

---
### Single line comments

The `#` character can be used to declare the section of a line on its right
as a comment.
```abs
IAm.executeable() # I am a comment!
```

---
### Multi-line comments

Enclose a section or chunk of lines with `###` to declare it as a multi-lined
comment.
```abs
IAm.executeable()
###
    I am a comment!
    Me too!
###
```
