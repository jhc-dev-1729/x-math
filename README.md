# x-math
👉 A `C#` library that can calculate **extremely** large numbers.

## 📖 Document

### Data Types

#### StringNumber
``` cs
public struct StringNumber
{
    public StringNumber(Boolean sign, string number) {...}

    public Boolean Sign {...}
    public string Number {...}

    ...
}
```

```Sign``` 
- ```true```: negative
- ```false```: positive

```Number```
- ```int``` value

#### Fraction
``` cs
public struct Fraction
{
    public Fraction(Boolean sign, StringNumber numerator, StringNumber denominator) {...}

    public Boolean Sign {...}
    public StringNumber Numerator {...}
    public StringNumber Denominator {...}

    ...
}
```

```Sign``` 
- ```true```: negative
- ```false```: positive

```Numerator```
- ```int``` value

```Denominator```
- ```int``` value

### Operations

#### Single Addition and Substraction (StringNumber only)
``` cs
public static StringNumber operator +(StringNumber strnum){...}
public static StringNumber operator -(StringNumber strnum){...}
```
##### Example
``` cs
using ExtremeCalculatorDataType;
...
    StringNumber strnum1 = new StringNumber(false, "123");
    StringNumber strnum2 = new StringNumber(true, "123");

    Console.WriteLine(-strnum1); // -123
    Console.WriteLine(-strnum2); // 123
...
```

#### Addition and Substraction (StringNumber only)
``` cs
public static StringNumber operator +(StringNumber strnum1, StringNumber strnum2){...}
public static StringNumber operator -(StringNumber strnum1, StringNumber strnum2){...}
```
##### Example
``` cs
using ExtremeCalculatorDataType;
...
    StringNumber strnum1 = new StringNumber(false, "123");
    StringNumber strnum2 = new StringNumber(false, "456");
    StringNumber strnum3 = new StringNumber(false, "789");

    Console.WriteLine(strnum1 + strnum2 + strnum3); // 1368
    Console.WriteLine(strnum1 - strnum2 - strnum3); // -1122
...
```

## 🏗️ Work in progress
- StringNumber Product
- Fraction Operations
