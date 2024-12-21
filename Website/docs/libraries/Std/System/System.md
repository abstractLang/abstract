---
title: System
---

# Std.System

:::under-construction
:::
:::not-implemented
:::


```abs
namespace Std.System
```

`Std.System` implements common interface with low-level, OS and hardware

---

## Namespaces
| Namespace | Description |
|:---------:|:------------|
| OS        | Implementetions of interfaces between the host OS APIs |
| x86       | Specific operations for the Intel x86 archtecture |
| x86_64    | Specific operations for the Intel x86_64 archtecture |
| AArch64   | Specific operations for the 64-bit ARM archtecture |
| RISK_V    | Specific operations for the RISK-V archtecture |

---

## Fields
| Field     | Type        | Acess                   | Description |
|:---------:|:-----------:|:-----------------------:|:------------|
| arch      | Archtecture | Read only, compile time | The reference of the archtecture being targeted for the build |
| os        | HostSystem  | Read only, compile time | The reference of the operational system targeted for the build |

---

## Enums

```abs
@public enum Archtecture {
    x86,
    x86_64,
    aarch64,
    risc_v
}
```

```abs
@public enum HostSystem {
    windows,
    linux,

    uefi,
    bios
}
```
