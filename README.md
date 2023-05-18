# x-math
👉 A `C#` library that can calculate **extremely** large numbers.

## 📖 Document

### Data Types

(1) ```StringNumber```

    public struct StringNumber
    {
        public StringNumber(Boolean sign, string number){...}

        public Boolean Sign {...}
        public string Number {...}
    }

```Sign``` 
- ```true```: negative
- ```false```: positive

```Number```
- ```int``` value

### Operations

(1) ```Additions```

    public static StringNumber Additions(nums){...}

```nums```
- ```StringNumber[]``` value

## 🏗️ Work in progress
- Fraction
- Product