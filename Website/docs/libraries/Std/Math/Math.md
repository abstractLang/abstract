---
title: Math
---

# Std.Math

:::under-construction
:::
:::not-implemented
:::

```abs
namespace Std.Math
```

`Std.Math` conteins a diversity of mathematical functions and structures

---

## Structures
| Structure | Description |
|:---------:|:------------|
| Vector2   | A generic vector of 2 dimensions |
| Vector3   | A generic vector of 3 dimensions |
| Vector4   | A generic vector of 4 dimensions |

## Fields
| Field | Type | Access           | Description |
|:-----:|:----:|:----------------:|:------------|
| PI    | f64  | Public, constant | The value of PI |
| E     | f64  | Public, constant | The value of the Euler's number |

---

## Functions

::::funcdoc[sin_T_rad]
```abs
@public func T sin(type T, T rad)
```

Returns the sine value for the provided angle in radians.

:::funcdoc-params[type T]
Generic type for the provided and returned value.
:::
:::funcdoc-params[T rad]
The angle value, in radians.
:::
:::funcdoc-params[T !ret]
The sine value of `rad`.
:::
::::

::::funcdoc[cos_T_rad]
```abs
@public func T cos(type T, T rad)
```

Returns the cossine value for the provided angle in radians.

:::funcdoc-params[type T]
Generic type for the provided and returned value.
:::
:::funcdoc-params[T rad]
The angle value, in radians.
:::
:::funcdoc-params[T !ret]
The cossine value of `rad`.
:::
::::

::::funcdoc[tan_T_rad]
```abs
@public func T tan(type T, T rad)
```

Returns the tangent value for the provided angle in radians.

:::funcdoc-params[type T]
Generic type for the provided and returned value.
:::
:::funcdoc-params[T rad]
The angle value, in radians.
:::
:::funcdoc-params[T !ret]
The tangent value of `rad`.
:::
::::

::::funcdoc[atan_T_val]
```abs
@public func T atan(type T, T x)
```

Returns the arc-tangent of `x`.

:::funcdoc-params[type T]
Generic type for the provided and returned value.
:::
:::funcdoc-params[T x]
The value.
:::
:::funcdoc-params[T !ret]
The arc-tangent value of `val`.
:::
::::

::::funcdoc[atan2_T_val]
```abs
@public func T atan2(type T, T x, T y)
```

Returns the arc-tangent of the `x/y` value.
Is more secure than [`atan`](#atan_t_val) as it provides
the zero check of `y`.

:::funcdoc-params[type T]
Generic type for the provided and returned value.
:::
:::funcdoc-params[T x]
The X value.
:::
:::funcdoc-params[T y]
The Y value
:::
:::funcdoc-params[T !ret]
The arc-tangent value of `x/y`.
:::
::::

::::funcdoc[sqrt_T_val]
```abs
@public func T sqrt(type T, T val)
```

Returns the square root of the providade value.

:::funcdoc-params[type T]
Generic type for the provided and returned value.
:::
:::funcdoc-params[T val]
The value.
:::
:::funcdoc-params[T !ret]
The square root of `val`.
:::
::::

::::funcdoc[abs_T_val]
```abs
@public func T abs(type T, T val)
```

Returns the absolute value of a signed number.

:::funcdoc-params[type T]
Generic type for the provided and returned value.
:::
:::funcdoc-params[T val]
The value.
:::
:::funcdoc-params[T !ret]
The absolute value of `val`.
:::
::::

::::funcdoc[ceil_T_val]
```abs
@public func T ceil(type T, T val)
```

Returns the smallest integral value greater or equal than `val`.

:::funcdoc-params[type T]
Generic type for the provided and returned value.
:::
:::funcdoc-params[T val]
The value.
:::
:::funcdoc-params[T !ret]
The ceil value of `val`.
:::
::::

::::funcdoc[floor_T_val]
```abs
@public func T floor(type T, T val)
```

Returns the smallest integral value lesser or equal than `val`.

:::funcdoc-params[type T]
Generic type for the provided and returned value.
:::
:::funcdoc-params[T val]
The value.
:::
:::funcdoc-params[T !ret]
The floor value of `val`.
:::
::::

::::funcdoc[truncate_T_val]
```abs
@public func T truncate(type T, T val)
```

Returns the provided value rounded towards zero.

:::funcdoc-params[type T]
Generic type for the provided and returned value.
:::
:::funcdoc-params[T val]
The value to be truncated.
:::
:::funcdoc-params[T !ret]
The truncated value
:::
::::

::::funcdoc[round_T_val]
```abs
@public func T round(type T, T val)
```

Returns the provided value rounded to the nearest integer.

:::funcdoc-params[type T]
Generic type for the provided and returned value.
:::
:::funcdoc-params[T val]
The value to be rounded.
:::
:::funcdoc-params[T !ret]
The nearest integer.
:::
::::

::::funcdoc[deg2rad_T_val]
```abs
@public func T deg2rad(type T, T deg)
```

Converts the provided degress angle to radians.

:::funcdoc-params[type T]
Generic type for the provided and returned value.
:::
:::funcdoc-params[T deg]
The angle value, in degress.
:::
:::funcdoc-params[T !ret]
The angle value, in radians.
:::
::::

::::funcdoc[rad2deg_T_val]
```abs
@public func T rad2deg(type T, T rad)
```

Converts the provided radians angle to degress.

:::funcdoc-params[type T]
Generic type for the provided and returned value.
:::
:::funcdoc-params[T rad]
The angle value, in radians.
:::
:::funcdoc-params[T !ret]
The angle value, in degress.
:::
::::

::::funcdoc[log_T_val]
```abs
@public func T log(type T, T val, T base)
```

Returns the logarithm of the provided value in the providade base.

:::funcdoc-params[type T]
Generic type for the provided and returned value.
:::
:::funcdoc-params[T val]
The value.
:::
:::funcdoc-params[T base]
The base.
:::
:::funcdoc-params[T !ret]
The logarithm of `val` in base `base`.
:::
::::
