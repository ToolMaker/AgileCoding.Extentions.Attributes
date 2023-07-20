# AgileCoding.Extensions.Attributes NuGet Package

This NuGet package contains a single, powerful extension method that provides additional functionality to handle attribute related operations in .NET applications.

## Features

The `GetAttribute<ANYType>()` method, defined within the `AttributeExtensions` static class, retrieves a specific attribute associated with an enum, class or any other complex type.

## How to Use

```csharp
using AgileCoding.Extentions.Attributes;

// assuming we have an enum with custom attributes
public enum MyEnum
{
    [MyCustomAttribute("Value1")]
    Value1,

    [MyCustomAttribute("Value2")]
    Value2,
}

public class MyCustomAttribute : Attribute
{
    public MyCustomAttribute(string value)
    {
        Value = value;
    }

    public string Value { get; }
}

// To use the extension method:
MyEnum myEnumVariable = MyEnum.Value1;
var attributeValue = myEnumVariable.GetAttribute(typeof(MyCustomAttribute));
```

## Installation

You can install this NuGet package through the following ways:

### Package Manager

```
PM> Install-Package AgileCoding.Extentions.Attributes
```

### .NET CLI

```
dotnet add package AgileCoding.Extentions.Attributes
```

## Requirements

- .NET 6.0 or later

## Contribute

This is an open source project. We encourage you to contribute to it by submitting issues, or directly contributing code.

## License

This project is licensed under the terms of the MIT license.

## Contact

For questions or any other feedback, please open an issue in the GitHub repository.